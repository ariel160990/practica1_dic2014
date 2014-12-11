using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Irony.Parsing;

namespace pruebaBootstrap
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["anio"] = "2014";
            Session["ciclo"] = "01";
            Session["seccion"] = "125";
            Session["usuario"] = "334455";
            
        }

        protected void cmdCargarArchivo_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                System.IO.Stream s = FileUpload1.FileContent;
                s.Position = 0;
                byte[] bytes = new byte[s.Length];
                int numBytetoRead = (int)s.Length;
                int numbytread = 0;
                while (numBytetoRead > 0)
                {
                    int n = s.Read(bytes, numbytread, 10);
                    if (n == 0)
                    {
                        break;
                    }
                    numbytread += n;
                    numBytetoRead -= n;
                }

                bool extension_de_uno = false;
                string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                if (fileExtension.Equals(".fpt"))
                {
                    extension_de_uno = false;
                }
                else {
                    extension_de_uno = true;
                }
                if (extension_de_uno)
                {
                    //se analiza el archivo para una sola funcion
                    string cadena = System.Text.Encoding.Default.GetString(bytes);
                    derivar(cadena);
                }
                else { 
                    //se analiza el archivo para varias funciones
                    string cadena = System.Text.Encoding.Default.GetString(bytes);
                    derivar(cadena);
                }
                
            }
            else {
                Response.Redirect("paginaerror.aspx?mensaje=no se ha cagado un archivo.");
            }

            
            
        }
        public void derivar(string cadena) {
            AnalizadorTransformacion analizador = new AnalizadorTransformacion();
            Grammar gramatica = new GramaticaTransformacion();
            if (analizador.esValido(cadena, gramatica)) {
                Grammar gramatica_ejecutar = new GramaticaTransformacion();
                analizador.ejecutar(cadena, gramatica_ejecutar);
            }

        }
    }
}