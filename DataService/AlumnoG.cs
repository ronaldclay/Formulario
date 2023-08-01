using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;


namespace DataService
{
    public class AlumnoG : IAlumnoG
    {
        public void SaveData(string nombre, string apellido, string correo, string sexo, string direccion, string ciudad, string requerimiento)
        {
            String Valor = sexo;
            if (Valor == "Masculino")
                Valor = "M";
            else
                Valor = "F";
            string SConexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Data;Integrated Security=True";
            string insertQuery = "INSERT INTO [dbo].[DataAlumnos] (Nombre, Apellidos, Email, Sexo, Direccion, CodeCiudad, Requerimiento) VALUES (@Nombre, @Apellidos, @Email, @Sexo, @Direccion, @CodeCiudad, @Requerimiento)";
          
            using (SqlConnection connection = new SqlConnection(SConexion))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellidos", apellido);
                    command.Parameters.AddWithValue("@Email", correo);
                    command.Parameters.AddWithValue("@Sexo", Valor);
                    command.Parameters.AddWithValue("@Direccion", direccion);
                    command.Parameters.AddWithValue("@CodeCiudad", ciudad);
                    command.Parameters.AddWithValue("@Requerimiento", requerimiento);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}