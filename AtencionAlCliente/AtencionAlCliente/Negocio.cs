using System;
using System.Collections.Generic;
using System.Text;

namespace AtencionAlCliente
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(EPuesto.Caja1);
        }

        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }

            set
            {
                bool agregado = this + value;
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }
       

        public static bool operator +(Negocio n, Cliente c)
        {
            bool seAgrego = false;

            if (n == c)
                return seAgrego;

            n.clientes.Enqueue(c);
            seAgrego = true;

            return seAgrego;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool seEncontro = false;

            foreach (Cliente cliente in n.clientes)
            {
                if (cliente == c)
                {
                    seEncontro = true;
                    break;
                }
            }

            return seEncontro;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator ~(Negocio n)
        {
            bool realizo = false; 
            Cliente cliente;           
            cliente = n.Cliente;
            realizo = n.caja.Atender(cliente);       
            return realizo; 
        }
    }
}
