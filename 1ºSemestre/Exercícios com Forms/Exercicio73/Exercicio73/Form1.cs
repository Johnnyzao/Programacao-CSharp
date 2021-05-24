using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio73 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int num = int.Parse(textBox1.Text);
            if (isPrimo(num))
                MessageBox.Show("O número é primo");
            else
                MessageBox.Show("O número não é primo");

        }
        private bool isPrimo(int num) {
            bool primo = true; 
            for(int i = 2; i<num; i++) {
                if (num % i == 0)
                    primo = false;
            }
            return primo;
        }
    }
}
