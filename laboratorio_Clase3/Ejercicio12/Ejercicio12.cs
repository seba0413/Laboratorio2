using System;

namespace Ejercicio12
{
    class Ejercicio12
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 12";
            bool isValid;
            bool isNum;
            int value;
            int acumulator = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero entero: ");
                isNum = int.TryParse(Console.ReadLine(), out value);
                acumulator += value;
                Console.WriteLine("\nLa suma es: " + acumulator);
                Console.WriteLine("\n¿Desea continuar sumando? S/N");
                isValid = ValidarRespuesta.ValidaSN(Console.ReadKey().KeyChar);               
                
            }
            while (isValid);
        }
    }
}
