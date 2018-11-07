using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Ejercicio64
{
    public class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            Negocio negocio = new Negocio(caja1, caja2);

            negocio.Clientes.Add("cliente1");
            negocio.Clientes.Add("cliente2");
            negocio.Clientes.Add("cliente3");
            negocio.Clientes.Add("cliente4");
            negocio.Clientes.Add("cliente5");
            negocio.Clientes.Add("cliente6");
            negocio.Clientes.Add("cliente7");
            negocio.Clientes.Add("cliente8");

            Thread t1 = new Thread(caja1.AtenderClientes);
            Thread t2 = new Thread(caja2.AtenderClientes);
            Thread t3 = new Thread(negocio.AsignarCaja);

            t3.Start();
            t3.Join();
            t1.Name = "Caja 1";
            t1.Start();
            t2.Name = "Caja 2";
            t2.Start();

            Console.ReadKey();


        }
    }
}
