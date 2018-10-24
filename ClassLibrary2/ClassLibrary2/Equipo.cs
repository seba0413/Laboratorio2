using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }
        
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public virtual string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} fundado el {1}", this.nombre, this.fechaCreacion.ToString());
            return sb.ToString();            
        }
         
        public static bool operator ==(Equipo equipo1, Equipo equipo2)
        {
            return (equipo1.Nombre == equipo2.Nombre && equipo1.fechaCreacion == equipo2.fechaCreacion);
        }

        public static bool operator !=(Equipo equipo1, Equipo equipo2)
        {
            return !(equipo1 == equipo2);
        }


    }
}

