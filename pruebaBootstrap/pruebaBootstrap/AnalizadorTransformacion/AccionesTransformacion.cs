using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Irony.Parsing;

namespace pruebaBootstrap
{
    public class AccionesTransformacion
    {
        public ListaVariables lstVariables;
        public object do_action(ParseTreeNode pt_node)
        {
            lstVariables = new ListaVariables();
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
                        if (lst2 != null) {
                            for (int i = 0; i < lst2.Count; i++)
                            {
                                if (lst1 != null) { lst1.Add(lst2[i]); }
                            }
                        }
                        if (lst1 == null)
                        {
                            result = lst2;
                        }
                        else {
                            result = lst1;
                        }
                    }
                    break;
                }
                case "item": {
                    if (node.ChildNodes.Count == 3)
                    {
                        string carnet = (string)action(node.ChildNodes[2]);
                        string correo = (string)action(node.ChildNodes[1]);
                        string funcion = (string)action(node.ChildNodes[0]);
                        ItemOperacion nuevaOp = new ItemOperacion(correo, carnet, funcion);
                        List<ItemOperacion> lst1 = new List<ItemOperacion>();
                        lst1.Add(nuevaOp);
                        result = lst1;
                    }
                    else {
                        if (lstVariables.buscarVariable(node.ChildNodes[2].Token.Value.ToString()) == null)
                        {
                            int valor = (int)action(node.ChildNodes[5]);
                            lstVariables.agregarVariable(node.ChildNodes[2].Token.Value.ToString(), valor);
                        }
                        result = null;
                    }
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
                        List<Monomio> lstmon = (List<Monomio>)action(node.ChildNodes[0]);
                        lstmon[lstmon.Count - 1].op = "+";
                        result = lstmon;
                        //List<Monomio> lstmon = new List<Monomio>();
                        //Monomio monomio =(Monomio)action(node.ChildNodes[0]);
                        //monomio.op = "+";
                        //lstmon.Add(monomio);
                        //result = lstmon;
                    }
                    break;
                }
                case "monomio": {
                    if (node.ChildNodes.Count == 4) {
                        int cbase = (int)evaluarExpresion(node.ChildNodes[0]);
                        int cexpo = (int)evaluarExpresion(node.ChildNodes[3]);
                        cbase = cbase * cexpo;
                        cexpo = cexpo - 1;
                        Monomio mono = new Monomio(cbase, cexpo, "+");
                        List<Monomio> lstmon = new List<Monomio>();
                        lstmon.Add(mono);
                        result = lstmon;
                    }
                    else if (node.ChildNodes.Count == 3) {
                        int cbase = (int)evaluarExpresion(node.ChildNodes[2]);
                        int cexpo = cbase - 1;
                        Monomio mono = new Monomio(cbase, cexpo, "+");
                        List<Monomio> lstmon = new List<Monomio>();
                        lstmon.Add(mono);
                        result = lstmon;
                    }
                    else if (node.ChildNodes.Count == 2) {
                        int cbase = (int)evaluarExpresion(node.ChildNodes[0]);
                        int cexpo = 0;
                        Monomio mono = new Monomio(cbase,cexpo,"+");
                        List<Monomio> lstmon = new List<Monomio>();
                        lstmon.Add(mono);
                        result = lstmon;
                    }
                    else if (node.ChildNodes.Count == 1) {
                        if (node.ChildNodes[0].Term.Name.Equals("exp"))
                        {
                            Monomio mono = new Monomio(0, 0, "+");
                            List<Monomio> lstmon = new List<Monomio>();
                            lstmon.Add(mono);
                            result = lstmon;
                        }
                        else {
                            Monomio mono = new Monomio(1, 0, "+");
                            List<Monomio> lstmon = new List<Monomio>();
                            lstmon.Add(mono);
                            result = lstmon;
                        }
                    }
                    break;
                }
                case "exp": {
                    result= evaluarExpresion(node);
                    break;
                }

                    
            }
            return result;
        }

        public object evaluarExpresion(ParseTreeNode node)
        {
            object result = null;
            if (node.ChildNodes.Count == 3) {
                if (node.ChildNodes[0].Term.Name.Equals("("))
                {
                    result = evaluarExpresion(node.ChildNodes[1]);
                }
                else {
                    object nodo1 = evaluarExpresion(node.ChildNodes[0]);
                    object nodo2 = evaluarExpresion(node.ChildNodes[2]);
                    if (node.ChildNodes[1].Term.Name.Equals("+")) {
                        int r = (int)nodo1 + (int)nodo2;
                        result = r;
                    }
                    else if (node.ChildNodes[1].Term.Name.Equals("-")) {
                        int r = (int)nodo1 - (int)nodo2;
                        result = r;
                    }
                    else if (node.ChildNodes[1].Term.Name.Equals("*")) {
                        int r = (int)nodo1 * (int)nodo2;
                        result = r;
                    }
                    else if (node.ChildNodes[1].Term.Name.Equals("/")) {
                        int r = (int)nodo1 / (int)nodo2;
                        result = r;
                    }else if(node.ChildNodes[1].Term.Name.Equals("^")){
                        int r = (int)Math.Pow((int)nodo1, (int)nodo2);
                        result = r;
                    }
                }
            } if (node.ChildNodes.Count == 1) {
                if (node.ChildNodes[0].Term.Name.Equals("numero")) {
                    int a = int.Parse(node.ChildNodes[0].Token.Value.ToString());
                    result = a;
                }
                else if (node.ChildNodes[0].Term.Equals("id")) {
                    if (lstVariables.buscarVariable(node.ChildNodes[0].Token.Value.ToString()) == null)
                    {
                        Variable varr = lstVariables.buscarVariable(node.ChildNodes[0].Token.Value.ToString());
                        int a = varr.valor;
                    }
                    else {
                        result = null;
                    }
                }
            }
            return result;
        }
    }
}