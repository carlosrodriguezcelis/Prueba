using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.WebAPI
{
    public class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }

        public int telefono { get; set; }

        public string direccion { get; set; }
   
        public int Edad(DateTime fechaNacimiento)
        {
            var resultado = DateTime.Today.Year - fechaNacimiento.Year;
            return resultado;
        }
    }
}