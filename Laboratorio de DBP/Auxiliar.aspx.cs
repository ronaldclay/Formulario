using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_de_DBP
{
    public partial class Auxiliar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadSession();
            deleteSessions();
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

        protected void ButtonCookie_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["Cookies"];
            string sexo, ciudad;
            if (cookie != null)
            {
                sexo = cookie.Values["sexo"];
                ciudad = cookie.Values["ciudad"];
                string informacion = $"Sexo: {sexo}, Ciudad: {ciudad}";
                Cookie.Text = informacion;
            }
        }
    }
}