using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Models
{
    public class Inmueble
    {
        public float Precio { get; set; }
        public int CantidadHabitaciones { get; set; }
        public int CantidadDormitorios { get; set; }
        public int CantidadBaños { get; set; }
        public int AñoConstruccion { get; set; }
        public float MetrosEdificados { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string Barrio { get; set; }
        public string Ubicacion { get; set; }
        public EstadoInmueble Estado { get; set; }
        public float GastosComunes { get; set; }
        public int Garages { get; set; }
        public bool Parrillero { get; set; }
        public string Comentarios { get; set; }
        //public List<string> Comentarios { get; set; }
        public List<string> Fotos { get; set; }
    }
}
