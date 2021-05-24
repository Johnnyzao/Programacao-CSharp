using System;
using System.Windows.Forms;

namespace Exercicio72 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (m1(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text)))
                MessageBox.Show("A sequência está certa");
            else
                MessageBox.Show("A sequência não está certa");
        }
        private bool m1(int a, int b, int c) {
            if (a > b && b > c)
                return true;
            return false;
        }
    }
}
