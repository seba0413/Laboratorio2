using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio20
{
    class Pesos
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Pesos()
        {
            cotizRespectoDolar = (float) 17.55;
        }

        public Pesos(double cantidad):this()
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion)
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

        public static Pesos operator +(Pesos peso1, Pesos peso2)
        {
            peso1.cantidad += peso2.cantidad;
            return peso1;
        }

        public static implicit operator Pesos(Dolar dolar)
        {
            return new Pesos(dolar.getCantidad() * cotizRespectoDolar);
        }
    }
    
}
