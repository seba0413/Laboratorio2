using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivos<string>
    {
        public bool Guardar(string ruta, string obj)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.Write(obj);
            sw.Close();

            //if (!(this.Leer(ruta).Equals(obj)))
                //return false;

            return true;
        }

        public string Leer(string ruta)
        {
            StreamReader sr = new StreamReader(ruta);
            string archivo = sr.ReadToEnd();
            sr.Close();
            return archivo;
        }

        protected override bool ValidarArchivo(string ruta)
        {
            try
            {
                if (!(Path.GetExtension(ruta).Equals(".txt")))
                    throw new ArchivoIcorrectoExcepcion("El archivo no es un txt");

                    base.ValidarArchivo(ruta);        
            }
            catch(FileNotFoundException e)
            {
                throw new ArchivoIcorrectoExcepcion("El archivo no es correcto", e);
            }         

            return true;
        }
    }
}
    