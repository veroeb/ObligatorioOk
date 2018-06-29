using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Models
{
    public class Comprador : Persona
    {
        private List<Visita> Visitas { get; set; }
        private List<Inmueble> PropiedadesVisitadas { get; set; }

        public Comprador(String nombre, String ci, String correo, String telefono) : base(ci, nombre, correo, telefono)
        {
            Nombre = nombre;
            CI = ci;
            Correo = correo;
            Telefono = telefono;
            PropiedadesVisitadas = new List<Inmueble>();
        }
    }
}
