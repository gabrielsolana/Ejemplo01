using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo01
{
    
    class JuegoModel
    {
        Random random = new Random();

        public int numero;

        public void Reset()
        {
            numero = random.Next(0, 10);
        }

        public string Apostar(int valor)
        {
            string result="";

            if (valor > numero)
            {
                result = "El número es más bajo";
            }
            else if (valor < numero)
            {
                result = "El número es más alto";
            }
            else
            {
                result = "Acertaste, piltrafa!";
                Reset();
            }
            return result;
        }
    }
}
