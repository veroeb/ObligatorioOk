using Obligatorio.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Models
{
    public static class Visita
    {
        public static DateTime Fecha { get; set; }
        public static string Comentario { get; set; }
        public static Comprador Comprador { get; set; }    
        public static Inmueble Inmueble { get; set; }
        public static List<Comprador> ListaCompradores { get; set; }
        public static ManejadorDeArchivos manejadorDeArchivos { get; set; }


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
                    $" Inmueble: {Inmueble.Ubicacion}," +
                    $" Nombre: {c.Nombre}," +
                    $" CI: {c.CI}," +
                    $" Correo: {c.Correo}," +
                    $" Telefono: {c.Telefono}," +
                    $" Comentarios: {Comentario}.");
            }
        }
    }
}
