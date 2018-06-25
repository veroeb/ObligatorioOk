using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Models
{
    public class Apartamento : Inmueble
    {
        public int NroPiso { get; set; }
        public int CantidadPisos { get; set; }
        public bool Porteria { get; set; }
        public bool AceptaMascotas { get; set; }
    }
}
