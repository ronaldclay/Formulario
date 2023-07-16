using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService
{
    public interface IAlumnoG
    {
        void SaveData(string nombre, string apellido, string correo, string sexo, string direccion, string ciudad, string requerimiento);
    }
}