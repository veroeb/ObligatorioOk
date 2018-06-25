using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Models
{
    public class ImagenArchivo
    {
        public int IdCliente;
        public string Ruta;

        public ImagenArchivo(int idCliente, string ruta)
        {
            this.IdCliente = idCliente;
            this.Ruta = ruta;
        }
    }
}
