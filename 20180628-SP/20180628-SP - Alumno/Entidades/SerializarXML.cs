using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Entidades
{
    public class SerializarXML<T> : IArchivos<T>
    {
        public bool Guardar(string rutaArchivo, T objeto)
        {
            bool todoOk = false;
            
            XmlTextWriter writer = null; 
            XmlSerializer ser;
            try
            {
                writer = new XmlTextWriter(rutaArchivo, Encoding.UTF8);

                ser = new XmlSerializer(typeof(T));

                ser.Serialize(writer, objeto);

                todoOk = true; 
            }
            catch (Exception)
            {
                throw new ErrorArchivoException();
            }

            finally
            {
                writer.Close();
            }

            return todoOk;
        }

        public T Leer(string rutaArchivo)
        {
            XmlTextReader reader = null;   
            XmlSerializer ser;
            T objeto;

            try
            {
                reader = new XmlTextReader(rutaArchivo);
                ser = new XmlSerializer(typeof(T));
                objeto = (T)ser.Deserialize(reader);          
            }
            catch (Exception)
            {
                throw new ErrorArchivoException();
            }

            finally
            {
               reader.Close();
            }

            return objeto;
        }
    }
}
