using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class ArchivoIcorrectoExcepcion : Exception
    {
        public ArchivoIcorrectoExcepcion(string mensaje):base(mensaje)
        {

        }

        public ArchivoIcorrectoExcepcion(string mensaje, Exception innerException):base(mensaje, innerException)
        {

        }


    }
}
