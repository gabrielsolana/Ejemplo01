using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora01
{
    public partial class Calculadora : Form
    {       
        private Calculadora2 calc;
        private string[] operandos;

        private Calculadora2.Funcion operacionEnCurso;
              
        public Calculadora()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calc = new Calculadora2();                
        }

        private void CapturaOperandos()
        {
            char[] operaciones = { '+', '-', 'x', '/' };
            operandos = PantallaTxt.Text.Split(operaciones, StringSplitOptions.RemoveEmptyEntries);    

            calc.valor1 = double.Parse(operandos[0]);
            calc.valor2 = double.Parse(operandos[1]);
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {            
            // calc.operacion = OperacionEnCurso.Sumar;
            operacionEnCurso = calc.Sumar;
            PantallaTxt.Text += " + ";
        }        

        private void btnRestar_Click(object sender, EventArgs e)
        {
            //calc.operacion= OperacionEnCurso.Restar;
            operacionEnCurso = calc.Restar;
            PantallaTxt.Text += " - ";            
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //calc.operacion = OperacionEnCurso.Multiplicar;
            operacionEnCurso = calc.Multiplicar;
            PantallaTxt.Text += " x ";
        }       

        private void btnDividir_Click(object sender, EventArgs e)
        {
            //calc.operacion = OperacionEnCurso.Dividir; 
            operacionEnCurso = calc.Dividir;
            PantallaTxt.Text += " / ";
        }

        private void btnMemoria_Click(object sender, EventArgs e)
        {
            calc.usaMemoria = !calc.usaMemoria;
            PantallaTxt.Text = calc.memoria.ToString();
            CambiarColorBoton(btnMemoria);
        }       
       
        private void buttonnumero_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            PantallaTxt.Text += button.Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            CapturaOperandos();
            PantallaTxt.Text += " = ";
            // PantallaTxt.Text += calc.Calcular(calc.valor1, calc.valor2).ToString();
            PantallaTxt.Text += calc.Calcular(calc.valor1, calc.valor2, operacionEnCurso).ToString();
            
            btnMemoria.BackColor = Color.Cornsilk;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            PantallaTxt.Text = "";
            calc.Reset();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CambiarColorBoton(Button button)
        {
            if (button.BackColor == Color.Cornsilk)
                button.BackColor = Color.BlueViolet;
            else
                button.BackColor = Color.Cornsilk;
        }

       
    }
}
