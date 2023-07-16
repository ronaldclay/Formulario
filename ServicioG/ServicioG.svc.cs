using DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioG
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioG" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioG.svc o ServicioG.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioG : IServicioG
    {
        public void Guardar(string nombre, string apellido, string correo, string sexo, string direccion, string ciudad, string requerimiento)
        {
            AlumnoG  ss = new AlumnoG();
            ss.SaveData(nombre, apellido, correo, sexo, direccion, ciudad, requerimiento);
        }
    }
}
