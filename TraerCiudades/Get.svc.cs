using DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TraerCiudades
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "getCities" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione getCities.svc o getCities.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class getCities : IGet
    {
        public IList<String> getciudades()
        {
            IList<String> ciudades = new List<String>();

            Ciudades c = new Ciudades();
            ciudades = c.getCities();

            return ciudades;
        }
    }
}
