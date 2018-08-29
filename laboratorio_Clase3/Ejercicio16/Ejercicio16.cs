using System;

namespace Ejercicio16
{
    class Ejercicio16
    {
        static void Main(string[] args)
        {
            Alumno student1 = new Alumno();
            student1.nombre = "Elias";
            student1.apellido = "Pereyra";
            student1.legajo = 183;
            student1.Study(1, 2);
            student1.calculateFinal();

            Alumno student2 = new Alumno();
            student2.nombre = "Victor";
            student2.apellido = "Salazar";
            student2.legajo = 184;
            student2.Study(4, 6);
            student2.calculateFinal();

            Alumno student3 = new Alumno();
            student3.nombre = "Nicolas";
            student3.apellido = "Reniero";
            student3.legajo = 185;
            student3.Study(10, 10);
            student3.calculateFinal();

            Console.WriteLine(student1.Mostrar());
            Console.WriteLine(student2.Mostrar());
            Console.WriteLine(student3.Mostrar());


            Console.ReadKey();
        }
    }
}
