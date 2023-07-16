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
        public static void Main()
        {
            DBConnection db = new DBConnection();
            db.query();
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
    }
}
