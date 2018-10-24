using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio54
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                clase2 clase2 = new clase2();
            }
            catch (UnaExcepcion e)
            {
                if(!(e.InnerException is null))
                 Console.WriteLine(e.InnerException.Message);

                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                throw;
            }
            Console.ReadKey();
        }
    }
}
