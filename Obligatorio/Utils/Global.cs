using Obligatorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Utils
{
    public class Global
    {
        public Inmueble Inmueble { get; set; }
        public static String BooleanToString(Boolean valor)
        {
            if (valor)
            {
                return "Si";
            }
            return "No";
        }

        //public static List<string> GetComentarios()
        //{
        //    Inmueble = new Inmueble();
        //    return inm
        //}
    }
}
