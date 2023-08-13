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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BlAgregar_Click(object sender, EventArgs e)
        {///Para cuando ahi una lista no se repita el usuario ---------------------------------
            bool repetido = false;
            foreach (string nombreLis1 in listBox1.Items)
            {
                if (nombreLis1.Trim().ToUpper() == textBox1.Text.Trim().ToUpper()){ repetido = true; }
            }

            foreach (string nombreLis2 in listBox2.Items)
            {
                if (nombreLis2.Trim().ToUpper() == textBox1.Text.Trim().ToUpper()) { repetido = true; }
            }

            if (textBox1.Text.Trim().Length != 0  && repetido==false)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
            else if(repetido == true) 
            {
                MessageBox.Show("Nombre repetido. ingrese Un Nombre nuevo", "ATENCION"); 
            }
            else
            {
                MessageBox.Show("Ingrese Un Nombre", "ATENCION");
            }
            ///------------------------------------------------------------------------
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
             {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else 
            {
                MessageBox.Show("No ahi nombres registrados", "atencion");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {///// Pasar de una lista a otra 
            if (listBox1.Items.Count != 0)
            {
                listBox2.Items.Clear();
                foreach (string list in listBox1.Items)
                {
                    listBox2.Items.Add(list);
                }
                listBox1.Items.Clear();
            }
            else
            {
                MessageBox.Show("Lista Vacia", "Atencion");
            }
        }
    }
}
