using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioG
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioG" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioG
    {
        [OperationContract]
        void Guardar(string nombre, string apellido, string correo, string sexo, string direccion, string ciudad, string requerimiento);
    }
}
