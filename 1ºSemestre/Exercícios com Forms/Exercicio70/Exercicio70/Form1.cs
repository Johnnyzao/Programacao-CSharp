using System;
using System.Windows.Forms;

namespace Exercicio70 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int n = int.Parse(textBox1.Text);
            MessageBox.Show("O número é: " + fibonacci(n));
        }

        int fibonacci(int n) {
            int num1 = 1;
            int num2 = 2;
            int fibo = num1 + num2;

            do {
                fibo = num1 + num2;
                num1 = num2;
                num2 = fibo;
            } while (fibo < n);

            return fibo;
        }
    }
}
