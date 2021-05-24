using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExAutomovel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veiculo oMeuPopo = new Veiculo("Ferrari", new DateTime(2019, 10, 10), "12-PO-PO");

            Funcionario func = new Funcionario("Marco", new DateTime(1998, 11, 25),oMeuPopo);

            label1.Text = "" + func;
        }
    }
}
