using System;
using System.Text.RegularExpressions;

namespace CalculadoraOOP
{
    public class ExpresionMatematica
    {
        public string InputExpresion;

        public bool SoyValida(string input)
        {
            string expresionValida = @"^(\d+\+)+$";
            Regex rx = new Regex(expresionValida);
            
            return rx.IsMatch(input);

        }
     
        public char[] Output(string input)
        {
            return input.ToCharArray();
        }

    }
}