using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorteo
{
    public partial class Form1 : Form
    {
        private SorteoModel juego = new SorteoModel();

        public Form1()
        {
            InitializeComponent();
        }

        private void añadirButton_Click(object sender, EventArgs e)
        {
            juego.Anadir(anadirButton.Text);

            for (int n = 0; n < juego.ListaNombres.Count; n++)
            {
                nombresListBox.Items.Add(juego.ListaNombres[n]);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int pos = nombresListBox.SelectedIndex;
        }

        private void suerteButton_Click(object sender, EventArgs e)
        {
            int afortunado = juego.Sortear();
        }
    }
}
