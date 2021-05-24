using System;
using System.Windows.Forms;

namespace Exercicio74 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int numInt = int.Parse(textBox1.Text);
            if (numInt <= 0) {
                MessageBox.Show("Introduza um número superior a 0!");
            } else {
                label2.Text = nesimoPrimo(numInt).ToString();
            }

            int nesimoPrimo(int n) {
                int contador = 0;
                int numeroATestar = 1;
                while(contador != n) {
                    numeroATestar++;
                    bool primo = true;
                    for(int i = 2; i < numeroATestar; i++) {
                        if (numeroATestar % i == 0)
                            primo = false;
                    }
                    if (primo)
                        contador++;
                }
                return numeroATestar;
            }
        }
    }
}
