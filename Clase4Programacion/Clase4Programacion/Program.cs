using System;

namespace Clase4Programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((new Metro(5) + new Centimetro(800)).valor);
            Console.ReadKey();
        }

    }
}
