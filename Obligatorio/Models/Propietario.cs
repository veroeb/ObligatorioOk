using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Models
{
    public class Propietario : Persona
    {
        public string Direccion { get; set; }
        private List<Inmueble> InmueblesPropietario { get; set; }

        public Propietario(String ci, String nombre, String direccion, String correo, String telefono) : base(ci, nombre, correo, telefono)
        {
            CI = ci;
            Nombre = nombre;
            Direccion = direccion;
            Correo = correo;
            Telefono = telefono;
            InmueblesPropietario = new List<Inmueble>();

        }
    }
}
