using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Irony.Parsing;
using Irony.Ast;

namespace pruebaBootstrap
{
    public class GramaticaPass:Grammar
    {
        public GramaticaPass() {
            RegexBasedTerminal arroba = new RegexBasedTerminal("arroba", @"@");
            RegexBasedTerminal numeral = new RegexBasedTerminal("numeral", "#");
            RegexBasedTerminal punto = new RegexBasedTerminal("punto", "[.]");
            RegexBasedTerminal num0 = new RegexBasedTerminal("num0", "0");
            RegexBasedTerminal num1 = new RegexBasedTerminal("num1", "1");
            RegexBasedTerminal num2 = new RegexBasedTerminal("num2", "2");
            RegexBasedTerminal num3 = new RegexBasedTerminal("num3", "3");
            RegexBasedTerminal num4 = new RegexBasedTerminal("num4", "4");
            RegexBasedTerminal num5 = new RegexBasedTerminal("num5", "5");
            RegexBasedTerminal num6 = new RegexBasedTerminal("num6", "6");
            RegexBasedTerminal num7 = new RegexBasedTerminal("num7", "7");
            RegexBasedTerminal num8 = new RegexBasedTerminal("num8", "8");
            RegexBasedTerminal num9 = new RegexBasedTerminal("num9", "9");
            RegexBasedTerminal mayusa = new RegexBasedTerminal("mayusa", "A");
            RegexBasedTerminal mayusb = new RegexBasedTerminal("mayusb", "B");
            RegexBasedTerminal mayusc = new RegexBasedTerminal("mayusc", "C");
            RegexBasedTerminal mayusd = new RegexBasedTerminal("mayusd", "D");
            RegexBasedTerminal mayuse = new RegexBasedTerminal("mayuse", "E");
            RegexBasedTerminal mayusf = new RegexBasedTerminal("mayusf", "F");
            RegexBasedTerminal mayusg = new RegexBasedTerminal("mayusg", "G");
            RegexBasedTerminal mayush = new RegexBasedTerminal("mayush", "H");
            RegexBasedTerminal mayusi = new RegexBasedTerminal("mayusi", "I");
            RegexBasedTerminal mayusj = new RegexBasedTerminal("mayusj", "J");
            RegexBasedTerminal mayusk = new RegexBasedTerminal("mayusk", "K");
            RegexBasedTerminal mayusl = new RegexBasedTerminal("mayusl", "L");
            RegexBasedTerminal mayusm = new RegexBasedTerminal("mayusm", "M");
            RegexBasedTerminal mayusn = new RegexBasedTerminal("mayusn", "N");
            RegexBasedTerminal mayuso = new RegexBasedTerminal("mayuso", "O");
            RegexBasedTerminal mayusp = new RegexBasedTerminal("mayusp", "P");
            RegexBasedTerminal mayusq = new RegexBasedTerminal("mayusq", "Q");
            RegexBasedTerminal mayusr = new RegexBasedTerminal("mayusr", "R");
            RegexBasedTerminal mayuss = new RegexBasedTerminal("mayuss", "S");
            RegexBasedTerminal mayust = new RegexBasedTerminal("mayust", "T");
            RegexBasedTerminal mayusu = new RegexBasedTerminal("mayusu", "U");
            RegexBasedTerminal mayusv = new RegexBasedTerminal("mayusv", "V");
            RegexBasedTerminal mayusw = new RegexBasedTerminal("mayusw", "W");
            RegexBasedTerminal mayusx = new RegexBasedTerminal("mayusx", "X");
            RegexBasedTerminal mayusy = new RegexBasedTerminal("mayusy", "Y");
            RegexBasedTerminal mayusz = new RegexBasedTerminal("mayusz", "Z");
            RegexBasedTerminal mayusñ = new RegexBasedTerminal("mayusñ", "Ñ");

            RegexBasedTerminal minusa = new RegexBasedTerminal("minusa", "a");
            RegexBasedTerminal minusb = new RegexBasedTerminal("minusb", "b");
            RegexBasedTerminal minusc = new RegexBasedTerminal("minusc", "c");
            RegexBasedTerminal minusd = new RegexBasedTerminal("minusd", "d");
            RegexBasedTerminal minuse = new RegexBasedTerminal("minuse", "e");
            RegexBasedTerminal minusf = new RegexBasedTerminal("minusf", "f");
            RegexBasedTerminal minusg = new RegexBasedTerminal("minusg", "g");
            RegexBasedTerminal minush = new RegexBasedTerminal("minush", "h");
            RegexBasedTerminal minusi = new RegexBasedTerminal("minusi", "i");
            RegexBasedTerminal minusj = new RegexBasedTerminal("minusj", "j");
            RegexBasedTerminal minusk = new RegexBasedTerminal("minusk", "k");
            RegexBasedTerminal minusl = new RegexBasedTerminal("minusl", "l");
            RegexBasedTerminal minusm = new RegexBasedTerminal("minusm", "m");
            RegexBasedTerminal minusn = new RegexBasedTerminal("minusn", "m");
            RegexBasedTerminal minuso = new RegexBasedTerminal("minuso", "o");
            RegexBasedTerminal minusp = new RegexBasedTerminal("minusp", "p");
            RegexBasedTerminal minusq = new RegexBasedTerminal("minusq", "q");
            RegexBasedTerminal minusr = new RegexBasedTerminal("minusr", "r");
            RegexBasedTerminal minuss = new RegexBasedTerminal("minuss", "s");
            RegexBasedTerminal minust = new RegexBasedTerminal("minust", "t");
            RegexBasedTerminal minusu = new RegexBasedTerminal("minusu", "u");
            RegexBasedTerminal minusv = new RegexBasedTerminal("minusv", "v");
            RegexBasedTerminal minusw = new RegexBasedTerminal("minusw", "w");
            RegexBasedTerminal minusx = new RegexBasedTerminal("minusx", "x");
            RegexBasedTerminal minusy = new RegexBasedTerminal("minusy", "y");
            RegexBasedTerminal minusz = new RegexBasedTerminal("minusz", "z");
            RegexBasedTerminal minusñ = new RegexBasedTerminal("minusñ", "ñ");

            NonTerminal s0 = new NonTerminal("s0"),
                        password = new NonTerminal("password");

            s0.Rule = password;

            password.Rule = password + arroba
                    | password + numeral
                    | password + punto
                    | password + num0
                    | password + num1
                    | password + num2
                    | password + num3
                    | password + num4
                    | password + num5
                    | password + num6
                    | password + num7
                    | password + num8
                    | password + num9
                    | password + mayusa
                    | password + mayusb
                    | password + mayusc
                    | password + mayusd
                    | password + mayuse
                    | password + mayusf
                    | password + mayusg
                    | password + mayush
                    | password + mayusi
                    | password + mayusj
                    | password + mayusk
                    | password + mayusl
                    | password + mayusm
                    | password + mayusn
                    | password + mayuso
                    | password + mayusp
                    | password + mayusq
                    | password + mayusr
                    | password + mayuss
                    | password + mayust
                    | password + mayusu
                    | password + mayusv
                    | password + mayusw
                    | password + mayusx
                    | password + mayusy
                    | password + mayusz
                    | password + mayusñ
                    | password + minusa
                    | password + minusb
                    | password + minusc
                    | password + minusd
                    | password + minuse
                    | password + minusf
                    | password + minusg
                    | password + minush
                    | password + minusi
                    | password + minusj
                    | password + minusk
                    | password + minusl
                    | password + minusm
                    | password + minusn
                    | password + minuso
                    | password + minusp
                    | password + minusq
                    | password + minusr
                    | password + minuss
                    | password + minust
                    | password + minusu
                    | password + minusv
                    | password + minusw
                    | password + minusx
                    | password + minusy
                    | password + minusz
                    | password + minusñ
                    | arroba
                    | numeral
                    | punto
                    | num0
                    | num1
                    | num2
                    | num3
                    | num4
                    | num5
                    | num6
                    | num7
                    | num8
                    | num9
                    | mayusa
                    | mayusb
                    | mayusc
                    | mayusd
                    | mayuse
                    | mayusf
                    | mayusg
                    | mayush
                    | mayusi
                    | mayusj
                    | mayusk
                    | mayusl
                    | mayusm
                    | mayusn
                    | mayuso
                    | mayusp
                    | mayusq
                    | mayusr
                    | mayuss
                    | mayust
                    | mayusu
                    | mayusv
                    | mayusw
                    | mayusx
                    | mayusy
                    | mayusz
                    | mayusñ
                    | minusa
                    | minusb
                    | minusc
                    | minusd
                    | minuse
                    | minusf
                    | minusg
                    | minush
                    | minusi
                    | minusj
                    | minusk
                    | minusl
                    | minusm
                    | minusn
                    | minuso
                    | minusp
                    | minusq
                    | minusr
                    | minuss
                    | minust
                    | minusu
                    | minusv
                    | minusw
                    | minusx
                    | minusy
                    | minusz
                    | minusñ;

            this.Root = s0;
            
        }
    }
}