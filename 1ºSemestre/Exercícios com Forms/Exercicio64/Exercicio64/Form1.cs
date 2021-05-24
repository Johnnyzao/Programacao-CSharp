using System;
using System.Windows.Forms;

namespace Exercicio64 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            double n3 = double.Parse(textBox3.Text);
            MessageBox.Show("O número maior absoluto é: " + returnMaior(n1, n2, n3));
        }

        private double returnMaior(double n1, double n2, double n3) {
            n1 = Math.Abs(n1);
            n2 = Math.Abs(n2);
            n3 = Math.Abs(n3);
            double maior = Math.Max(n1, n2);
            return Math.Max(maior, n3);
        }
    }
}
