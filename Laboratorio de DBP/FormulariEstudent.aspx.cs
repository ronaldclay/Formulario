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
            string[] info = new string[7] { Name, LastName, Mail, Sexo, Address, City, Message };
            string[] tags = { "Nombre: ", "Apellido: ", "Correo: ", "Sexo: ", "Direccion: ", "Ciudad: ", "Requerimiento: " };

            // En esta parte llamaraemos al servicio para almacenar los datos
            Guardar(Name, LastName, Mail, Sexo, Address, City, Message);

            for (int i = 0; i < info.Length; i++)
            {
                if (info[i] == "")
                {
                    List<string> infoList = new List<string>(info);
                    infoList.RemoveAt(i);
                    info = infoList.ToArray();

                    List<string> tagList = new List<string>(tags);
                    tagList.RemoveAt(i);
                    tags = tagList.ToArray();
                }

            }

            for (int i = 0; i < info.Length; i++)
            {
                Literal literal = new Literal();
                literal.Text = "<p class='mb-1'>" + tags[i] + info[i] + "</p>";
                Mostrar.Controls.Add(literal);
            }

        }
    }
}