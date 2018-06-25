using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Models
{
    public class Visita
    {
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }
        public Comprador Comprador { get; set; }    
        public Inmueble Inmueble { get; set; }
    }
}
