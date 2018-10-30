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
            throw new NotImplementedException();
        }

        public string Leer(string ruta)
        {
            throw new NotImplementedException();
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
    