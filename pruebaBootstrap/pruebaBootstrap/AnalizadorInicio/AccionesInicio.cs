using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Irony.Parsing;


namespace pruebaBootstrap
{
    public class AccionesInicio
    {
        public object do_action(ParseTreeNode pt_node) {
            return action(pt_node);
        }

        public object action(ParseTreeNode node) {
            object result = null;
            switch (node.Term.Name.ToString()) {
                case "s0":{
                    if (node.ChildNodes.Count == 1) { 
                        result = action(node.ChildNodes[0]);
                    }
                    break;
                }
                case "ndp": {
                    if (node.ChildNodes.Count == 7) {
                        string uno = (string)action(node.ChildNodes[0]);
                        string dos = (string)action(node.ChildNodes[2]);
                        string tres = (string)action(node.ChildNodes[4]);
                        string cuatro = (string)action(node.ChildNodes[6]);
                        string[] ndp = new string[4];
                        ndp[0] = uno;
                        ndp[1] = dos;
                        ndp[2] = tres;
                        ndp[3] = cuatro;
                        result = ndp;
                    }
                    break;
                }
                case "uno": {
                    result = node.Token.Value.ToString();
                    break;
                }
                case "dos": {
                    result = node.Token.Value.ToString();
                    break;
                }
                case "tres": {
                    result = node.Token.Value.ToString();
                    break;
                }
                case "cuatro":{
                    result = node.Token.Value.ToString();
                    break;
                }
            }
            return result;
        }
    }
}