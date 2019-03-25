using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo01
{
    public partial class Form1 : Form
    {
        JuegoModel jm = new JuegoModel();

        public Form1()
        {
            InitializeComponent();
            jm.Reset();
           

        }

        private void solicitarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int guess = int.Parse(textBox.Text);
                string resultado = jm.Apostar(guess);
                outputLabel.Text = resultado;

            }
            catch (Exception ex)
            {
                outputLabel.Text = "Mete un numerico válido, anda, majo...";
            }
            
        }
    }
}
