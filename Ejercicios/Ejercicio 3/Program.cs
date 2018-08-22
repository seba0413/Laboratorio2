using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 3";
            int primo = 0;
            bool esNum;
            bool isPrime = true;
            Console.WriteLine("Ingresar un numero: ");
            esNum = int.TryParse(Console.ReadLine(), out primo);

            for (int i = 0; i <= primo; i++)
            {
                for (int j = 2; j <= primo; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("Prime:" + i);
                }
                isPrime = true;                
            }
            Console.ReadKey();
        }
    }
}
