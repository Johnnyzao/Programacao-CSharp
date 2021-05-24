using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Métodos4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            label1.Text = "Antes " + num1 + " " + num2;
            Modifica(ref num1, ref num2);
            label1.Text += "\nDepois " + num1 + " " + num2;
        }

        void Modifica(ref int n1, ref int n2)
        {
            n1 = n1 + 10;
            n2 = n2 + 10;
        }
    }
}
