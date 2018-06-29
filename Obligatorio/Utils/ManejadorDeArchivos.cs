using Obligatorio.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Obligatorio.Utils
{
    public class ManejadorDeArchivos
    {
        
        public void Escribir(String nomArchivo, String texto)
        {
            StreamWriter writer = new StreamWriter(nomArchivo, true);
            writer.WriteLine(texto);
            writer.Close();
        }

        public List<String> Leer(String nomArchivo)
        {
            StreamReader reader = new StreamReader(nomArchivo);
            List<String> lineasArchivo = new List<String>();
            while (reader.Peek() > -1)
            {
                lineasArchivo.Add(reader.ReadLine());
            }
            reader.Close();
            return lineasArchivo;
        }

        //public List<Inmueble> InfoArchivo(String path)
        //{
        //    Alumnos = new List<Alumno>();

        //    List<String> lineasArchivo = Leer(path);

        //    String[] lineaPalabras;

        //    foreach (String l in lineasArchivo)
        //    {
        //        lineaPalabras = l.Split(',');
        //        String Nombre = lineaPalabras[0];
        //        String Apellido = lineaPalabras[1];
        //        String CI = lineaPalabras[2];

        //        Alumnos.Add(new Alumno(Nombre, Apellido, CI));
        //    }

        //    return Alumnos;
        //}

    }

}