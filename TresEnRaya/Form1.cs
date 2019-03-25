using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TresEnRaya
{
    public partial class Form1 : Form
    {
        private TresEnRaya tres;

        

        public Form1()
        {
            InitializeComponent();
            tres = new TresEnRaya();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tres.reset();
        }
    }
}
