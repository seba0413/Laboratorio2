using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Superliga");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("LNB");

            DateTime fecha1 = new DateTime(1908, 4, 10);
            DateTime fecha2 = new DateTime(1906, 11, 4);
            DateTime fecha3 = new DateTime(1902, 3, 5);
            DateTime fecha4 = new DateTime(1911, 2, 12);
            DateTime fecha5 = new DateTime(1915, 6, 22);
            DateTime fecha6 = new DateTime(1922, 9, 19);

            EquipoFutbol futbol1 = new EquipoFutbol("San Lorenzo", fecha1);
            EquipoFutbol futbol2 = new EquipoFutbol("Chacarita", fecha2);
            EquipoFutbol futbol3 = new EquipoFutbol("Aldosivi", fecha3);

            EquipoBasquet basquet1 = new EquipoBasquet("Obras", fecha4);
            EquipoBasquet basquet2 = new EquipoBasquet("Atenas", fecha5);
            EquipoBasquet basquet3 = new EquipoBasquet("San Andres", fecha6);

            torneoFutbol += futbol1;
            torneoFutbol += futbol2;
            torneoFutbol += futbol3;

            torneoBasquet += basquet1;
            torneoBasquet += basquet2;
            torneoBasquet += basquet3;

            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine("-----------------------");
            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine("-----------------------");
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);

            Console.ReadKey();


        }
    }
}
