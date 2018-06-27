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

        private List<Comprador> CompradoresAlfabeticamente { get; set; }

        /// <summary>
        /// Listado de inmuebles
        /// </summary>
        /// <returns></returns>
        public List<Inmueble> GetListaInmuebles()
        {
            return ManagerInmuebles.ListaInmuebles;
        }

        /// <summary>
        /// Listado de inmuebles con filtros
        /// </summary>
        /// <returns></returns>
        public List<Inmueble> ListaInmueblesConFiltros()
        {
            return ManagerInmuebles.ListaInmuebles;
        }

        /// <summary>
        /// Lista de compradores ordenados alfabeticamente
        /// </summary>
        /// <returns></returns>
        public List<Comprador> ListaCompradoresAlfabeticamente()
        {
            CompradoresAlfabeticamente = Visita.ListaCompradores.Sort();
            return CompradoresAlfabeticamente;
        }
    }
}
