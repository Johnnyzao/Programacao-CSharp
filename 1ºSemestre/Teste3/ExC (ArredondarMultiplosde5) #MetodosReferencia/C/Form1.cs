using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void multiplo(ref int n1)
        {
            if (n1 < 0)
                n1 = 0;
            else if (n1 % 5 == 0)
                n1 = n1;
            else
            {
                double aux2 = n1;
                double n = aux2 / 5;
                double aux = Math.Round(n, 0);
                aux = aux * 5;
                n1 = Convert.ToInt32(aux);
            }

        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            multiplo(ref a);
            label1.Text = " " + a;
        }
    }
}
