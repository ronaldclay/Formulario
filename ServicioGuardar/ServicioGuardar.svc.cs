using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.UI.WebControls;

namespace ServicioGuardar
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioGuardar" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioGuardar.svc o ServicioGuardar.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioGuardar : IServicioGuardar
    {
        public void Guardar(string[] G)
        {
            string R = @"C:\\Users\\user\\Desktop\\DBP\\Laboratorio de DBP\\ServicioGuardar\\Guardar.txt";
            File.WriteAllLines(R, G);
        }
    }
}
