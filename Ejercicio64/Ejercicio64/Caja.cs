using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio64
{
    public class Caja
    {
        private List<String> filaClientes;

        public Caja()
        {
            filaClientes = new List<string>();
        }

        public List<String> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }

        public void AtenderClientes()
        {
            foreach(string cliente in filaClientes)
            {
                Console.WriteLine(String.Format("{0}, Cliente {1}\n", Thread.CurrentThread.Name, cliente));
                Thread.Sleep(2000);
            }
        }
    }
}
