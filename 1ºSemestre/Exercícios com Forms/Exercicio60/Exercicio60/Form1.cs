using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio60
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int contador = 0;
        int certas = 0;
        public Form1() {
            InitializeComponent();
            lbNum1.Text = rand.Next(1, 11).ToString();
            lbNum2.Text = rand.Next(1, 11).ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            int num1 = int.Parse(lbNum1.Text);
            int num2 = int.Parse(lbNum2.Text);
            int resposta = int.Parse(tbResposta.Text);

            if (num1 + num2 == resposta) {
                MessageBox.Show("Certo!");
                certas++;
            }
            else
                MessageBox.Show("Errado!");

            if (contador == 10) {
                btnSubmit.Enabled = false;
                tbResposta.Enabled = false;
                MessageBox.Show("Acabaste o programa com " + certas + " respostas certas");
                return;
            }
            lbNum1.Text = rand.Next(1, 11).ToString();
            lbNum2.Text = rand.Next(1, 11).ToString();
            contador++;
            
        }
    }
}
