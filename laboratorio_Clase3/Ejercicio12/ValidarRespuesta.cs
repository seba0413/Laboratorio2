using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio12
{
    public class ValidarRespuesta
    {       
        public static bool ValidaSN(char answer)
        {
            bool isValid = false;

            if (answer == 's')
                isValid = true;

            return isValid;
        }
    }
}
