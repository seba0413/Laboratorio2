using System;
using System.Collections.Generic;
using System.Text;

namespace Clase4Programacion
{
    class Metro
    {
        public double valor;

        public Metro(double valor)
        {
            this.valor = valor;
        }

        public static Metro operator + (Metro valor1, Centimetro valor2)
        {
            valor1.valor += (valor2.valor / 100);

            return valor1;
        }

        public static bool operator == (Metro metroUno, Metro metroDos)
        {
            return metroUno.valor == metroDos.valor;
        }

        public static bool operator !=(Metro metroUno, Metro metroDos)
        {
            return !(metroUno.valor == metroDos.valor);
        }
    }
}
