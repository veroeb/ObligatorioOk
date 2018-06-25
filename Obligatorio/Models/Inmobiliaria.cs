using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Models
{
    public class Inmobiliaria
    {
        #region Singleton
        public static Inmobiliaria Instancia = null;
        public static Inmobiliaria GetInmobiliaria()
        {
            if (Instancia == null)
            {
                Instancia = new Inmobiliaria();
            }

            return Instancia;
        }
        #endregion
    }
}
