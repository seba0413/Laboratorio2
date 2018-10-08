using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Divisiones division; 

        public Alumno(string nombre, string apellido, string documentacion, short anio, Divisiones division):base(nombre, apellido, documentacion)
        {
            this.anio = anio;
            this.division = division;
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

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Alumno:");
            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine(this.AnioDivision);

            return sb.ToString();
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool valida = true;

            if (doc.Length != 9)
                valida = false;

            else
            {
                int numero;
                bool esNum;

                for(int i = 0; i<doc.Length; i++)
                {
                    esNum = int.TryParse(doc[i].ToString(), out numero);

                    if(!esNum)
                    {
                        if (doc[i] != '-')
                        {
                            valida = false;
                            break;
                        }
                        else
                        {
                            if(i != 2)
                            {
                                if(i != 7)
                                {
                                    valida = false;
                                    break; 
                                }                                
                            }
                        }
                    }
                }                
            }
            return valida; 
        }
    }
}
