using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio67 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            MessageBox.Show("O número de primos é: " + contaPrimos(n1, n2));
        }

        private int contaPrimos(int n1, int n2) {
            int min = Math.Min(n1, n2);
            int max = Math.Max(n1, n2);
            int contador = 0; 
            for(int i = min; i <= max; i++) {
                bool primo = true;
                for(int j = 2; j < i; j++) {
                    if (i % j == 0)
                        primo = false;
                }
                if (primo)
                    contador++;
            }
            return contador;
        }
    }
}
