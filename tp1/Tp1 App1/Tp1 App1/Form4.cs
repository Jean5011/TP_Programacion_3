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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///
            if (checkedListBox1.CheckedItems.Count == 0) MessageBox.Show("Ingrese el oficio", "Atencion");
            else
            {
                label1.Text = "Usted selecciono los siguientes elementos";
                label4.Text = "Oficio:";
                if (radioButton1.Checked) label2.Text = "Sexo: " + radioButton1.Text;
                else if (radioButton2.Checked) label2.Text = "Sexo: " + radioButton2.Text;
                else MessageBox.Show("Eliga uno de los dos sexos");
                ///
                if (radioButton3.Checked) label3.Text = "Estado civil: " + radioButton3.Text;
                else if (radioButton4.Checked) label3.Text = "Estado civil: " + radioButton4.Text;
                else MessageBox.Show("Eliga uno de los dos Estados civiles");
                ///
                textBox1.Text = "";
                foreach (string aux in checkedListBox1.CheckedItems)
                {
                    textBox1.SelectedText = aux + "\r\n";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
