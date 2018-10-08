using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        public Profesor(string nombre, string apellido, string documento) : base(nombre, apellido, documento) { }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso) : base(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        public int Antiguedad
        {
            get
            {
                TimeSpan ts = new TimeSpan();
                ts = DateTime.Now - this.fechaIngreso;
                int dias = ts.Days;

                return dias;
            }
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool valida = true;

            if (doc.Length != 8)
                valida = false;

            return valida;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Profesor:");
            sb.AppendLine(base.ExponerDatos());
            sb.AppendFormat("Antiguedad: {0} dias", this.Antiguedad.ToString());

            return sb.ToString();
        }
    }
}
