using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Irony.Parsing;

namespace pruebaBootstrap
{
    public class AnalizadorTransformacion
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
            AccionesTransformacion acciones = new AccionesTransformacion();
            return acciones.do_action(arbol.Root);
        }
    }
}