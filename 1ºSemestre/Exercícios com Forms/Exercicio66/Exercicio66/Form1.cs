using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio66 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int num = int.Parse(textBox1.Text);
            MessageBox.Show("O número primo mais próximo é: " + primoMaisProx(num));
        }

        private int primoMaisProx(int num) {
            bool encontrouPrimo = false;
            while (!encontrouPrimo) {
                num -= 1;
                bool primo = true;
                for (int i = 2; i < num; i++) {
                    if (num % i == 0)
                        primo = false;
                }
                if (primo)
                    encontrouPrimo = true;
            }
            return num;
        }
    }
}
