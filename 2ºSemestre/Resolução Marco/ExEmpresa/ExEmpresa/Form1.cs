using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExEmpresa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empregado estagiario = new Estagiario("Marco","132456789",8,"IPMAIA");
            Empregado repositor = new Repositor("João", "987654321", 500, 2);
            label1.Text = "\n" + estagiario + " ganha " + estagiario.Salario() + "€";
            label1.Text += "\n" + repositor + " ganha " + repositor.Salario() + "€";
        }
    }
}
