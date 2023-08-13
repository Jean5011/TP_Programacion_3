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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        bool VerificarPersona(string Persona)
        {
            foreach(string aux in listBox1.Items)
            {
                if (Persona.Trim().ToUpper() == aux.Trim().ToUpper()) return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Persona  = textBox1.Text +" "+ textBox2.Text;

            if (VerificarPersona(Persona))
            {
                MessageBox.Show("Nombre y Apellido exitete", "Atencion");
            }
            else
            {
                listBox1.Items.Add(Persona); 
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
