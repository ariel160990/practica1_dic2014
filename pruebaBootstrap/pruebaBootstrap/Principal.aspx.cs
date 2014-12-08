using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Irony.Parsing;

namespace pruebaBootstrap
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AnalizadorInicio an = new AnalizadorInicio();
            //string entrada = "2222-33-222-123456";
            //A@#rceArccC#1.
            string entrada = txtndp.Text;
            Grammar gramatica = new GramaticaInicio();
            if (an.esValido(entrada, gramatica))
            {
                Grammar gramatica_eje = new GramaticaInicio();
                //el parser devuelve los cuatro bloques del NDP en un arreglo
                string[] ndp = (string[])an.ejecutar(entrada, gramatica_eje);
                Console.WriteLine(ndp.ToString());
                List<Usuario> lstusr = (List<Usuario>)obtenerUsuarios();
                //verificando si el usuario ya está registrado
                if (esUsuarioNuevo(lstusr, ndp[3])==null)
                {
                    //es usuario nuevo
                    if(!(txtpass2.Text.ToString().Equals(""))){
                        if(txtpass1.Text.ToString().Equals(txtpass2.Text.ToString())){
                            AnalizadorPass an_pass = new AnalizadorPass();
                            Grammar gramatica_pass = new GramaticaPass();
                            if (an_pass.esValido(txtpass1.Text, gramatica_pass)) {
                                Grammar gramatica_pass_eje = new GramaticaPass();
                                string clave_encriptada = (string)an_pass.ejecutar(txtpass1.Text, gramatica_pass_eje);
                                if (clave_encriptada != null)
                                {
                                    Session["anio"] = ndp[0].ToString();
                                    Session["ciclo"] = ndp[1].ToString();
                                    Session["seccion"] = ndp[2].ToString();
                                    Session["usuario"] = ndp[3].ToString();
                                    agregarUsuario(ndp[3], clave_encriptada);
                                    Response.Redirect("menu.aspx");
                                }
                                else {
                                    Response.Redirect("paginaerror.aspx?mensaje=la contraseña no cumple con el patron");
                                }
                            }
                        }else{
                            Response.Redirect("paginaerror.aspx?mensaje=Las contraseñas con coinciden");
                        }
                    }else{
                        Response.Redirect("paginaerror.aspx?mensaje=Si es usuario nuevo debe llenar todos los campos");
                    }
                }
                else { 
                    //el usuario ya existe
                    Usuario usr = esUsuarioNuevo(lstusr, ndp[3]);
                    AnalizadorPass an_pass = new AnalizadorPass();
                    Grammar gramatica_pass = new GramaticaPass();
                    if (an_pass.esValido(txtpass1.Text, gramatica_pass)) {
                        Grammar gramatica_pass_eje = new GramaticaPass();
                        string clave_encriptada = (string)an_pass.ejecutar(txtpass1.Text, gramatica_pass_eje);
                        if (usr.password.Equals(clave_encriptada))
                        {
                            Response.Redirect("menu.aspx");
                        }
                        else {
                            Response.Redirect("paginaerror.aspx?mensaje=La contraseña es incorrecta");
                        }
                    }
                }
            }
            else {
                Response.Redirect("paginaerror.aspx?mensaje=el ndp es incorrecto");
            }
            
        }

        public object obtenerUsuarios() {
            //archivo
            string cadena = "";
            string linea = "";
            System.IO.StreamReader archivo = new System.IO.StreamReader("C:\\compi2\\pass\\pass.txt",new System.Text.UTF8Encoding());
            while ((linea = archivo.ReadLine()) != null) {
                cadena = cadena + " " + linea;
            }
            archivo.Close();
            AnalizadorPassword anpass = new AnalizadorPassword();
            Grammar gramatica = new GramaticaPassword();
            if(anpass.esValido(cadena,gramatica)){
                Grammar gramatica_eje = new GramaticaPassword();
                return anpass.ejecutar(cadena,gramatica_eje);
            }
            return null;
        }

        public Usuario esUsuarioNuevo(List<Usuario> lstusr,string carnet) {
            int i = 0;
            while (i < lstusr.Count) {
                if (lstusr[i].carnet.Equals(carnet)) {
                    return lstusr[i];
                }
                i++;
            }
            return null;
        }

        public void agregarUsuario(string carnet, string clave) {
            //archivo
            string linea = carnet+" "+clave;
            System.IO.StreamWriter archivo = new System.IO.StreamWriter("C:\\compi2\\pass\\pass.txt",true);
            archivo.WriteLine(linea);
            archivo.Close();
        }
    }
}