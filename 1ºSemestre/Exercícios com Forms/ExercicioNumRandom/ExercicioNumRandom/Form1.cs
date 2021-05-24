using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Este programa dá uma sequência de 10 números aleatórios inteiros e decimais
namespace ExercicioNumRandom
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Random aleatorio = new Random();
            label1.Text = "";
            label2.Text = "";

            for (int i = 0; i < 10; i++) {
                label1.Text += "\n" + aleatorio.Next(10, 100);
            }

            for (int i = 0; i < 10; i++) {
                label2.Text += "\n" + aleatorio.NextDouble();
            }

        }
    }
}
