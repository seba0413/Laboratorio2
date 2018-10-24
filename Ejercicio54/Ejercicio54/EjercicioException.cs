using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio54
{
    public class EjercicioException
    {
        public EjercicioException()
        {
            try
            {
                EjercicioException.Metodo(1, 0);
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
        }

          

        public static void Metodo(int num1, int num2)
        {
            try
            {
                int num3 = num1 / num2;
            }

            catch(DivideByZeroException e)
            {
                throw e;
            }      
        }
    }
}
