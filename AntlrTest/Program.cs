using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace StoCPP
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            using (StreamReader Reader = new StreamReader("..\\..\\Input.txt"))
            {
                 input = Reader.ReadToEnd();
            }
            ICharStream stream = CharStreams.fromString(input);
            ITokenSource lexer = new GrammarLexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            GrammarParser parser = new GrammarParser(tokens);
            parser.BuildParseTree = true;
            IParseTree tree = parser.function(); // -> BoilerPlate

            KeyPrinter printer = new KeyPrinter();
            ParseTreeWalker.Default.Walk(printer, tree);
            
            Console.WriteLine(printer.Text);
            Console.ReadLine();
        }
    }
}
