using System;
using System.Windows.Forms;

namespace Exercicio65 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            MessageBox.Show("A raiz quadrada da soma dos quadrados é: " + SumRaizQuadrada(n1, n2));
        }

        private double SumRaizQuadrada(double n1, double n2) {
            double somaQuadrados = n1 + n2;
            return Math.Sqrt(somaQuadrados);
        }
    }
}
