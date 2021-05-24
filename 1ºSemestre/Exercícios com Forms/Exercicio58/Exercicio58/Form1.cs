using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio58
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int numeroAleatorio = 0;
        public Form1() {
            InitializeComponent();
            numeroAleatorio = random.Next(0, 10000);
        }

        private void button1_Click(object sender, EventArgs e) {
            int adivinha = int.Parse(textBox1.Text);

            if (adivinha > numeroAleatorio)
                MessageBox.Show("O número é menor que o introduzido");
            else if (adivinha < numeroAleatorio)
                MessageBox.Show("O número é maior que o introduzido");
            else if (adivinha == numeroAleatorio) {
                MessageBox.Show("Acertou no número");
                Application.Exit();
            }


        }
    }
}
