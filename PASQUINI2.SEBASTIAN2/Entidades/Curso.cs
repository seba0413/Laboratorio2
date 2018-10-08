using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        private Curso()
        {
            alumnos = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor):this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public string AnioDivision
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(this.anio);
                sb.Append("º");
                sb.Append(this.division);

                return sb.ToString();
            }
        }

        public static explicit operator string (Curso curso)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(curso.AnioDivision);
            sb.AppendLine(curso.profesor.ExponerDatos());
            foreach (Alumno alumno in curso.alumnos)
                sb.AppendLine(alumno.ExponerDatos());

            return sb.ToString();
        }

        public static bool operator == (Alumno alumno, Curso curso)
        {
            return (alumno.AnioDivision == curso.AnioDivision);
        }

        public static bool operator !=(Alumno alumno, Curso curso)
        {
            return !(alumno == curso);
        }
        public static Curso operator +(Curso curso, Alumno alumno)
        {
            if (alumno == curso)
                curso.alumnos.Add(alumno);

            return curso;
        }

    }
}
