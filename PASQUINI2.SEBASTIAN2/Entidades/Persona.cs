using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string documento; 

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Documento = documento;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public string Documento
        {
            get
            {
                return this.documento;
            }

            set
            {
                bool validar = ValidarDocumentacion(value);
                if (validar)
                    this.documento = value; 
            }
        }

        protected abstract bool ValidarDocumentacion(string doc);

        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Nombre);
            sb.AppendLine(this.Apellido);
            sb.AppendLine(this.Documento);

            return sb.ToString(); 
        }


    }
}
