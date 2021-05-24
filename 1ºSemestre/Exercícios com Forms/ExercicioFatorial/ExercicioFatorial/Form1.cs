using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioFatorial
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int numero = int.Parse(textBox1.Text);
            int fatorial = 1;
            for (int i=2; i<=numero; i++) {
                fatorial *= i;
            }
            MessageBox.Show("O fatorial do número é " + fatorial);
        }
    }
}
