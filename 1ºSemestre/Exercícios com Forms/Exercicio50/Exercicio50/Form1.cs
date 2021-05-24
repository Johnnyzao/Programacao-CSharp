using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio50
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e) {
            decimal preco = decimal.Parse(tbPreco.Text);
            decimal entregue = decimal.Parse(tbPagamento.Text);

            int troco = (int)((entregue - preco) * 20);

            int notas10 = troco / 1000;
            troco = troco - notas10 * 1000;
            label3.Text += "Notas de 10 -> " + notas10 + "\n";

            int notas5 = troco / 500;
            troco = troco - notas5 * 500;
            label3.Text += "Notas de 5 -> " + notas5 + "\n";

            int moedas2 = troco / 200;
            troco = troco - moedas2 * 200;
            label3.Text += "Moedas de 2 -> " + moedas2 + "\n";

            int moedas1 = troco / 100;
            troco = troco - moedas1 * 100;
            label3.Text += "Moedas de 1 -> " + moedas1 + "\n";

            int moedas50 = troco / 50;
            troco = troco - moedas50 * 50;
            label3.Text += "Moedas de 50 -> " + moedas50 + "\n";

            int moedas20 = troco / 20;
            troco = troco - moedas20 * 20;
            label3.Text += "Moedas de 20 -> " + moedas20 + "\n";

            int moedas10 = troco / 10;
            troco = troco - moedas2 * 10;
            label3.Text += "Moedas de 10 -> " + moedas10 + "\n";

            int moedas5 = troco / 5;
            troco = troco - moedas5 * 5;
            label3.Text += "Moedas de 5 -> " + moedas5 + "\n";


            int moedas2c = troco / 2;
            troco = troco - moedas2c * 2;
            label3.Text += "Moedas de 2c -> " + moedas2c + "\n";

            int moedas1c = troco / 1;
            troco = troco - moedas1c * 1;
            label3.Text += "Moedas de 1c -> " + moedas1c + "\n";

        }
    }
}