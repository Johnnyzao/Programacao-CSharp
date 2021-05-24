using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Métodos3
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
            if (SaoIguais(num1, num2))
                label1.Text = "Os números são iguais!";
            else
                label1.Text = "Os números são diferentes!";
        }

        bool SaoIguais(int n1, int n2)
        {
            if (n1 == n2)
                return (true);

            return (false);
        }
    }
}
