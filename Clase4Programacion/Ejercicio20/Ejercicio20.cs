using System;

namespace Ejercicio20
{
    class Ejercicio20
    {
        
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 20";
            Dolar dolar = new Dolar(5);
            Pesos pesos = new Pesos(30);

            Pesos resultado = pesos + dolar;

            Console.WriteLine(resultado.getCantidad());
            Console.ReadLine();
        }
    }
}
