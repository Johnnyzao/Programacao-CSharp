using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio75 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int dia = int.Parse(textBox1.Text);
            int mes = int.Parse(textBox2.Text);
            int ano = int.Parse(textBox3.Text);
            if (dataValida(dia, mes, ano))
                MessageBox.Show("A data é válida");
            else
                MessageBox.Show("A data não é válida");
        }
        private bool dataValida(int dia, int mes, int ano) {
            DateTime dt = DateTime.Today;
            if (ano < 1900 || ano > dt.Year)
                return false;
            return DateTime.TryParse(ano + "-" + mes + "-" + dia, out dt);
        }
    }
}
