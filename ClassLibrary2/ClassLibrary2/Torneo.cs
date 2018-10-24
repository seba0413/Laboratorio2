using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        public Torneo(string nombre)
        {
            this.nombre = nombre;
            equipos = new List<T>();
        }

        public string JugarPartido
        {
            get
            {
                Random rdn = new Random();
                int indice1 = rdn.Next(this.equipos.Count);
                System.Threading.Thread.Sleep(500);
                Random rdn2 = new Random();
                int indice2 = rdn2.Next(this.equipos.Count);
                while(indice1 == indice2)
                    indice2 = rdn.Next(this.equipos.Count);

                string resultado = this.CalcularPartido(this.equipos[indice1], this.equipos[indice2]);

                return resultado;
            }
        }
        
        public static bool operator == (Torneo<T> torneo, T equipo)
        {
            bool esta = false;
            foreach(T auxEquipo in torneo.equipos)
            {
                if(auxEquipo == equipo)
                {
                    esta = true;
                    break;
                }
            }

            return esta;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static Torneo<T> operator + (Torneo<T> torneo, T equipo)
        {
            if(torneo != equipo)            
                torneo.equipos.Add(equipo);            

            return torneo; 
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre del torneo: {0}\n", this.nombre);
            foreach(T equipo in this.equipos)
            {
                sb.AppendLine(equipo.Ficha());
            }
            return sb.ToString();
        }

        private string CalcularPartido(T equipo1, T equipo2) 
        {
            Random rnd = new Random();
            int golesEquipo1 = rnd.Next(100);
            System.Threading.Thread.Sleep(500);
            Random rnd2 = new Random();
            int golesEquipo2 = rnd2.Next(100);

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} {1} - {2} {3}", equipo1.Nombre, golesEquipo1, golesEquipo2, equipo2.Nombre);

            return sb.ToString();
        }


            
    }
}
