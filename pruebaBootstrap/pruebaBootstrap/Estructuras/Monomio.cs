using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pruebaBootstrap
{
    public class Monomio
    {
        public int basee;
        public string exponente;
        public string op;

        public Monomio(int bass, string expo,string opp) {
            basee = bass;
            exponente = expo;
            op = opp;
        }
    }
}