using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio54
{
    public class clase2
    {
        public clase2()
        {
            try
            {
                EjercicioException ejercicio = new EjercicioException();
            }
            catch (DivideByZeroException e)
            {

                throw new UnaExcepcion("Mi excepcion", e);

            }
        }
    }
}
