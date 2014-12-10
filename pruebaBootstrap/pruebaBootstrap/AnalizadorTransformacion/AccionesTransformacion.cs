using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Irony.Parsing;

namespace pruebaBootstrap
{
    public class AccionesTransformacion
    {
        public object do_action(ParseTreeNode pt_node)
        {
            return action(pt_node);
        }

        public object action(ParseTreeNode node)
        {
            object result = null;
            switch (node.Term.Name.ToString())
            {
                case "s0": {
                    if (node.ChildNodes.Count == 1) {
                        result = action(node.ChildNodes[0]);
                    }
                    break;
                }
                case "items": {
                    if (node.ChildNodes.Count == 1) {
                        result = action(node.ChildNodes[0]);
                    }
                    else if (node.ChildNodes.Count == 2) {
                        List<ItemOperacion> lst1 = (List<ItemOperacion>)action(node.ChildNodes[0]);
                        List<ItemOperacion> lst2 = (List<ItemOperacion>)action(node.ChildNodes[1]);
                        for (int i = 0; i < lst2.Count; i++) {
                            lst1.Add(lst2[i]);
                        }
                        result = lst1;
                    }
                    break;
                }
                case "item": {
                    string carnet = (string)action(node.ChildNodes[2]);
                    string correo = (string)action(node.ChildNodes[1]);
                    string funcion = (string)action(node.ChildNodes[0]);
                    ItemOperacion nuevaOp = new ItemOperacion(correo, carnet, funcion);
                    List<ItemOperacion> lst1 = new List<ItemOperacion>();
                    lst1.Add(nuevaOp);
                    result = lst1;
                    break;
                }
                case "funcion": {
                    List<Monomio> lstmon = (List<Monomio>)action(node.ChildNodes[5]);

                    break;
                }
                case "polinomio": {
                    if (node.ChildNodes.Count == 3)
                    {
                        List<Monomio> lstmon1 = (List<Monomio>)action(node.ChildNodes[0]);
                        List<Monomio> lstmon2 = (List<Monomio>)action(node.ChildNodes[2]);
                        for (int i = 0; i < lstmon2.Count; i++) {
                            lstmon1.Add(lstmon2[i]);
                        }
                        if(node.ChildNodes[1].Term.Name.Equals("+")){
                            lstmon1[lstmon1.Count - 1].op = "+";
                        }
                        else if (node.ChildNodes[1].Term.Name.Equals("-")) {
                            lstmon1[lstmon1.Count - 1].op = "-";
                        }
                        result = lstmon1;
                    }
                    else if(node.ChildNodes.Count==1){
                        List<Monomio> lstmon = new List<Monomio>();
                        Monomio monomio =(Monomio)action(node.ChildNodes[0]);
                        monomio.op = "+";
                        lstmon.Add(monomio);
                        result = lstmon;
                    }
                    break;
                }
                case "monomio": {
                    if (node.ChildNodes.Count == 4) {

                    }
                    else if (node.ChildNodes.Count == 3) {
                    }
                    else if (node.ChildNodes.Count == 2) {
                    }
                    else if (node.ChildNodes.Count == 1) { 
                    }
                    break;
                }

                    
            }
            return result;
        }
    }
}