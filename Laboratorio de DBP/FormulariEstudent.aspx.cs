using Antlr.Runtime;
using Laboratorio_de_DBP.ServiceReference1;
using Laboratorio_de_DBP.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Optimization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace Laboratorio_de_DBP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string path = Server.MapPath("./App_Data/ciudades.txt");
            //string[] ciudad = File.ReadAllLines(path);
            String[] ciudades = serviceCall();

            for (int i = 0; i < ciudades.Length; i++)
            {
                ListItem item = new ListItem(ciudades[i], ciudades[i]);
                ListaCiudad.Items.Add(item);
            }

        }
        private string[] serviceCall()
        {
            GetClient client = new GetClient();
            String[] ciudades = client.getciudades();
            Array.Sort(ciudades);
            return ciudades;
        }
        private void Guardar(string nombre, string apellido, string correo, string sexo, string direccion, string ciudad, string requerimiento)
        {
            ServicioGClient save = new ServicioGClient();
            save.Guardar(nombre, apellido, correo, sexo, direccion, ciudad, requerimiento);

        }
        protected void ButtonEnviar_Click(object sender, EventArgs e)
        {
            string Name = Nombre.Text;
            string LastName = Apellido.Text;
            bool Male = botonMasculino.Checked;
            bool Female = botonFemenino.Checked;
            string Mail = Email.Text;
            string Address = Direccion.Text;
            string City = ListaCiudad.Text;
            string Message = Mensaje.InnerText;
            string Sexo;

            if (Female==true)
            {
                Sexo="Femenino";
            }
            else
            {
                Sexo="Masculino";
            }
            if (Male==true)
            {
                Sexo="Masculino";
            }
            else
            {
                Sexo="Femenino";
            }
            Mostrar.Text="Nombre: "+ Name + "</br>Apellido: "+LastName+ "</br>Sexo: "+Sexo+"</br>Email: "+Mail+"</br>Direccion: "+Address+"</br>Ciudad: "+City+"</br>Requirimiento: "+Message;
            Guardar(Name, LastName, Mail, Sexo, Address, City, Message);
            Secion(Name, LastName);
            cook(Sexo, City);
        }
        private void cook(string Sexo, string City)
        {
            HttpCookie cookie = new HttpCookie("sexo", Sexo);
            HttpCookie cookie2 = new HttpCookie("ciudad", City);
            Response.Cookies.Add(cookie);
            Response.Cookies.Add(cookie2);


            Response.Redirect("Auxiliar");

        }

        private void Secion(String nombre, String apellido)
        {
            Session["Nombre"] = nombre;
            Session["Apellido"] = apellido;
        }

        [WebMethod]
        public static String recibirJSON(String nombre, String apellido)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Data;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM DataAlumnos WHERE Nombre = @name AND Apellidos = @lastname";
            int count = 0;
            using (SqlConnection connection = new
            SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query,
                connection))
                {
                    command.Parameters.AddWithValue("@name", nombre);
                    command.Parameters.AddWithValue("@lastname", apellido);
                    connection.Open();
                    count = (int)command.ExecuteScalar();
                }
            }
            if (count>0)
            {
                return "0 Ya esta registrado :" + nombre + " " + apellido;

            }
            else
            {
                return "1 No esta registrado:" + nombre + " " + apellido;

            }
        }
    }
}