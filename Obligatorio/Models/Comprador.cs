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
    }
}
