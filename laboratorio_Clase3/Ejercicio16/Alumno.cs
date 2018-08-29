using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio16
{
    public class Alumno
    {
        private byte note;
        private byte note2;
        private float finalNote;
        public string apellido;
        public string nombre;
        public int legajo;

        public void calculateFinal()
        {
            if (this.note >= 4 && this.note2 >= 4)
            {
                Random finalNoteValue = new Random();
                this.finalNote = finalNoteValue.Next(1, 10);
            }
            else
            {
                this.finalNote = -1;
            }
        }

        public void Study(byte firstNote, byte secondNote)
        {
            this.note = firstNote;
            this.note2 = secondNote;
        }

        public string Mostrar()
        {
            /*string studentData;
            if (this.finalNote == -1)
            {
                studentData = "Nombre: " + this.nombre + "\nApellido: " + this.apellido + "\nLegajo: " + this.legajo +
                "\nNota 1: " + this.note + "\nNota 2: " + this.note2 + "\nFinal: Alumno desaprobado";
            }
            else
            {
                studentData = "Nombre: " + this.nombre + "\nApellido: " + this.apellido + "\nLegajo: " + this.legajo +
               "\nNota 1: " + this.note + "\nNota 2: " + this.note2 + "\nFinal: " + this.finalNote;
            }*/

            string studentData;
            if (this.finalNote == -1)
            {
                studentData = String.Format("Nombre: {0} \nApellido: {1} \nLegajo: {2}\nNota 1: {3}\nNota 2: {4}" +
                    "\nFinal: Alumno desaprobado\n", this.nombre, this.apellido, this.legajo, this.note, this.note2);
            }
            else
            {
                studentData = String.Format("Nombre: {0} \nApellido: {1} \nLegajo: {2}\nNota 1: {3}\nNota 2: {4} " +
                    "\nFinal: {5}\n", this.nombre, this.apellido, this.legajo, this.note, this.note2, this.finalNote);
            }
            return studentData;
        }
    }
}
