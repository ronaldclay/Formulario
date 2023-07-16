using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataService
{
    public class Ciudades : ICiudades
    {
        public IList<String> getCities()
        {
            IList<String> C = new List<String>();
            string conexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Data;Integrated Security=True";
            string consulta = "SELECT Ciudades FROM [dbo].[DataCiudad]";
            SqlConnection connection = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                connection = new SqlConnection(conexion);
                connection.Open();
                cmd = new SqlCommand(consulta, connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string ciudad = reader.GetString(0);
                    C.Add(ciudad);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                reader.Close();
                reader.Dispose();
                cmd.Dispose();
                connection.Close();
                connection.Dispose();

            }
            return C;
        }
    }
}