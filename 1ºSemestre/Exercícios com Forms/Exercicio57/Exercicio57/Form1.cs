using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio57
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            Random numAleatorio = new Random();
            label1.Text = numAleatorio.NextDouble().ToString();
        }
    }
}
