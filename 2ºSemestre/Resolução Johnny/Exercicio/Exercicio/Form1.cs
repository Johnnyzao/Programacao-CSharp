using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veiculo oMeuPopo = new Veiculo("Bicicleta", new DateTime(2019, 10, 10), "12-PO-PO");

            Funcionario func = new Funcionario("Luis Proenca", new DateTime(1980, 5, 5), oMeuPopo);

            label1.Text = "" + func;
            

        }
    }
}
