using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversao_de_Graus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double f = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString((f * 1.8 + 32));
            MessageBox.Show("Fahrenheit: " + textBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double k = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString((k + 273.15));
            MessageBox.Show("Kelvin: " + textBox2);
        }
    }
}
