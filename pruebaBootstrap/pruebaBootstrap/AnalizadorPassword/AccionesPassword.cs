using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Irony.Parsing;

namespace pruebaBootstrap
{
    public class AccionesPassword
    {
        public object do_action(ParseTreeNode pt_node)
        {
            return action(pt_node);
        }

        public object action(ParseTreeNode node) {
            object result = null;
            switch (node.Term.Name.ToString()) {
                case "s0":{
                    if (node.ChildNodes.Count == 1){
                        result = action(node.ChildNodes[0]);
                    }
                    break;
                }
                case "lineas": {
                    if (node.ChildNodes.Count == 2) {
                        List<Usuario> lstusr = (List<Usuario>)action(node.ChildNodes[0]);
                        lstusr.Add((Usuario)action(node.ChildNodes[1]));
                        result = lstusr;
                    }
                    else if (node.ChildNodes.Count == 1) {
                        List<Usuario> lstusr = new List<Usuario>();
                        lstusr.Add((Usuario)action(node.ChildNodes[0]));
                        result = lstusr;
                    }
                    break;
                }
                case "linea": {
                    if (node.ChildNodes.Count == 2) {
                        Usuario usr = new Usuario((string)action(node.ChildNodes[0]), (string)action(node.ChildNodes[1]));
                        result = usr;
                    }
                    break;
                }
                case "password": {
                    if (node.ChildNodes.Count == 2) {
                        result = (string)action(node.ChildNodes[0]) +" " +(string)node.ChildNodes[1].Token.Value;
                    }
                    else if (node.ChildNodes.Count == 1) {
                        result = (string)node.ChildNodes[0].Token.Value;
                    }
                    break;
                }
                case "codpersonal": {
                    result = (string)node.Token.Value;
                    break;
                }
            }
            return result;
        }
    }
}