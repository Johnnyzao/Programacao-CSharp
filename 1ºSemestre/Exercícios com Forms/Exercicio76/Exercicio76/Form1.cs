using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio76 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            int n3 = int.Parse(textBox3.Text);
            alteraNums(ref n1, ref n2, ref n3);
            label1.Text = n1 + "\n" + n2 + "\n" + n3;
        }

        void alteraNums(ref int n1, ref int n2, ref int n3) {
            int maior = Math.Max(n1, n2);
            maior = Math.Max(n3, maior);
            n1 = n2 = n3 = maior;
        }
    }
}
