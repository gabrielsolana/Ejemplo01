using System;

namespace CalculadoraOOP
{
    public class Calculadora
    {
        public char[] Memoria;
        public bool UsaMemoria = false;

        public delegate double Funcion(double a, double b);

        private Funcion ultimaFuncion;

        public double Resultado()
        {
            var calculo = 0d;
            for (var i = 0; i < Memoria.Length; i = i + 2)
            {
                switch (Memoria[i+1])
                {
                    case '+':
                        ultimaFuncion = Sumar;
                        break;
                    case '-':
                        ultimaFuncion = Restar;
                        break;
                    case 'x':
                        ultimaFuncion = Multiplicar;
                        break;
                    case '/':
                        ultimaFuncion = Dividir;
                        break;
                }
                calculo += HacerCuentas(Memoria[i], Memoria[i + 2], ultimaFuncion);
            }
            return calculo;
        }

        public double Sumar (double a, double b) => a + b;
        public double Restar (double a, double b) => a - b;
        public double Multiplicar (double a, double b) => a * b;
        public double Dividir (double a, double b) => a / b;

        public double HacerCuentas(double a, double b, Funcion f)
        {
            double resultado = 0;
            if (ultimaFuncion != null)
            {
                resultado = ultimaFuncion.Invoke(a, b);
            }

            ultimaFuncion = f;
            return resultado;
        }

        public void Reset()
        {
            Array.Clear(Memoria, 0, Memoria.Length);
            UsaMemoria = false;
        }
    }
}