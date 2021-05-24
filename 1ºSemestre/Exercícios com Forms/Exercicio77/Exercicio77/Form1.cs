using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio77 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int num = int.Parse(textBox1.Text);
            simetrico(ref num);
            MessageBox.Show("O número simétrico do número introduzido é: " + num);
        }

        void simetrico(ref int n1)
        {
            n1 = -n1;
        }

    }
}
