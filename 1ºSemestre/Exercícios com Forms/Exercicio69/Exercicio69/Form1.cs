using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio69 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            if (SaoDivisiveis(n1, n2))
                MessageBox.Show("Os números são divisíveis");
            else
                MessageBox.Show("Os números não sao divisíveis");

        }
        private bool SaoDivisiveis(int n1, int n2) {
            bool saoDivisiveis = false;
            if (n1 % n2 == 0 || n1 % n2 == 0)
                saoDivisiveis = true;
            return saoDivisiveis;
        }
    }
}
