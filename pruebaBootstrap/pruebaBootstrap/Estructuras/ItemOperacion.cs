using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pruebaBootstrap
{
    public class ItemOperacion
    {
        string correo;
        string carnet;
        string operacion;
        public ItemOperacion(string cor, string carn, string oper) {
            correo = cor;
            carnet = carn;
            operacion = oper;
        }
    }
}