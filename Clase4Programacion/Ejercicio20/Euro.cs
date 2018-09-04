using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio20
{
    class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;
         
        private Euro()
        {
            cotizRespectoDolar = (float) 1.3642;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion)
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
