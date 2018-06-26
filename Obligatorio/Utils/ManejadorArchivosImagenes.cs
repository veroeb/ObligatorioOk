using Obligatorio.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Utils
{
    public class ManejadorArchivosImagenes
    {

        private const String NOMBRE_ARCHIVO = "c:/imagenes.txt";
        
        private static ManejadorArchivosImagenes instancia = null;

        private List<ImagenArchivo> elementos = new List<ImagenArchivo>();


        #region Singleton
        public static ManejadorArchivosImagenes GetInstancia()
        {

            if (instancia == null)
            {

                instancia = new ManejadorArchivosImagenes();

            }

            return instancia;

        }
        #endregion


        public void CargarDatos()
        {

            StreamReader reader = new StreamReader(NOMBRE_ARCHIVO);

            while (reader.Peek() > -1)
            {

                String linea = reader.ReadLine();

                String[] datos = linea.Split(';');

                Int32 IdCliente = Convert.ToInt32(datos[0]);

                String ruta = datos[1];



                elementos.Add(new ImagenArchivo(IdCliente, ruta));

            }

            reader.Close();

        }



        public List<String> GetImagenesDeCliente(Int32 idCliente)
        {

            List<String> resultado = new List<String>();

            foreach (ImagenArchivo i in elementos)
            {

                if (i.IdCliente.Equals(idCliente))
                {

                    resultado.Add(i.Ruta);

                }

            }

            return resultado;

        }

    }
}
