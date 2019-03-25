using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora01
{
    public partial class Form1 : Form
    {
        Calculadora calc;

        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calc = new Calculadora();
        }

        private bool CapturaDatos()
        {
            if (string.IsNullOrWhiteSpace(primerValorTxt.Text) || string.IsNullOrWhiteSpace(segundoValorTxt.Text))
                return false;

            calc.valor1 = int.Parse(primerValorTxt.Text);
            calc.valor2 = int.Parse(segundoValorTxt.Text);
                        
            return true;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if(CapturaDatos())
                resultadoTxt.Text = calc.Sumar(calc.valor1, calc.valor2).ToString();            
        }        

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (CapturaDatos())
                resultadoTxt.Text = calc.Restar(calc.valor1, calc.valor2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (CapturaDatos())
                resultadoTxt.Text = calc.Multiplicar(calc.valor1, calc.valor2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (CapturaDatos())
                resultadoTxt.Text = calc.Dividir(calc.valor1, calc.valor2).ToString();
        }
    }
}
