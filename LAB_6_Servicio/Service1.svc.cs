using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LAB_6_Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public IList<String> getCiudades()
        {
            IList<String> ciudades = new List<String>();
            string ruta = AppDomain.CurrentDomain.BaseDirectory;
            string C= Path.Combine(ruta,"ciudades.txt");
            string[] CiudaPeru=File.ReadAllLines(C);
            for(int i=0; i<CiudaPeru.Length; i++)
            {
                ciudades.Add(CiudaPeru[i]);
            }
            return ciudades;
        }
    }
}
