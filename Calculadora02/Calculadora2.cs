using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora01
{
    class Calculadora2
    {
        public double valor1;
        public double valor2;

        public bool usaMemoria = false;
        public double memoria;

        public OperacionEnCurso operacion;              

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

        public double Calcular()
        {
            double resultado = 0d;
            switch (operacion)
            {               
                case (OperacionEnCurso.Sumar):
                    resultado = Sumar(valor1, valor2);
                    break;
                    
                case (OperacionEnCurso.Restar):
                    resultado = Restar(valor1, valor2);
                    break;
                case (OperacionEnCurso.Multiplicar):
                    resultado = Multiplicar(valor1, valor2);
                    break;
                case (OperacionEnCurso.Dividir):
                    resultado = Dividir(valor1, valor2);
                    break;
            }
            return resultado;
        }

        public void Reset()
        {
            valor1 = 0;
            valor2 = 0;
            memoria = 0;
            operacion = OperacionEnCurso.Reposo;
        }
    }
    public enum OperacionEnCurso
    {
        Reposo,
        Sumar,
        Restar,
        Multiplicar,
        Dividir
    };
}
