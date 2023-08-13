using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp1_App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EJERCICIO_1(object sender, EventArgs e)
        {/// Para abrir otras ventanas
            Form2 ej1 = new Form2();
            ej1.ShowDialog();
        }

        private void EJERCICO_2(object sender, EventArgs e)
        {
            Form3 ej2 = new Form3();
            ej2.ShowDialog();
        }

        private void EJERCICIO_3(object sender, EventArgs e)
        {
            Form4 ej3 = new Form4();
            ej3.ShowDialog();
        }
    }
}
