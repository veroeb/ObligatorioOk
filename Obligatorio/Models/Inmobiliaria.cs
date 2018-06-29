using Obligatorio.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Models
{
    public class Inmobiliaria
    {
        public static DateTime Fecha { get; set; }
        public static List<Comprador> ListaCompradores = new List<Comprador>();
        public static ManejadorDeArchivos manejadorDeArchivos = new ManejadorDeArchivos();
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
            return ListaCompradores.OrderBy(x => x.Nombre).ToList();
        }   
        public static void AgregarComprador(Comprador comprador)
        {
            ListaCompradores.Add(comprador);
            //ListaCompradores.Sort();
            AgregarCompradorArchivo();
        }

        public static void AgregarCompradorArchivo()
        {
            foreach (Comprador c in ListaCompradores)
            {
                manejadorDeArchivos.Escribir("Lista de compradores.txt", $"{Fecha}" +                     
                     $" Nombre: {c.Nombre}," +
                     $" CI: {c.CI}," +
                     $" Correo: {c.Correo}," +
                     $" Telefono: {c.Telefono},");
            }
        }

        public void AgendarVisita(Comprador c, Inmueble i)
        {
            
        }
    }
}
