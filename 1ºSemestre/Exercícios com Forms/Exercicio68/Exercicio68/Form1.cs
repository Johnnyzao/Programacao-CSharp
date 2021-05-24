using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio68 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int nota1 = int.Parse(textBox1.Text);
            int nota2 = int.Parse(textBox2.Text);
            if (Passou(nota1, nota2))
                MessageBox.Show("O aluno passou!");
            else
                MessageBox.Show("O aluno não passou!");
        }

        private bool Passou(int nota1, int nota2) {
            if (nota1 + nota2 >= 19 && nota1 > 7 && nota2 > 7)
                return true;
            return false;
        }
    }
}
