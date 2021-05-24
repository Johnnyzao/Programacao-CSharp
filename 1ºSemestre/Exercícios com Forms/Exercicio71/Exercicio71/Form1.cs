using System;
using System.Windows.Forms;

namespace Exercicio71 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int num = int.Parse(textBox1.Text);
            MessageBox.Show("A soma dos algarismos é: " + somaAlgarismos(num));

        }
        private int somaAlgarismos(int n) {
            int numero = Math.Abs(n);
            int soma = 0;
            while (numero > 0) {
                soma += numero % 10;
                numero = numero / 10;
            }
            return soma;
        }
    }
}
