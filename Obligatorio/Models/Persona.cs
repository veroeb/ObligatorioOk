using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Models
{
    public class Persona
    {
        public string CI { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Persona(String ci, String nombre, String correo, String telefono)
        {
            CI = ci;
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
        }
    }
}
