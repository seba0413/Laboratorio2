using System;

namespace laboratorio_Clase3
{
    class Ejercicio11
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 11";
            int valor;
            bool esValido;
            bool esNum;
            int min = 0, max = 0;
            int flag = 0; 
            float acumulador = 0; 
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingresar un numero entre -100 y 100: ");
                esNum = int.TryParse(Console.ReadLine(), out valor);
                esValido = Validacion.Validar(valor, -100, 100);
                while (!esValido)
                {
                    Console.WriteLine("Numero invalido.\nPara continuar, ingresar un numero entre -100 y 100: ");
                    esNum = int.TryParse(Console.ReadLine(), out valor);
                    esValido = Validacion.Validar(valor, -100, 100);
                }                    
                if(flag == 0)
                {
                    min = valor;
                    max = valor;
                    acumulador += valor;
                    flag++;                        
                }
                else
                {
                    if (valor < min)
                        min = valor;
                    if (valor > max)
                        max = valor;

                    acumulador += valor;
                }
             }
            Console.WriteLine("Minimo = "+min+"\nMaximo = "+max+"\nPromedio = "+acumulador/10);
            Console.ReadKey();

        }
    }
}
