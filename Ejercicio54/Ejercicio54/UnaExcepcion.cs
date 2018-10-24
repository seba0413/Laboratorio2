using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio54
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion():base()
        {

        }

        public UnaExcepcion(string mensaje):base(  "Excpcion creada por mi - " + mensaje)
        {

        }


        public UnaExcepcion(string mensaje, Exception exception) : base(mensaje, exception)
        {

        }


    }
}
