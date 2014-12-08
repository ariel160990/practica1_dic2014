using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Irony.Parsing;
using Irony.Ast;

namespace pruebaBootstrap
{
    public class AnalizadorPassword
    {
        public bool esValido(string codigo, Grammar gramatica) {
            LanguageData lenguaje = new LanguageData(gramatica);
            Parser p = new Parser(lenguaje);
            ParseTree arbol = p.Parse(codigo);
            return arbol.Root != null;
        }

        public object ejecutar(string codigo, Grammar gramatica)
        {
            LanguageData lenguaje = new LanguageData(gramatica);
            Parser p = new Parser(lenguaje);
            ParseTree arbol = p.Parse(codigo);
            AccionesPassword acciones = new AccionesPassword();
            return acciones.do_action(arbol.Root);
        }
    }
}