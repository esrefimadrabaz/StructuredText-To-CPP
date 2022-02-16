# StructuredText-To-CPP
Script for translating basic structured text functions to CPP

C# Console App for translating not so complex IEC61131-3(Structured Text) functions to CPP, potentially to be used by a MCU with further modifications to the App.
Important Points
- Function needs to start with FUNCTION (identifier) and end with END_FUNCTION;
- Variable declaration field should right after the Function declaration starting with only VAR and ending with END_VAR;
- All END_(...) statements should end with semicolons.
- The grammar file is a roughly modified Pascal grammar thats present in the main Antlr repo.

The Application isn't meant to be used standalone at this point. I wrote it to use in an another project.
