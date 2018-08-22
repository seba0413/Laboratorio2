using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 1";
            int numero;
            int minimo = 0;
            int maximo = 0;
            int acumulador = 0; 
            int flag = 0; 
            int i;

            for(i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                if (flag == 0)
                {
                    minimo = numero;
                    maximo = numero;
                    acumulador += numero;
                    flag++;
                }
                else
                {
                    if (numero < minimo)
                        minimo = numero;
                    if (numero > maximo)
                        maximo = numero;

                    acumulador += numero;
                }                             
            }
            Console.WriteLine("Minimo: " + minimo + "\n" + "Maximo: " + maximo + "\n" + "Promedio: " + acumulador / 5);
            Console.ReadKey();

            double potencia;
            double cuadrado;
            double cubo;

            Console.WriteLine("Ingrese un numero: ");
            potencia = double.Parse(Console.ReadLine());

            if (potencia < 0)
                Console.WriteLine("ERROR. ¡Reingresar numero!");

            cuadrado = Math.Pow(potencia, 2);
            cubo = Math.Pow(potencia, 3);

            Console.WriteLine("El cuadrado es: " + cuadrado + "\n" + "El cubo es: " + cubo);
            Console.ReadKey();

        }


    }
}
