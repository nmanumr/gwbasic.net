using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace GwBasic.Net
{
    partial class SyntaxEditor
    {

        public AutocompleteMenu popupMenu;

        string[] Function =
        {
            "ABS ", "ASC ", "ANT ", "CDBL ", "CHR$ ", "CINT ", "COS ", "CSNG ", "CVI ", "CVS ", "CVD ", "DATE$ ",
            "ENVIRON$ ", "EOF ", "EXP ", "EXTERR ", "FIX ", "FRE ", "HEX$ ", "INP ", "INPUT$ ", "INSTR ", "INT ",
            "LEFT$ ", "LEN ", "LOC ", "LOF ", "LOG ", "LPOS ", "MID$ ", "MKI$ ", "MKS$ ", "MKD$ ", "OCT$ ", "PEEK ", "PEN ",
            "PLAY ", "PMAP ", "POINT ", "POS ", "RIGHT ", "RND ", "SGN ", "SIN ", "SPACE$ ", "SPC ", "SQR ", "STICK ", "STRIG ",
            "STRING$ ", "STR$ ", "TAB ", "TAN ", "TIMER ", "USR ", "VAL ", "VARPTR ", "VARPTR$ "
        };

        string[] Statement =
        {
            "BEEP ", "CALL ", "CHAIN ", "CIRCLE ", "CLOSE ", "CLS ", "COLOR ", "COMMON ", "COM ", "DATA ", "DEF FN ", "DATE$ ",
            "DEFDBL ", "DEFSTR ", "DEFINT ", "DEFSNG ", "DEF SEG ", "DEF USR ", "DIM ", "DRAW ", "END ", "ENVIRON ",
            "ERASE ", "ERROR ", "FIELD ", "GET ", "GOSUB ", "GOTO ", "IF ", "THEN ", "ELSE ",
            "INPUT ", "INPUT# ", "IOCTL ", "KEY ", "LET ", "LINE ", "LINE INPUT ", "LINE INPUT# ", "LOCATE ", "LOCK ",
            "LPRINT USING ", "LPRINT ", "RSET ", "LSET ", "MID$ ", "ON ", "OPEN ", "OPTION BASE ", "OUT ", "PAINT ", "PALETTE ",
            "PALETTE USING ", "PEN ", "PLAY ", "POKE ", "PRESET ", "PSET ", "PRINT ", "PRINT# ",
            "PRINT USING ", "PUT ", "RANDOMIZE ", "READ ", "REM ", "RESTORE ", "RESUME ", "RETURN ", "SHELL ", "SOUND ",
            "STRIG ", "SWAP ", "TIME$ ", "OPEN \"COM( ", "UNLOCK ", "VIEW ", "VIEW PRINT ", "WAIT ", "WIDTH ", "WINDOW ",
            "WRITE ", "WRITE# ", "FOR ", "NEXT ", "ElSE ", "WHILE ", "WEND ", "IF ", "THEN "
        };

        string[] Command =
        {
            "CLEAR ", "CONT ", "CHDIR ", "BLOAD ", "AUTO ", "DELETE ", "FILES ", "KILL ", "LIST ", "LLIST ", "LOAD ",
            "MERGE ", "MKDIR ", "NAME ", "NEW ", "PCOPY ", "RENUM ", "RESET ", "RMDIR ", "RUN ", "SAVE ", "SYSTEM ", "TRON ",
            "TROFF "
        };

        string[] Variable = { "CSRLIN ", "DATE$ ", "ERDEV ", "ERDEV$ ", "ERL ", "ERR ", "INKEY$ ", "TIME$ " };

        string[] Events = { "ON TIMER ", "ON STRIG ", "ON PLAY ", "ON PEN ", "ON KEY ", "ON COM ", "ON ERROR GOTO " };

        //string[] snippets = { "if(^)\n{\n;\n} ", "if(^)\n{\n;\n}\nelse\n{\n;\n} ", "for(^;;)\n{\n;\n} ", "while(^)\n{\n;\n} ", "do${\n^;\n}while(); ", "switch(^)\n{\ncase : break;\n}" };
        static readonly string[] sources = new string[]
        {
            "ABS ", "ASC ", "ANT ", "CDBL ", "CHR$ ", "CINT ", "CIRCLE ", "COM ", "COS ", "CSNG ", "CSRLIN ", "CVI ", "DATE$ ",
            "ENVIRON$ ", "EOF ", "EXP ", "EXTERR ", "FIX ", "FRE ", "HEX$", "INKEY$", "INP", "INPUT$", "INSTR", "INT",
            "LEFT$", "LEN", "LOC", "LOF", "LOG", "LPOS", "MID$", "MKI$", "MKS$", "MKD$", "OCT$", "PEEK", "PEN",
            "PLAY", "PMAP", "POINT", "POS", "RIGHT", "RND", "SGN", "SIN", "SPACE$", "SPC", "SQR", "STICK", "STRIG",
            "STRING$", "STR$", "TAB", "TAN", "TIMER", "USR", "VAL", "VARPTR", "VARPTR$", "WHILE", "WEND",

            "CLEAR", "CONT", "CHDIR", "BLOAD", "AUTO", "DELETE", "FILES", "KILL", "LIST", "LLIST", "LOAD",
            "MERGE", "MKDIR", "NAME", "NEW", "PCOPY", "RENUM", "RESET", "RMDIR", "RUN", "SAVE", "SCREEN", "SYSTEM",
            "TRON", "TROFF",

            "BEEP", "CALL", "CHAIN", "CIRCLE", "CLOSE", "CLS", "COLOR", "COMMON", "COM", "DATA", "DEF FN",
            "DEFDBL", "DEFSTR", "DEFINT", "DEFSNG", "DEF SEG", "DEF USR", "DIM", "DRAW", "END", "ENVIRON",
            "ERASE", "ERROR", "FIELD", "FOR", "NEXT", "GET", "GOSUB", "RETURN", "GOTO", "IF", "THEN", "ELSE",
            "INPUT", "INPUT#", "IOCTL", "KEY", "LET", "LINE", "LINE INPUT", "LINE INPUT#", "LOCATE", "LOCK",
            "LPRINT USING", "LPRINT", "RSET", "LSET", "MID$", "ON TIMER", "ON STRIG", "ON PLAY", "ON PEN",
            "ON KEY", "ON COM", "ON ERROR GOTO", "ON", "OPEN", "OPTION BASE", "OUT", "PAINT", "PALETTE",
            "PALETTE USING", "PEN", "PLAY", "POKE", "PRESET", "PSET", "PRINT", "PRINT#", "PRINT# USING",
            "PRINT USING", "PUT", "RANDOMIZE", "READ", "REM", "RESTORE", "RESUME", "RETURN", "SHELL", "SOUND",
            "STRIG(", "SWAP", "TIME$",

            "ERDEV", "ERDEV$", "ERL", "ERR",


            "abs", "asc", "ant", "cdbl", "chr$", "cint", "circle", "com", "cos", "csng", "csrlin", "cvi", "date$",
            "environ$", "eof", "exp", "exterr", "fix", "fre", "hex$", "inkey$", "inp", "input$", "instr", "int",
            "left$", "len", "loc", "lof", "log", "lpos", "mid$", "mki$", "mks$", "mkd$", "oct$", "peek", "pen",
            "play", "pmap", "point", "pos", "right", "rnd", "sgn", "sin", "space$", "spc", "sqr", "stick", "strig",
            "string$", "str$", "tab", "tan", "timer", "usr", "val", "varptr", "varptr$", "while", "wend",

            //"clear","cont","chdir","bload","auto","delete","files","kill","list","llist","load",
            //"merge","mkdir","name","new","pcopy","renum","reset","rmdir","run","save","screen","system","tron","troff"

            "beep", "call", "chain", "circle", "bclose", "cls", "color", "common", "com", "data", "def fn",
            "defdbl", "defstr", "defint", "defsng", "def seg", "def usr", "dim", "draw", "end", "environ",
            "erase", "error", "field", "for", "next", "get", "gosub", "return", "goto", "if", "then", "else",
            "input", "input#", "ioctl", "key", "let", "line", "line input", "line input#", "locate", "lock",
            "lprint using", "lprint", "rset", "lset", "mid$", "on timer", "on strig", "on play", "on pen",
            "on key", "on com", "on error goto", "on", "open", "option base", "out", "paint", "palette",
            "palette using", "pen", "play", "poke", "preset", "pset", "print", "print#", "print# using",
            "print using", "put", "randomize", "read", "rem", "restore", "resume", "return", "shell", "sound",
            "strig(", "swap", "time$",

            "erdev", "erdev$", "erl", "err"
        };

        public void BuildAutocompleteMenu()
        {
            List<AutocompleteItem> items = new List<AutocompleteItem>();

            //foreach (var item in Statement)
            //    items.Add(new SnippetAutocompleteItem(item) {ImageIndex = 2});
            foreach (var item in Statement)
                items.Add(new StatementSnippet(item) { ImageIndex = 1 });
            //foreach (var item in Statement)
            //    items.Add(new AutocompleteItem(item) {ImageIndex = 2 });
            foreach (var item in Function)
                items.Add(new FunctionSnippet(item) { ImageIndex = 0 });
            foreach (var item in Command)
                items.Add(new CammandSnippet(item) { ImageIndex = 3 });
            foreach (var item in Variable)
                items.Add(new VariablesSnippet(item) { ImageIndex = 2 });
            foreach (var item in Events)
                items.Add(new EventSnippet(item) { ImageIndex = 4 });
            items.Add(new InsertSpaceSnippet());
            items.Add(new InsertSpaceSnippet(@"^(\w+)([=<>!:]+)(\w+)$"));
            //set as autocomplete source
            popupMenu.Items.SetAutocompleteItems(items);
            
        }

        #region StatementSnippet

        /// <summary>
        /// Auto Complete for Statements
        /// </summary>
        class StatementSnippet : SnippetAutocompleteItem
        {
            public StatementSnippet(string snippet)
                : base(snippet)
            {
            }

            public override CompareResult Compare(string fragmentText)
            {
                var pattern = Regex.Escape(fragmentText);
                if (Regex.IsMatch(Text, "\\b" + pattern, RegexOptions.IgnoreCase))
                    return CompareResult.Visible;
                return CompareResult.Hidden;
            }

            public override string ToolTipTitle => Text;

            public override string ToolTipText
            {
                get
                {
                    #region Statements

                    switch (Text.Substring(0, Text.Length-1))
                    {
                        case ("BEEP"):
                            return
                                "To sound the speaker at 800 Hz(800 cycles per second) for one - quarter of a second.\n\nSyntax:\nBEEP";
                        case ("CALL"):
                            return
                                "To call an assembly (or machine) language subroutine.\n\nSyntax:\nCALL numvar[(variables)]";
                        case ("CHAIN"):
                            return
                                "To transfer control to the specified program and pass (chain) variables to it from the current program.\n\nSyntax:\nCHAIN[MERGE] filename[,[line][,[ALL][,DELETE range]]]";
                        case ("CIRCLE"):
                            return
                                "To draw a circle, ellipse, and angles on the screen during use of the Graphics mode.\n\nSyntax:\nCIRCLE(xcenter, ycenter), radius[,[color][,[start],[end][,aspect]]]";
                        case ("CLOSE"):
                            return
                                "To terminate input/output to a disk file or a device.\n\nSyntax\nCLOSE [[#]filenumber[,[#]filenumber]...]";
                        case ("CLS"):
                            return
                                "To clear the screen.\n\nSyntax:\nCLS [n]\nn is one of the following values:\n0	Clears the screen of all text and graphics\n1\tClears only the graphics viewport\n2\tClears only the text window";
                        case ("COLOR"):
                            return
                                "To select display colors\n\nSyntax:\nCOLOR [foreground][,[background][,border]]\nCOLOR[background][,[palette]]\nCOLOR[foreground][,[background]]";
                        case ("COMMON"):
                            return "To pass variables to a chained program.\n\nSyntax:\nCOMMON variables";
                        case ("COM"):
                            return
                                "To enable or disable trapping of communications activity to the specified communications adapter.\n\nSyntax:\nCOM(n) ON\nCOM(n) OFF\nCOM(n)STOP";
                        case ("DATA"):
                            return
                                "To store the numeric and string constants that are accessed by the program READ statement(s).\n\nSyntax:\nDATA constants";
                        case ("DATE$"):
                            return "To set or retrieve the current date.\n\nSyntax:\nDATE$=variable$";
                        case ("DEF FN"):
                            return
                                "To define and name a function written by the user.\n\nSyntax:\nDEF FNname[arguments] expression";
                        case ("DEFDBL"):
                            return "To declare variable types as double-precision.\n\nSyntax:\nDEFDBL letters";
                        case ("DEFSTR"):
                            return "To declare variable types as string.\n\nSyntax:\nDEFSTR letters";
                        case ("DEFINT"):
                            return "To declare variable types as integer.\n\nSyntax:\nDEFINT letters";
                        case ("DEFSNG"):
                            return "To declare variable types as single-precision.\n\nSyntax:\nDEFSNG letters";
                        case ("DEF SEG"):
                            return
                                "To assign the current segment address to be referenced by a subsequent BLOAD, BSAVE, CALL, PEEK, POKE, or USR.\n\nSyntax:\nDEF SEG [=address]";
                        case ("DEF USR"):
                            return
                                "To specify the starting address of an assembly language subroutine to be called from memory by the USR function.\n\nSyntax:\nDEF USR[n]=integer";
                        case ("DIM"):
                            return
                                "To specify the maximum values for array variable subscripts and allocate storage accordingly.\n\nSyntax:\nDIM variable(subscripts)[,variable(subscripts)]...";
                        case ("DRAW"):
                            return
                                "To draw a figure.\n\nSyntax:\nDRAW string expression\n\nString commands are\nUp\tup\nDn\tdown\nLn\tleft\nRn\tright\nEn\tdiagonally up and right\nFn\tdiagonally down and right\nGn\tdiagonally down and left\nHn\tdiagonally up and left";
                        case ("END"):
                            return
                                "To terminate program execution, close all files, and return to command level.\n\nSyntax:\nEND";
                        case ("ENVIRON"):
                            return
                                "To allow the user to modify parameters in GW-BASIC's environment string table.\n\nSyntax:\nENVIRON string";
                        case "ERASE":
                            return "To eliminate arrays from a program.\n\nSyntax:\nERASE list of array variables";
                        case "ERROR":
                            return
                                "To simulate the occurrence of an error, or to allow the user to define error codes.\n\nSyntax:\nERROR integer expression";
                        case "FIELD":
                            return
                                "To allocate space for variables in a random file buffer.\n\nSyntax:\nFIELD [#] filenum, width AS stringvar [,width AS stringvar]...";
                        case "GET":
                            return
                                "To transfer graphics images from the screen.\nOR\nTo read a record from a random disk file into a random buffer.\n\nSyntax:\nGET (x1,y1)-(x2,y2),array name\nOR\nGET [#]file number[,record number]";
                        case "GOTO":
                            return
                                "To branch unconditionally out of the normal program sequence to a specified line number.\n\nSyntax:\nGOTO line number";
                        case ("INPUT"):
                            return
                                "To prepare the program for input from the terminal during program execution.\n\nSyntax:\nINPUT[;][prompt string,] list of variables";
                        case ("INPUT#"):
                            return
                                "To read data items from a sequential file and assign them to program variables.\n\nSyntax:\nINPUT# file number, variable list";
                        case ("IOCTL"):
                            return
                                "To allow GW-BASIC to send a \"control data\" string to a character device driver anytime after the driver has been opened.\n\nSyntax:\nIOCTL[#]file number,string";
                        case ("KEY"):
                            return
                                "To allow rapid entry of as many as 15 characters into a program with one keystroke by redefining GW-BASIC special function keys.\n\nSyntax:\nKEY key number,string expression\nKEY n, CHR$(hex code)+CHR$(scan code)\nKEY ON\nKEY OFF\nKEY LIST ";
                        case ("LET"):
                            return
                                "To assign the value of an expression to a variable.\n\nSyntax:\n[LET] variable=expression";
                        case ("LINE"):
                            return
                                "To draw lines and boxes on the screen.\n\nSyntax:\nLINE [(x1,y1)]-(x2,y2) [,[attribute][,B[F]][,style]]";
                        case ("LINE INPUT"):
                            return
                                "To input an entire line (up to 255 characters) from the keyboard into a string variable, ignoring delimiters.\n\nSyntax:\nLINE INPUT [;][prompt string;]string variable";
                        case ("LINE INPUT#"):
                            return
                                "To read an entire line (up to 255 characters), without delimiters, from a sequential disk file to a string variable.\n\nSyntax:\nLINE INPUT# file number, string variable";
                        case ("LOCATE"):
                            return
                                "To move the cursor to the specified position on the active screen.\n\nSyntax:\nLOCATE [row][,[col][,[cursor][,[start] [,stop]]]]";
                        case ("LOCK"):
                            return
                                "To restrict the access to all or part of a file that has been opened by another process.\n\nSyntax:\nLOCK [#]n [,[record number] [TO record number]]";
                        case ("LPRINT USING"):
                            return
                                "To print data at the line printer.\n\nSyntax:\nLPRINT USING string exp; list of expressions[;]";
                        case ("LPRINT"):
                            return "To print data at the line printer.\n\nSyntax:\nLPRINT [list of expressions][;]";
                        case ("RSET"):
                            return
                                "To move data from memory to a random-file buffer and right-justify it in preparation for a PUT statement.\n\nSyntax:\nRSET string variable=string expression";
                        case ("LSET"):
                            return
                                "To move data from memory to a random-file buffer and left-justify it in preparation for a PUT statement.\n\nSyntax:\nLSET string variable=string expression";
                        case ("MID$"):
                            return
                                "To replace a portion of one string with another string.\n\nSyntax:\nMID$(stringexp1,n[,m])=stringexp2";
                        
                        case ("OPEN"):
                            return
                                "To establish input/output (I/O) to a file or device.\n\nSyntax:\nOPEN mode,[#]file number,filename[,reclen]\nOPEN filename[FOR mode][ACCESS access][lock]AS [#]file number [LEN=reclen]";
                        case ("OPEN \"COM("):
                            return
                                "To allocate a buffer to support RS-232 asynchronous communications with other computers and peripheral devices in the same manner as OPEN for disk files.\n\nSyntax:\nOPEN \"COM[n]:[speed][, parity][, data][, stop][, RS][, CS[n]][, DS[n]][, CD[n]][, LF][, PE]\" AS [#]filenum [LEN=number]";
                        case ("OPTION BASE"):
                            return "To declare the minimum value for array subscripts.\n\nSyntax:\nOPTION BASE n";
                        case ("OUT"):
                            return "To send a byte to a machine output port.\n\nSyntax:\nOUT h,j";
                        case ("PAINT"):
                            return
                                "To fill in a graphics figure with the selected attribute.\n\nSyntax:\nPAINT (x start,y start)[,paint attribute[,border attribute][,bckgrnd attribute]]";
                        case ("PALETTE"):
                            return
                                "Changes one or more of the colors in the palette\n\nSyntax:\nPALETTE [attribute,color]PALETTE USING integer-array-name (arrayindex)";
                        case ("PALETTE USING"):
                            return
                                "Changes one or more of the colors in the palette\n\nSyntax:\nPALETTE USING integer-array-name (arrayindex)";
                        case ("PEN"):
                            return "To read the light pen.\n\nSyntax:\nPEN ON\nPEN OFF\nPEN STOP";
                        case ("PLAY"):
                            return
                                "To play music by embedding a music macro language into the string data type.\n\nSyntax:\nPLAY string expression";
                        case ("POKE"):
                            return "To write (poke) a byte of data into a memory location.\n\nSyntax:\nPOKE a,b";
                        case ("PRESET"):
                            return
                                "To display a point at a specified place on the screen during use of the graphics mode.\n\nSyntax:\nPRESET(x,y)[,color]";
                        case ("PSET"):
                            return
                                "To display a point at a specified place on the screen during use of the graphics mode.\n\nSyntax:\nPSET(x,y)[,color]";
                        case ("PRINT"):
                            return
                                "To output a display to the screen.\n\nSyntax:\nPRINT [list of expressions][;]\n? [list of expressions][;]";
                        case ("PRINT#"):
                            return
                                "To write data to a sequential disk file.\n\nSyntax:\nPRINT#file number,[USINGstring expressions;]list of expressions";
                        case ("PRINT USING"):
                            return
                                "To print strings or numbers using a specified format.\n\nSyntax:\nPRINT USING string expressions;list of expressions[;]";
                        case ("PUT"):
                            return
                                "To write a record from a random buffer to a random disk file.\n\tOR\nTo transfer graphics images to the screen.\n\nSyntax:\nPUT[#]file number[,record number]\n\tOR\nPUT(x,y),array,[,action verb]";
                        case ("RANDOMIZE"):
                            return
                                "To reseed the random number generator.\n\nSyntax:\nRANDOMIZE [expression]\nRANDOMIZE Timer";
                        case ("READ"):
                            return
                                "To read values from a DATA statement and assign them to variables.\n\nSyntax:\nREAD list of variables";
                        case ("REM"):
                            return
                                "To allow explanatory remarks to be inserted in a program.\n\nSyntax:\nREM[comment]\n'[comment]";
                        case ("RESTORE"):
                            return
                                "To allow DATA statements to be reread from a specified line.\n\nSyntax:\nRESTORE[line number]";
                        case ("RESUME"):
                            return
                                "To continue program execution after an error-recovery procedure has been  performed.\n\nSyntax:\nRESUME\nRESUME 0\nRESUME NEXT\nRESUME line number";
                        case ("RETURN"):
                            return "To return from a subroutine.\n\nSyntax:\nRETURN [line number]";
                        case ("SHELL"):
                            return "To load and execute another program or batch file.\n\nSyntax:\nSHELL [string]";
                        case ("SOUND"):
                            return "To generate sound through the speaker.\n\nSyntax:\nSOUND freq,duration";
                        case ("STRIG"):
                            return "To return the status of the joystick triggers.\n\nSyntax:\nSTRIG ON\nSTRIG OFF";
                        case "SWAP":
                            return "To exchange the values of two variables.\n\nSyntax:\nSWAP variable1,variable2";
                        case ("TIME$"):
                            return "To set or retrieve the current time.\n\nSyntax:\nTIME$ = string exp";
                        case "OPEN \"COM(n)":
                            return
                                "To allocate a buffer to support RS-232 asynchronous communications with other computers and peripheral devices in the same manner as OPEN for disk files.\n\nSyntax:\n" +
                                "OPEN \"COM[n]:[speed][, parity][, data][, stop][, RS][, CS[n]][, DS[n]][, CD[n]][, LF][, PE]\" AS [#]filenum [LEN=number]";
                        case "UNLOCK":
                            return
                                "To release locks that have been applied to an opened file. This is used in a multi-device environment, often referred to as a network or network environment.\n\nSyntax:\nUNLOCK [#]n [,[record number] [TO record number]]";
                        case "VIEW":
                            return
                                "To define a physical viewport limit from x1,y1 (upper-left x,y coordinates) to x2,y2 (lower-right x,y coordinates).\n\nSyntax:\nVIEW [[SCREEN][(x1,y1)-(x2,y2) [,[fill][,[border]]]]";
                        case "VIEW PRINT":
                            return
                                "To set the boundaries of the screen text window.\n\nSyntax:\nVIEW PRINT [topline TO bottomline]";
                        case "WAIT":
                            return
                                "To suspend program execution while monitoring the status of a machine input port.\n\nSyntax:\nWAIT port number, n[,j]";
                        case "WIDTH":
                            return
                                "To set the printed line width in number of characters for the screen and line printer.\n\nSyntax:\nWIDTH size\nWIDTH file number, size\nWIDTH \"dev\", size";
                        case "WINDOW":
                            return
                                "To draw lines, graphics, and objects in space not bounded by the physical  limits of the screen.\n\nSyntax:\nWINDOW[[SCREEN](x1,y1)-(x2,y2)]";
                        case "WRITE":
                            return "To output data to the screen.\n\nSyntax:\nWRITE[list of expressions]";
                        case "WRITE#":
                            return "To write data to a sequential file.\n\nSyntax:\nWRITE #filenum, list of expressions";
                        default:
                            return "TooltTip Not Found";
                    }

                    #endregion Statements
                }
            }

        }

        #endregion StatementSnippet

        #region FunctionSnippet

        /// <summary>
        /// Auto Complete for Function
        /// </summary>
        class FunctionSnippet : SnippetAutocompleteItem
        {
            public FunctionSnippet(string snippet)
                : base(snippet)
            {
            }

            public override CompareResult Compare(string fragmentText)
            {
                var pattern = Regex.Escape(fragmentText);
                if (Regex.IsMatch(Text, "\\b" + pattern, RegexOptions.IgnoreCase))
                    return CompareResult.Visible;
                return CompareResult.Hidden;
            }

            public override string ToolTipTitle => Text;

            public override string ToolTipText
            {
                get
                {
                    #region FuntionsAutoComplete

                    switch (Text.Substring(0, Text.Length - 1))
                    {
                        case "ABS":
                            return "To return the absolute value of the expression n.\n\nSyntax:\nABS(n)";
                        case "ASC":
                            return
                                "To return a numeric value that is the ASCII code for the first character of the string x$.\n\nSyntax:\nASC(x$)";
                        case "ANT":
                            return "To return the arctangent of x, when x is expressed in radians.\n\nSyntax:\nATN(x)";
                        case "CDBL":
                            return "To convert x to a double-precision number.\n\nSyntax:\nCDBL(x)";
                        case "CHR$":
                            return "To convert an ASCII code to its equivalent character.\n\nSyntax:\nCHR$(n)";
                        case "CINT":
                            return
                                "To round numbers with fractional portions to the next whole number or integer.\n\nSyntax:\nCINT(x)";
                        case "COS":
                            return "To return the cosine of the range of x.\n\nSyntax:\nCOS(x)";
                        case "CSNG":
                            return "To convert x to a single-precision number.\n\nSyntax:\nCSNG(x)";
                        case "CVI":
                            return "To convert string values to numeric values.\n\nSyntax:\nCVI(2-byte string)";
                        case "CVS":
                            return "To convert string values to numeric values.\n\nSyntax:\nCVS(4-byte string)";
                        case "CVD":
                            return "To convert string values to numeric values.\n\nSyntax:\nCVD(8-byte string)";
                        case "ENVIRON$":
                            return
                                "To allow the user to retrieve the specified environment string from the environment table.\n\nSyntax:\nv$=ENVIRON$(parmid)\nv$=ENVIRON$(nthparm)";
                        case "EOF":
                            return
                                "To return -1 (true) when the end of a sequential or a communications file has been reached, or to return 0 if end of file (EOF) has not been found.\n\nSyntax:\nEOF(file number)";
                        case "EXP":
                            return "To return e (the base of natural logarithms) to the power of x.\n\nSyntax:\nEXP(x)";
                        case "EXTERR":
                            return "To return extended error information.\n\nSyntax:\nEXTERR(n)";
                        case "FIX":
                            return "To truncate x to a whole number.\n\nSyntax:\nFIX(x)";
                        case "FRE":
                            return
                                "To return the number of available bytes in allocated string memory.\n\nSyntax:\nFRE(x$)\nFRE(x)";
                        case "HEX$":
                            return
                                "To return a string which represents the hexadecimal value of the numeric argument.\n\nSyntax:\nHEX$(x)";
                        case "INP":
                            return "To return the byte read from machine port n.\n\nSyntax:\nINP(n)";
                        case "INPUT$":
                            return "INP(n)\n\nSyntax:\nINPUT$(x[,[#]file number)]";
                        case "INSTR":
                            return
                                "To search for the first occurrence of string y$ in x$, and return the position at which the string is found.\n\nSyntax:\nINSTR([n,]x$,y$)";
                        case "INT":
                            return "To truncate an expression to a whole number.\n\nSyntax:\nINT(x)";
                        case "LEFT$":
                            return
                                "To return a string that comprises the left-most n characters of x$.\n\nSyntax:\nLEFT$(x$,n)";
                        case "LEN":
                            return "To return the number of characters in x$.\n\nSyntax:\nLEN(x$)";
                        case "LOC":
                            return "To return the current position in the file.\n\nSyntax:\nLOC(file number)";
                        case "LOF":
                            return
                                "To return the length (number of bytes) allocated to the file.\n\nSyntax:\nLOF(file number)";
                        case "LOG":
                            return "To return the natural logarithm of x.\n\nSyntax:\nLOG(x)";
                        case "LPOS":
                            return
                                "To return the current position of the line printer print head within the line printer buffer.\n\nSyntax:\nLPOS(x)";
                        case "MID$":
                            return
                                "To return a string of m characters from x$ beginning with the nth character.\n\nSyntax:\nMID$(x$,n[,m])";
                        case "MKI$":
                            return "To convert numeric values to string values.\n\nSyntax:\nMKI$(integer expression)";
                        case "MKS$":
                            return
                                "To convert numeric values to string values.\n\nSyntax:\nMKS$(single-precision expression)";
                        case "MKD$":
                            return
                                "To convert numeric values to string values.\n\nSyntax:\nMKD$(double-precision expression)";
                        case "OCT$":
                            return "To convert a decimal value to an octal value.\n\nSyntax:\nOCT$(x)";
                        case "PEEK":
                            return "To read from a specified memory location.\n\nSyntax:\nPEEK(a)";
                        case "PEN":
                            return "To read the light pen.\n\nSyntax:" +
                                   "\nPEN(n)";
                        case "PLAY":
                            return
                                "To return the number of notes currently in the background music queue.\n\nSyntax:\nPLAY(n)";
                        case "PMAP":
                            return
                                "To map expressions to logical or physical coordinates.\n\nSyntax:\nPMAP (exp,function)";
                        case "POINT":
                            return
                                "To read the color or attribute value of a pixel from the screen.\n\nSyntax:\nPOINT(x,y)\nPOINT(function)";
                        case "POS":
                            return "To return the current cursor position.\n\nSyntax:\nPOS(c)";
                        case "RIGHT":
                            return "To return the rightmost n characters of string x$.\n\nSyntax:\nRIGHT$(x$,n)";
                        case "RND":
                            return "To return a random number between 0 and 1.\n\nSyntax:\n\nRND [(x)]";
                        case "SGN":
                            return "To return the sign of x.\n\nSyntax:\nSGN(x)";
                        case "SIN":
                            return "To calculate the trigonometric sine of x, in radians.\n\nSyntax:\nSIN(x)";
                        case "SPACE$":
                            return "To return a string of x spaces.\n\nSyntax:\nSPACE$(x)";
                        case "SPC":
                            return
                                "To skip a specified number of spaces in a PRINT or an LPRINT statement.\n\nSyntax:\nSPC(n)";
                        case "SQR":
                            return "Returns the square root of x.\n\nSyntax:\nSQR(x)";
                        case "STICK":
                            return "To return the x and y coordinates of two joysticks.\n\nSyntax:\nSTICK(n)";
                        case "STRIG":
                            return "To return the status of the joystick triggers.\n\nSyntax:\nSTRIG ON\nSTRIG OFF";
                        case "STRING$":
                            return
                                "To return:\n\ta string of length n whose characters all have ASCII code j\n\tthe first character of x$\n\nSyntax:\nSTRING$(n,j)\nSTRING$(n,x$)";
                        case "STR$":
                            return "To return a string representation of the value of x.\n\nSyntax:\nSTR$(x)";
                        case "TAB":
                            return "Spaces to position n on the screen.\n\nSyntax:\nTAB(n)";
                        case "TAN":
                            return "To calculate the trigonometric tangent of x, in radians.\n\nSyntax:\nTAN(x)";
                        case "TIMER":
                            return
                                "To return single-precision floating-point numbers representing the elapsed number of seconds since midnight or system reset.\n\nSyntax:\nTIMER";
                        case "USR":
                            return "To call an assembly language subroutine.\n\nSyntax:\nUSR[n](argument)";
                        case "VAL":
                            return "Returns the numerical value of string x$.\n\nSyntax:" +
                                   "\nVAL(x$)";
                        case "VARPTR":
                            return
                                "To return the address in memory of the variable or file control block (FCB).\n\nSyntax:\nVARPTR(variable name)\nVARPTR(#file number)";
                        case "VARPTR$":
                            return
                                "To return a character form of the offset of a variable in memory.\n\nSyntax:\nVARPTR$(variable)";
                        default:
                            return "Tooltip Not Found";
                    }

                    #endregion FunctionsAutoComplete
                }
            }
        }

        #endregion FunctionSnippet

        #region CommandSnippet

        /// <summary>
        /// Auto Complete for Commands
        /// </summary>
        class CammandSnippet : SnippetAutocompleteItem
        {
            public CammandSnippet(string snippet)
                : base(snippet)
            {
            }

            public override CompareResult Compare(string fragmentText)
            {
                var pattern = Regex.Escape(fragmentText);
                if (Regex.IsMatch(Text, "\\b" + pattern, RegexOptions.IgnoreCase))
                    return CompareResult.Visible;
                return CompareResult.Hidden;

            }

            public override string ToolTipTitle => Text;

            public override string ToolTipText
            {
                get
                {
                    #region CommandAutoComplete

                    switch (Text.Substring(0, Text.Length - 1))
                    {
                        case "CLEAR":
                            return
                                "To set all numeric variables to zero, all string variables to null, and to close all open files.\n\nSyntax:\nCLEAR[,[expression1][,expression2]]";
                        case "CONT":
                            return "To continue program execution after a break.\n\nSyntax:\nCONT";
                        case "CHDIR":
                            return "To change from one working directory to another.\n\nSyntax:\nCHDIR pathname";
                        case "BLOAD":
                            return "To load an image file anywhere in user memory.\n\nSyntax:\nBLOAD filename[,offset]";
                        case "AUTO":
                            return
                                "To generate and increment line numbers automatically each time you press the RETURN key.\n\nSyntax:\nAUTO [line number][,[increment]]\nAUTO .[,[increment]]";
                        case "DELETE":
                            return
                                "To delete program lines or line ranges.\n\nSyntax:\nDELETE [line number1][-line number2]\nDELETE line number1-";
                        case "FILES":
                            return
                                "To print the names of the files residing on the specified drive.\n\nSyntax:\nFILES [pathname]";
                        case "KILL":
                            return "To delete a file from a disk.\n\nSyntax:\nKILL filename";
                        case "LIST":
                            return
                                "To list all or part of a program to the screen, line printer, or file.\n\nSyntax:\nLIST [line number][-line number][,filename]\nLIST [line number-][,filename]";
                        case "LLIST":
                            return
                                "To list all or part of the program currently in memory to the line printer.\n\nSyntax:\nLLIST [line number][-line number]\nLLIST [line number-]";
                        case "LOAD":
                            return "To load a file from diskette into memory.\n\nSyntax:\nLOAD filename[,r]";
                        case "MERGE":
                            return
                                "To merge the lines from an ASCII program file into the program already in memory.\n\nSyntax:\nMERGE filename";
                        case "MKDIR":
                            return "To create a subdirectory.\n\nSyntax:\nMKDIR pathname";
                        case "NAME":
                            return "To change the name of a disk file.\n\nSyntax:\nNAME old filename AS new filename";
                        case "NEW":
                            return "To delete the program currently in memory and clear all variables.\n\nSyntax:\nNEW";
                        case "PCOPY":
                            return
                                "To copy one screen page to another in all screen modes.\n\nSyntax:\nPCOPY sourcepage, destinationpage";
                        case "RENUM":
                            return "To renumber program lines.\n\nSyntax:\nRENUM[new number],[old number][,incrementR]]";
                        case "RESET":
                            return
                                "To close all disk files and write the directory information to a diskette before it is removed from a disk drive.\n\nSyntax:\nRESET";
                        case "RMDIR":
                            return "To delete a subdirectory.\n\nSyntax:\nRMDIR pathname";
                        case "RUN":
                            return
                                "To execute the program currently in memory, or to load a file from the diskette into memory and run it.\n\nSyntax:\nRUN [line number][,r]\nRUN filename[,r]";
                        case "SAVE":
                            return
                                "To save a program file on diskette.\n\nSyntax:\nSAVE filename,[,a]\nSAVE filename,[,p]";
                        case "SYSTEM":
                            return "To return to MS-DOS.\n\nSyntax:\nSYSTEM";
                        case "TRON":
                            return "To trace the execution of program statements.\n\nSyntax:\nTRON";
                        case "TROFF":
                            return "To trace the execution of program statements.\n\nSyntax:\nTROFF";
                        default:
                            return "ToolTip Not Found";
                    }

                    #endregion CommandAutoComplete
                }
            }
        }

        #endregion CommandsSnippet

        #region VariablesSnippet

        /// <summary>
        /// Auto Complete for Variables
        /// </summary>
        class VariablesSnippet : SnippetAutocompleteItem
        {
            public VariablesSnippet(string snippet)
                : base(snippet)
            {
            }

            public override CompareResult Compare(string fragmentText)
            {
                var pattern = Regex.Escape(fragmentText);
                if (Regex.IsMatch(Text, "\\b" + pattern, RegexOptions.IgnoreCase))
                    return CompareResult.Visible;
                return CompareResult.Hidden;

            }

            public override string ToolTipTitle => Text;

            public override string ToolTipText
            {
                get
                {
                    switch (Text.Substring(0, Text.Length - 1))
                    {
                        case "CSRLIN":
                            return "To return the current line (row) position of the cursor.\n\nSyntax:\nCSRLIN";
                        case "DATE$":
                            return "To set or retrieve the current date.\n\nSyntax:\nDATE$";
                        case "ERDEV":
                            return "To return the actual value of a device error.\n\nSyntax:\nERDEV";
                        case "ERDEV$":
                            return "To return the name of the device causing the error.\n\nSyntax:\nERDEV$";
                        case "ERL":
                            return "To return the error code.\n\nSyntax:\nERR";
                        case "ERR":
                            return "To return the line number associated with an error.\n\nSyntax:\nERR";
                        case "INKEY$":
                            return "To return one character read from the keyboard.\n\nSyntax:\nINKEY$";
                        case "TIME$":
                            return "To retrieve the current time.\n\nSyntax:\nTIME$";
                        default:
                            return "Tootlip Not Found";
                    }
                }
            }
        }

        #endregion

        #region InsertSpaceSnippet
        /// <summary>
        /// Divides numbers and words: "123AND456" -> "123 AND 456"
        /// Or "i=2" -> "i = 2"
        /// </summary>
        class InsertSpaceSnippet : AutocompleteItem
        {
            string pattern;

            public InsertSpaceSnippet(string pattern) : base("")
            {
                this.pattern = pattern;
            }

            public InsertSpaceSnippet()
                : this(@"^(\d+)([a-zA-Z_]+)(\d*)$")
            {
            }

            public override CompareResult Compare(string fragmentText)
            {
                if (Regex.IsMatch(fragmentText, pattern))
                {
                    Text = InsertSpaces(fragmentText);
                    if (Text != fragmentText)
                        return CompareResult.Visible;
                }
                return CompareResult.Hidden;
            }

            public string InsertSpaces(string fragment)
            {
                var m = Regex.Match(fragment, pattern);
                if (m == null)
                    return fragment;
                if (m.Groups[1].Value == "" && m.Groups[3].Value == "")
                    return fragment;
                return (m.Groups[1].Value + " " + m.Groups[2].Value + " " + m.Groups[3].Value).Trim();
            }

            public override string ToolTipTitle
            {
                get
                {
                    return "Try to enter space between alpa and numerics\n" +
                           "this can increase the readabillity.  :)";
                }
            }
        }
        #endregion InsertSpaceSnippet

        #region EventSnippet

        /// <summary>
        /// Auto Complete for Statements
        /// </summary>
        class EventSnippet : SnippetAutocompleteItem
        {
            public EventSnippet(string snippet)
                : base(snippet)
            {
            }

            public override CompareResult Compare(string fragmentText)
            {
                var pattern = Regex.Escape(fragmentText);
                if (Regex.IsMatch(Text, "\\b" + pattern, RegexOptions.IgnoreCase))
                    return CompareResult.Visible;
                return CompareResult.Hidden;
            }

            public override string ToolTipTitle => Text;

            public override string ToolTipText
            {
                get
                {
                    switch (Text.Substring(0, Text.Length - 1))
                    {
                        case ("ON TIMER"):
                            return
                                "To create an event trap line number for a specified Time.\n\nSyntax:\nON TIMER$(n) event specifier GOSUB line number";
                        case ("ON STRIG"):
                            return
                                "To create an event trap line number for an interrupted routine that checks the trigger status.\n\nSyntax:\nON STRIG(n) event specifier GOSUB line number";
                        case ("ON PLAY"):
                            return
                                "To create an event trap which is issued only when playing background music.\n\nSyntax:\nON PLAY(n) event specifier GOSUB line number";
                        case ("ON PEN"):
                            return
                                "To create an event trap which is issued only when using the light pen.\n\nSyntax:\nON PEN(n) event specifier GOSUB line number";
                        case ("ON KEY"):
                            return
                                "To create an event trap which is issued only when specified key is pressed.\n\nSyntax:\nON KEY(n) event specifier GOSUB line number";
                        case ("ON COM"):
                            return
                                "Typically, the COM trap routine will read an entire message from the COM port before returning.\n\nSyntax:\nON COM(n) event specifier GOSUB line number";
                        case ("ON ERROR GOTO"):
                            return
                                "To enable error trapping and specify the first line of the error-handling subroutine.\n\nSyntax:\nON ERROR GOTO line number";
                        default:
                            return "ToolTip Not Found";
                    }
                }
            }
        }
        #endregion 
    }
}


