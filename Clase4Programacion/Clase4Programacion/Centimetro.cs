using System;
using System.Collections.Generic;
using System.Text;

namespace Clase4Programacion
{
    class Centimetro
    {
        public double valor;

        public Centimetro(double valor)
        {
            this.valor = valor;          
        }

        public static bool operator ==(Centimetro centimetroUno, Centimetro centimetroDos)
        {
            return centimetroUno.valor == centimetroDos.valor;
        }

        public static bool operator !=(Centimetro centimetroUno, Centimetro centimetroDos)
        {
            return !(centimetroUno.valor == centimetroDos.valor);
        }

        public static Centimetro operator + (Centimetro centimetro, Centimetro centimetroDos)
        {
            centimetro.valor += centimetroDos.valor;
            return centimetro;
        }


    }
}
