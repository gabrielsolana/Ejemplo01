using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraOOP
{
    public partial class CalculadoraForms : Form
    {
        

        private Calculadora calc;
        private ExpresionMatematica em;

        public CalculadoraForms()
        {
            InitializeComponent();
            calc = new Calculadora();
            em = new ExpresionMatematica();

            pantallaTextBox.ReadOnly = true;
            
        }

        private void Calculadora_Load(object sender, EventArgs e) { }

        private void btnInput_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            pantallaTextBox.Text += button.Text;
        }

        private void pantallaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (em.SoyValida(pantallaTextBox.Text))
            {
                em.InputExpresion = pantallaTextBox.Text;
            }
            else
            {
                lblWarning.Text = "Expresion incorrecta... corrige";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            calc.Memoria = em.Output(pantallaTextBox.Text);
            pantallaTextBox.Text += $@"= {calc.Resultado()}";
        }

        private void btnReset_Click(object sender, EventArgs e) => pantallaTextBox.Clear();

        private void btnMemo_Click(object sender, EventArgs e) => calc.UsaMemoria = true;

        private void btnBorrar_Click(object sender, EventArgs e) => BorrarUnCaracter();

        private void btnSalir_Click(object sender, EventArgs e) => Application.Exit();

        private void BorrarUnCaracter()
        {
            if (pantallaTextBox.TextLength > 0)
            {
                pantallaTextBox.Text = pantallaTextBox.Text.Substring(0, pantallaTextBox.Text.Length - 1);
            }
        }
    }

    
}
