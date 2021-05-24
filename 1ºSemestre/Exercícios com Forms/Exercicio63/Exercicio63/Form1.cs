using System;
using System.Windows.Forms;

namespace Exercicio63 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            MessageBox.Show("A soma é: " + somaNums(int.Parse(textBox2.Text), int.Parse(textBox2.Text)).ToString());
        }

        private int somaNums(int num1, int num2) {
            int soma = num1 + num2;
            if (soma <= 0)
                return 0;
            return soma;
        }
    }
}
