using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioPrimos
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int numero = int.Parse(textBox1.Text);
            bool primo = true;
            for (int i=2; i<numero; i++) {
                if (numero % i == 0)
                    primo = false;
            }

            if (primo)
                MessageBox.Show("O número " + numero + " é primo");
            else
                MessageBox.Show("O número " + numero + " não é primo");
        }
    }
}
