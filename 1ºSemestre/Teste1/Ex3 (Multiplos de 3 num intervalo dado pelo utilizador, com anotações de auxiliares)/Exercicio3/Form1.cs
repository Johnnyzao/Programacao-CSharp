using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            int n1 = Convert.ToInt32(textBox1.Text);
            int n2 = Convert.ToInt32(textBox2.Text);
            string aux;
            char aux2;
            for(int i=n1;i<n2;i++)
            {
                aux = (i.ToString());
                aux2=aux[aux.Length - 1];
                if (i%3==0 && aux2!='9')
                {
                    label3.Text += i + " ";
                }
            }
        }
    }
}
