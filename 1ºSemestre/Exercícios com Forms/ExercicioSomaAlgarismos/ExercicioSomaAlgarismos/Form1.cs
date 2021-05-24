using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioSomaAlgarismos
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int numero = Math.Abs(int.Parse(textBox1.Text));
            int soma = 0;

            while(numero > 0) {
                soma += numero % 10;
                numero = numero / 10;
            }

            MessageBox.Show("A soma dos algarismos é " + soma);
        }
    }
}
