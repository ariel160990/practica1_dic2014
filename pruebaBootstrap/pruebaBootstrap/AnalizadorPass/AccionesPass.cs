using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Irony.Parsing;

namespace pruebaBootstrap
{
    public class AccionesPass
    {
        int cant_numeral = 0;
        int cant_arroba = 0;
        int cant_numeros = 0;
        int cant_caracteres = 0;
        public object do_action(ParseTreeNode pt_node) {
            object result = action(pt_node);
            if (cant_numeral > 0 && cant_arroba > 0 && cant_numeros == 1 && cant_caracteres >= 10 && cant_caracteres <= 15) {
                return result;
            }
            return null;
        }

        public object action(ParseTreeNode node) {
            object result = null;
            switch (node.Term.Name.ToString()) {
                case "s0":{
                    if (node.ChildNodes.Count == 3){
                        string cadena = "";
                        cadena = (string)action(node.ChildNodes[0]);
                        cadena = cadena +" "+ (string)action(node.ChildNodes[1]);
                        cadena = cadena +" "+ (string)action(node.ChildNodes[2]);
                        cant_caracteres = cant_caracteres + 2;
                        result = cadena;
                    }
                    break;
                }
                case "password": {
                    if (node.ChildNodes.Count == 2) {
                        cant_caracteres++;
                        result = (string)action(node.ChildNodes[0]) + " " +(string)action(node.ChildNodes[1]);
                    }
                    else if (node.ChildNodes.Count == 1) {
                        cant_caracteres++;
                        result = action(node.ChildNodes[0]);
                    }
                    break;
                }
                case "esmayus": {
                    if (node.ChildNodes.Count == 1) { 
                        result = action(node.ChildNodes[0]);
                    }
                    break;
                }
                case "arroba": { result = "+-¿="; cant_arroba++; break; }
                case "numeral": { result = "*%&"; cant_numeral++; break; }
                case "punto": {result = "/\")?";break;}
                case "num0": { result = "{"; cant_numeros++; break; }
                case "num1": { result = "¡"; cant_numeros++; break; }
                case "num2": { result = ":"; cant_numeros++; break; }
                case "num3": { result = "_"; cant_numeros++; break; }
                case "num4": { result = "^"; cant_numeros++; break; }
                case "num5": { result = "]"; cant_numeros++; break; }
                case "num6": { result = "["; cant_numeros++; break; }
                case "num7": { result = "}"; cant_numeros++; break; }
                case "num8": { result = ","; cant_numeros++; break; }
                case "num9": { result = ";"; cant_numeros++; break; }
                case "mayusa": { result = "B"; break; }
                case "mayusb": { result = "C"; break; }
                case "mayusc": { result = "D"; break; }
                case "mayusd": { result = "E"; break; }
                case "mayuse": { result = "F"; break; }
                case "mayusf": { result = "G"; break; }
                case "mayusg": { result = "H"; break; }
                case "mayush": { result = "I"; break; }
                case "mayusi": { result = "J"; break; }
                case "mayusj": { result = "K"; break; }
                case "mayusk": { result = "L"; break; }
                case "mayusl": { result = "M"; break; }
                case "mayusm": { result = "N"; break; }
                case "mayusn": { result = "O"; break; }
                case "mayuso": { result = "P"; break; }
                case "mayusp": { result = "Q"; break; }
                case "mayusq": { result = "R"; break; }
                case "mayusr": { result = "S"; break; }
                case "mayuss": { result = "T"; break; }
                case "mayust": { result = "U"; break; }
                case "mayusu": { result = "V"; break; }
                case "mayusv": { result = "W"; break; }
                case "mayusw": { result = "X"; break; }
                case "mayusx": { result = "Y"; break; }
                case "mayusy": { result = "Z"; break; }
                case "mayusz": { result = "Ñ"; break; }
                case "mayusñ": { result = "0"; break; }
                case "minusa": { result = "b"; break; }
                case "minusb": { result = "c"; break; }
                case "minusc": { result = "d"; break; }
                case "minusd": { result = "e"; break; }
                case "minuse": { result = "f"; break; }
                case "minusf": { result = "g"; break; }
                case "minusg": { result = "h"; break; }
                case "minush": { result = "i"; break; }
                case "minusi": { result = "j"; break; }
                case "minusj": { result = "k"; break; }
                case "minusk": { result = "l"; break; }
                case "minusl": { result = "m"; break; }
                case "minusm": { result = "n"; break; }
                case "minusn": { result = "o"; break; }
                case "minuso": { result = "p"; break; }
                case "minusp": { result = "q"; break; }
                case "minusq": { result = "r"; break; }
                case "minusr": { result = "s"; break; }
                case "minuss": { result = "t"; break; }
                case "minust": { result = "u"; break; }
                case "minusu": { result = "v"; break; }
                case "minusv": { result = "w"; break; }
                case "minusw": { result = "x"; break; }
                case "minusx": { result = "y"; break; }
                case "minusy": { result = "z"; break; }
                case "minusz": { result = "ñ"; break; }
                case "minusñ": { result = "0"; break; }
            }
            return result;
        }

    }
}