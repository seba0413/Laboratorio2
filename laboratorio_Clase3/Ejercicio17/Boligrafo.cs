using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio17
{
    class Boligrafo
    {
        public short cantidadTintaMaxima;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {

        }

        public ConsoleColor GetColor()
        {            
            ConsoleColor color = ConsoleColor.Black;
            Console.ForegroundColor = color;
            return color;
        }
    }
}
