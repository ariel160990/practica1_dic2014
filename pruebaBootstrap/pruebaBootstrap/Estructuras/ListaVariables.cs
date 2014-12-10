using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pruebaBootstrap
{
    public class ListaVariables
    {
        public List<Variable> lst;
        public ListaVariables() { 
            lst=new List<Variable>();
        }

        public Variable buscarVariable(string nombre) {
            for (int i = 0; i < lst.Count; i++) {
                if (lst[i].nombre.Equals(nombre)) { 
                    return lst[i];
                }
            }
            return null;
        }

        public void agregarVariable(string nombre, int valor) {
            lst.Add(new Variable());
            lst[lst.Count - 1].nombre = nombre;
            lst[lst.Count - 1].valor = valor;
        }
    }
}