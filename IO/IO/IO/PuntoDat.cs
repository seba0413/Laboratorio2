using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace IO
{
    [Serializable]

    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        private string contenido; 

        public string Contenido
        {
            get
            {
                return this.contenido;
            }

            set
            {
                this.contenido = value; 
            }
        }

        public bool Guardar(string ruta, PuntoDat obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            bf.Serialize(fileStream, obj);
            fileStream.Close();

            //if (!(this.Leer(ruta).Equals(obj)))
            //    return false;

            return true;            
        }

        public PuntoDat Leer(string ruta)
        {
            PuntoDat archivo = new PuntoDat();
            FileStream fs;
            BinaryFormatter bf;

            fs = new FileStream(ruta, FileMode.Open);
            bf = new BinaryFormatter();
            archivo = (PuntoDat)bf.Deserialize(fs);
            fs.Close();
            return archivo;
        }

        protected override bool ValidarArchivo(string ruta)
        {
            try
            {
                if (!(Path.GetExtension(ruta).Equals(".dat")))
                    throw new ArchivoIcorrectoExcepcion("El archivo no es un dat");

                base.ValidarArchivo(ruta);
            }
            catch (FileNotFoundException e)
            {
                throw new ArchivoIcorrectoExcepcion("El archivo no es correcto", e);
            }

            return true;
        }
    }
}
