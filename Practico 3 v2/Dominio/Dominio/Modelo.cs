using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Modelo
    {
        public string Nombre { get; set; }
        public string Pais { get; set; }

        public Modelo(string nombre, string pais)
        {
            Nombre = nombre;
            Pais = pais;
        }
    }
}