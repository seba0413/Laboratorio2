using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;



namespace AtencionAlCliente
{
    public enum EPuesto
    {
        Caja1,
        Caja2
    }

    public class PuestoAtencion
    {
        private static int numeroActual;
        private EPuesto puesto;

        private PuestoAtencion()
        {
            numeroActual = 0; 
        }

        public PuestoAtencion(EPuesto puesto):this()
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            get
            {
                numeroActual++;
                return numeroActual;
            }
        }

        public bool Atender(Cliente cli)
        {            
            Random r = new Random();
            int aleatorio = r.Next(1000, 5000);
            Thread.Sleep(aleatorio);
            return true;
        }
    }
}
