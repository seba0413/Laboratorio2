using System;
using System.Collections.Generic;
using System.Text;

namespace Clase4Programacion
{
    class Sobrecarga
    {
        public string tipoNumero;

        public Sobrecarga(string tipo)
        {
            tipoNumero = tipo;            
        }

        public Sobrecarga():this("Metro")
        {
        }


    }
}
