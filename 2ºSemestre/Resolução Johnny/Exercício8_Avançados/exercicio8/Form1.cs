using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente c1 = new Cliente("Fábio", "Oliveira", "423102938677", "922847326", 10);
            Cliente c2 = new Cliente("Vanessa", "Silva", "123456789", "920987654", 50);

            label1.Text += "\n" + c1;
            label1.Text += "\n" + c2;

            MessageBox.Show(c1.CreditoPositivo().ToString());
            MessageBox.Show(c1.VariaCredito(20).ToString());
            MessageBox.Show(c1.CreditoTelefone().ToString());
        }
    }
}
