using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora01
{
    public class Calculadora2
    {
        public double valor1;
        public double valor2;

        public bool usaMemoria = false;
        public double memoria;       
        
        public delegate double Funcion (double a, double b);

        public double Sumar(double a, double b)
        {
            if (usaMemoria)
                a = memoria;
            var result = a + b;
            memoria = result;

            return result;
        }

        public double Restar(double a, double b)
        {
            if (usaMemoria)
                a = memoria;
            var result = a - b;
            memoria = result;

            return result;
        }

        public double Multiplicar(double a, double b)
        {
            if (usaMemoria)
                a = memoria;
            var result = a * b;
            memoria = result;

            return result;
        }

        public double Dividir(double a, double b) 
        {                         
            if (usaMemoria)
                a = memoria;
            var result = a / b;
            memoria = result;

            return result;
        }       

        public double Calcular(double v1, double v2, Funcion f)
        {
            double resultado = 0d;
                
            resultado = f(v1, v2);
        
            return resultado;
        }

        public void Reset()
        {
            valor1 = 0;
            valor2 = 0;
            memoria = 0;
        }
    }  
}
