using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Irony.Parsing;
using Irony.Ast;

namespace pruebaBootstrap
{
    public class AnalizadorPass
    {
        public bool esValido(string codigo, Grammar gramatica)
        {
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
            AccionesPass acciones = new AccionesPass();
            return acciones.do_action(arbol.Root);
        }
    }
}