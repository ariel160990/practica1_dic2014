using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Irony.Parsing;
using Irony.Ast;


namespace pruebaBootstrap
{
    public class GramaticaInicio:Grammar
    {
        public GramaticaInicio() {
            RegexBasedTerminal uno = new RegexBasedTerminal("uno", "[0-9][0-9][0-9][0-9]");
            RegexBasedTerminal dos = new RegexBasedTerminal("dos", "[0-9][0-9]");
            RegexBasedTerminal tres = new RegexBasedTerminal("tres", "[0-9][0-9][0-9]");
            RegexBasedTerminal cuatro = new RegexBasedTerminal("cuatro", "[0-9][0-9][0-9][0-9][0-9][0-9]");

            NonTerminal s0 = new NonTerminal("s0"),
                        ndp = new NonTerminal("ndp");

            s0.Rule = ndp;

            ndp.Rule = uno + "-" + dos + "-" + tres + "-" + cuatro;

            this.Root = s0;
        }




    }
}