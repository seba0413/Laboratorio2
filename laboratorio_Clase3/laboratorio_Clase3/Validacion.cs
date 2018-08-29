using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorio_Clase3
{
    class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool esValido = false;

            if (valor >= min && valor <= max)
                esValido = true;

            return esValido;
        }

    }
}
