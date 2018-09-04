using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio20
{
    class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Dolar()
        {
            cotizRespectoDolar = 1;

        }

        public Dolar(double cantidad):this()
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion)
        {
            this.cantidad = cantidad;
            cotizRespectoDolar = cotizacion;
        }

        public double getCantidad()
        {
            return this.cantidad;
        }

        public static float getCotizacion()
        {
            return cotizRespectoDolar;
        }


    }
}
