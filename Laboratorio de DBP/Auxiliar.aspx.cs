using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Laboratorio_de_DBP
{
    public partial class Auxiliar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadSession();
        }
        
        private void loadSession()
        {
            String nombre = (String)(Session["Nombre"]);
            String apellido = (String)(Session["Apellido"]);
            Usuario.Text = "Enviado por Sesion: ";
            Nombre.Text = "Nombre: " + nombre;
            Apellido.Text = " Apellido: " + apellido;

        }
        private void deleteSessions()
        {
            Session.RemoveAll();
            Session.Abandon();
        }

        protected void ButtonCerrar(object sender, EventArgs e)
        {
            deleteSessions();
            Response.Redirect("FormulariEstudent");
        }
        [WebMethod]
        public static String getInformacion(String valor)
        {
            return "Desde el servidor se recibio :" + valor;
        }
    }
}