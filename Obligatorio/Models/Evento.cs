using Obligatorio.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Models
{
    public class Evento
    {
        #region Propiedades
        public String FechaVisita { get; set; }
        public Comprador Buyer { get; set; }
        public Inmueble Inmueble { get; set; }
        public ManejadorDeArchivos Archivo { get; set; }
        private List<String> Listado { get; set; }
        #endregion

        public Evento()
        {
            Listado = new List<string>();
        }

        //public void FichaComprador(String nombre, String ci, String correo, Int32 telefono)
        //{
        //    Buyer = new Comprador(nombre, ci, correo, telefono);       
        //    Buyer.FichaComprador();
        //}

        public void PropiedadesVisitadas(String fechaVisita, Inmueble inmueble, String comentarios)
        {
            FechaVisita = fechaVisita;
            String Comentarios = comentarios;
        }


    }
}
