using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora01
{
    class Calculadora
    {
        public double valor1;
        public double valor2;

        public double Sumar(double a, double b) => a + b;
        public double Restar (double a, double b) => a - b;
        public double Multiplicar (double a, double b) => a * b;
        public double Dividir(double a, double b)
        {
            var result = 0d;
            if (b != 0)
                return a / b;
            return result;  
        }   

        

    }
}
