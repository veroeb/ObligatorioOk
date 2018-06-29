using Obligatorio.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Models
{
    public static class ManagerInmuebles
    {
        public static List<Inmueble> ListaInmuebles = new List<Inmueble>();
        static ManejadorDeArchivos manejadorDeArchivos = new ManejadorDeArchivos();
        static ManejadorArchivosImagenes ManejadorArchivosImagenes = new ManejadorArchivosImagenes();


        public static void AgregarPropiedad(Inmueble InmuebleaAgregar)
        {
            ListaInmuebles.Add(InmuebleaAgregar);
            AgregarPropiedadArchivo();     
        }

        public static String VenderAlquilar(Inmueble inmueble, Comprador comprador)
        {
            ListaInmuebles.Remove(inmueble);
            return ("Ahora esta propiedad es de: " + comprador.Nombre);
        }

        public static void AgregarPropiedadArchivo()
        {
            foreach (Inmueble i in ListaInmuebles)
            {
                if (i is Casa)
                {
                    manejadorDeArchivos.Escribir("Listado de propiedades.txt", $"Precio {i.Precio};" +
                        $" habitaciones: {i.CantidadHabitaciones}," +
                        $" dormitorios: {i.CantidadDormitorios}," +
                        $" baños: {i.CantidadBaños}," +
                        $" año de construcción: {i.AñoConstruccion}," +
                        $" metros cuadrados: {i.MetrosEdificados} m\xB2," +
                        $" departamento: {i.Departamento}," +
                        $" ciudad: {i.Ciudad}," +
                        $" barrio: {i.Barrio}," +
                        $" estado fisico: {i.Estado}," +
                        $" garages: {i.Garages}," +
                        $" direccion: {i.Ubicacion}," +
                        $" jardin: {Global.BooleanToString((i as Casa).Jardin)}," +
                        $" patio: {Global.BooleanToString((i as Casa).Patio)}," +
                        $" parrillero: {Global.BooleanToString(i.Parrillero)}," +
                        $" comentarios: {i.Comentarios}," +
                        $" fotos: {i.Fotos}.");
                }
                else if (i is Apartamento)
                {
                    manejadorDeArchivos.Escribir("Listado de propiedades.txt", $"Precio: U$S {i.Precio}," +
                        $" habitaciones: {i.CantidadHabitaciones}," +
                        $" dormitorios: {i.CantidadDormitorios}," +
                        $" baños: {i.CantidadBaños}," +
                        $" año de construcción: {i.AñoConstruccion}," +
                        $" metros cuadrados: {i.MetrosEdificados} m\xB2," +
                        $" departamento: {i.Departamento}," +
                        $" ciudad: {i.Ciudad}," +
                        $" barrio: {i.Barrio}," +
                        $" estado fisico: {i.Estado}," +
                        $" garages: {i.Garages}," +
                        $" direccion: {i.Ubicacion}," +
                        $" numero de piso: {(i as Apartamento).NroPiso}," +
                        $" porteria: {Global.BooleanToString((i as Apartamento).Porteria)}," +
                        $" parrillero: {Global.BooleanToString(i.Parrillero)}," +
                        $" total de pisos: {(i as Apartamento).CantidadPisos}," +
                        $" gastos comunes: {(i as Apartamento).GastosComunes}," +
                        $" comentarios: {i.Comentarios}," +
                        $" fotos: {i.Fotos}.");

                }
            }
        }


        /* 
         * ver si poner el filtro aca
         */
    
        //public static void Filtro()
        //{
        //    bool filtrarPorDepartamento = true;
        //    bool filtrarPorBarrio = true;
        //    bool filtrarPorGarage = true;

        //    //List<Inmueble> listaInmuebles = new List<Inmueble>();

        //    Inmobiliaria inmobiliaria = Inmobiliaria.GetInmobiliaria();

        //    List<Inmueble> listaInmuebles = new List<Inmueble>();
        //    listaInmuebles = inmobiliaria.GetListaInmuebles();

        //    foreach (Inmueble i in listaInmuebles)
        //    {
        //        if (filtrarPorDepartamento)
        //            listaInmuebles = listaInmuebles.Where(x => x.Departamento == comboBoxDepartamento.SelectedItem.ToString()).ToList();
        //        if (filtrarPorBarrio)
        //            listaInmuebles = listaInmuebles.Where(x => x.Barrio == comboBoxBarrio.SelectedItem.ToString()).ToList();
        //        if (filtrarPorGarage)
        //            listaInmuebles = listaInmuebles.Where(x => x.Garages == Convert.ToInt32(comboBoxGarage.SelectedItem.ToString())).ToList();
        //    }
        //}
    }
}
