using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pruebaBootstrap
{
    public class Usuario
    {
        public string carnet;
        public string password;
        public Usuario(string carn, string pass) {
            carnet = carn;
            password = pass;
        }
    }
}