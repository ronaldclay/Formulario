using DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService
{
    class DBConnection
    {
        public static void Main(string[] args)
        {
            DBConnection db = new DBConnection();
            db.query();
            db.querySave();
            Console.ReadKey();
        }

        private void query()
        {
            Ciudades city = new Ciudades();
            IList<String> cities = city.getCities();
            if (cities == null)
            {
                Console.WriteLine("No Data");
                return;
            }
            foreach (String c in cities)
            {
                Console.WriteLine(c);
            }
        }
        private void querySave()
        {
            AlumnoG ss = new AlumnoG();
            ss.SaveData("Ronald", "Ventura", "rventurave@unsa.edu.pe", "Masculino", "Jose avelardo quiñones", "Arequipa", "Mensaje");
        }
    }
}