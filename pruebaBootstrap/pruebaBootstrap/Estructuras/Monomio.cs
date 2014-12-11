using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pruebaBootstrap
{
    public class Monomio
    {
        public int basee;
        public int exponente;
        public string op;

        public Monomio(int bass, int expo,string opp) {
            basee = bass;
            exponente = expo;
            op = opp;
        }
    }
}