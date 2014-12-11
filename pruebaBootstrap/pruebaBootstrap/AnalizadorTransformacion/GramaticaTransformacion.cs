using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Irony.Parsing;
using Irony.Ast;

namespace pruebaBootstrap
{
    public class GramaticaTransformacion:Grammar
    {
        public GramaticaTransformacion() {
            RegexBasedTerminal carnet = new RegexBasedTerminal("carnet", "[0-9][0-9][0-9][0-9][0-9][0-9]");
            RegexBasedTerminal numero = new RegexBasedTerminal("numero", "[0-9]+");
            RegexBasedTerminal correo = new RegexBasedTerminal("correo", "[_a-z0-9][_a-z0-9-]*@[_a-z0-9.]+");
            RegexBasedTerminal id = new RegexBasedTerminal("id", "(a|b|c|d|e|f|g|h|i|j|k|l|m|n|o|p|q|r|s|t|u|v|w|y|z)[a-z0-9_]*");

            NonTerminal s0 = new NonTerminal("s0"),
                        items = new NonTerminal("items"),
                        item = new NonTerminal("item"),
                        funcion = new NonTerminal("funcion"),
                        exp = new NonTerminal("exp"),
                        polinomio = new NonTerminal("polinomio"),
                        monomio = new NonTerminal("monomio")
                        ;

            s0.Rule = items;

            items.Rule=items+ item
                    | item;

            item.Rule = funcion + correo + carnet
                    | ToTerm("var")+"("+id+")"+"="+exp;

            funcion.Rule = ToTerm("f") + "(" + "x" + ")" + "=" + polinomio;

            polinomio.Rule = polinomio +"+"+ monomio
                        | polinomio + "-" + monomio
                        //| ToTerm("dx/dy") + "(" + polinomio + ")"
                        | monomio;

            monomio.Rule = exp + "x"+ "^" + exp 
                        | ToTerm("x")+"^"+exp
                        | exp + "x"
                        | ToTerm("x")
                        | exp;

            exp.Rule = exp + "+" + exp
                    | exp + "-" + exp
                    | exp + "*" + exp
                    | exp + "/" + exp
                    | exp + "^" + exp
                    | ToTerm("/-") + exp
                    | ToTerm("(") + exp + ")"
                    | numero
                    | id;

            RegisterOperators(1,"+","-");
            RegisterOperators(2, "*", "/");
            RegisterOperators(3, "^");

            this.Root = s0;
        }
    }
}