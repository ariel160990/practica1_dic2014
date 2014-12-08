using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Irony.Parsing;
using Irony.Ast;

namespace pruebaBootstrap
{
    public class GramaticaPassword:Grammar
    {
        public GramaticaPassword() {
            RegexBasedTerminal codpersonal = new RegexBasedTerminal("codpersonal", "[0-9][0-9][0-9][0-9][0-9][0-9]");
            RegexBasedTerminal arroba = new RegexBasedTerminal("arroba","[+]-¿=");
            RegexBasedTerminal numeral = new RegexBasedTerminal("numeral", "[*]%&");
            RegexBasedTerminal punto = new RegexBasedTerminal("punto", @"/""\)[?]");
            RegexBasedTerminal num0 = new RegexBasedTerminal("num0", "{");
            RegexBasedTerminal num1 = new RegexBasedTerminal("num1", "¡");
            RegexBasedTerminal num2 = new RegexBasedTerminal("num2", ":");
            RegexBasedTerminal num3 = new RegexBasedTerminal("num3", "_");
            RegexBasedTerminal num4 = new RegexBasedTerminal("num4", "^");
            RegexBasedTerminal num5 = new RegexBasedTerminal("num5", @"\]");
            RegexBasedTerminal num6 = new RegexBasedTerminal("num6", @"\[");
            RegexBasedTerminal num7 = new RegexBasedTerminal("num7", "}");
            RegexBasedTerminal num8 = new RegexBasedTerminal("num8", ",");
            RegexBasedTerminal num9 = new RegexBasedTerminal("num9", ";");
            RegexBasedTerminal mayusa = new RegexBasedTerminal("mayusa","B");
            RegexBasedTerminal mayusb = new RegexBasedTerminal("mayusb", "C");
            RegexBasedTerminal mayusc = new RegexBasedTerminal("mayusc", "D");
            RegexBasedTerminal mayusd = new RegexBasedTerminal("mayusd", "E");
            RegexBasedTerminal mayuse = new RegexBasedTerminal("mayuse", "F");
            RegexBasedTerminal mayusf = new RegexBasedTerminal("mayusf", "G");
            RegexBasedTerminal mayusg = new RegexBasedTerminal("mayusg", "H");
            RegexBasedTerminal mayush = new RegexBasedTerminal("mayush", "I");
            RegexBasedTerminal mayusi = new RegexBasedTerminal("mayusi", "J");
            RegexBasedTerminal mayusj = new RegexBasedTerminal("mayusj", "K");
            RegexBasedTerminal mayusk = new RegexBasedTerminal("mayusk", "L");
            RegexBasedTerminal mayusl = new RegexBasedTerminal("mayusl", "M");
            RegexBasedTerminal mayusm = new RegexBasedTerminal("mayusm", "N");
            RegexBasedTerminal mayusn = new RegexBasedTerminal("mayusn", "O");
            RegexBasedTerminal mayuso = new RegexBasedTerminal("mayuso", "P");
            RegexBasedTerminal mayusp = new RegexBasedTerminal("mayusp", "Q");
            RegexBasedTerminal mayusq = new RegexBasedTerminal("mayusq", "R");
            RegexBasedTerminal mayusr = new RegexBasedTerminal("mayusr", "S");
            RegexBasedTerminal mayuss = new RegexBasedTerminal("mayuss", "T");
            RegexBasedTerminal mayust = new RegexBasedTerminal("mayust", "U");
            RegexBasedTerminal mayusu = new RegexBasedTerminal("mayusu", "V");
            RegexBasedTerminal mayusv = new RegexBasedTerminal("mayusv", "W");
            RegexBasedTerminal mayusw = new RegexBasedTerminal("mayusw", "X");
            RegexBasedTerminal mayusx = new RegexBasedTerminal("mayusx", "Y");
            RegexBasedTerminal mayusy = new RegexBasedTerminal("mayusy", "Z");
            RegexBasedTerminal mayusz = new RegexBasedTerminal("mayusz", "Ñ");
            RegexBasedTerminal mayusñ = new RegexBasedTerminal("mayusñ", "0");

            RegexBasedTerminal minusa = new RegexBasedTerminal("minusa", "b");
            RegexBasedTerminal minusb = new RegexBasedTerminal("minusb", "c");
            RegexBasedTerminal minusc = new RegexBasedTerminal("minusc", "d");
            RegexBasedTerminal minusd = new RegexBasedTerminal("minusd", "e");
            RegexBasedTerminal minuse = new RegexBasedTerminal("minuse", "f");
            RegexBasedTerminal minusf = new RegexBasedTerminal("minusf", "g");
            RegexBasedTerminal minusg = new RegexBasedTerminal("minusg", "h");
            RegexBasedTerminal minush = new RegexBasedTerminal("minush", "i");
            RegexBasedTerminal minusi = new RegexBasedTerminal("minusi", "j");
            RegexBasedTerminal minusj = new RegexBasedTerminal("minusj", "k");
            RegexBasedTerminal minusk = new RegexBasedTerminal("minusk", "l");
            RegexBasedTerminal minusl = new RegexBasedTerminal("minusl", "m");
            RegexBasedTerminal minusm = new RegexBasedTerminal("minusm", "n");
            RegexBasedTerminal minusn = new RegexBasedTerminal("minusn", "o");
            RegexBasedTerminal minuso = new RegexBasedTerminal("minuso", "p");
            RegexBasedTerminal minusp = new RegexBasedTerminal("minusp", "q");
            RegexBasedTerminal minusq = new RegexBasedTerminal("minusq", "r");
            RegexBasedTerminal minusr = new RegexBasedTerminal("minusr", "s");
            RegexBasedTerminal minuss = new RegexBasedTerminal("minuss", "t");
            RegexBasedTerminal minust = new RegexBasedTerminal("minust", "u");
            RegexBasedTerminal minusu = new RegexBasedTerminal("minusu", "v");
            RegexBasedTerminal minusv = new RegexBasedTerminal("minusv", "w");
            RegexBasedTerminal minusw = new RegexBasedTerminal("minusw", "x");
            RegexBasedTerminal minusx = new RegexBasedTerminal("minusx", "y");
            RegexBasedTerminal minusy = new RegexBasedTerminal("minusy", "z");
            RegexBasedTerminal minusz = new RegexBasedTerminal("minusz", "ñ");
            RegexBasedTerminal minusñ = new RegexBasedTerminal("minusñ", "0");

            NonTerminal s0 = new NonTerminal("s0"),
                        linea = new NonTerminal("linea"),
                        lineas = new NonTerminal("lineas"),
                        password = new NonTerminal("password");

            s0.Rule = lineas;

            lineas.Rule = lineas + linea
                        | linea;

            linea.Rule = codpersonal + password;

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