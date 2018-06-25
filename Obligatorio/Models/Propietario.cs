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
        private List<Inmueble> ListaInmuebles { get; set; }
    }
}
