using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int numeroanterior;
        bool primeiro = false;
        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
           

            if (primeiro==true)
            {
                if(n==numeroanterior)
                {
                    label1.Text = "igual ao anterior ";
                    button1.Enabled = false;
                }
                else if (n == (numeroanterior*2))
                {
                    label1.Text = "igual ao dobro do anterior ";
                    button1.Enabled = false;
                }
                else if (n == (numeroanterior / 2))
                {
                    label1.Text = "igual à metade do anterior ";
                    button1.Enabled = false;
                }
                else
                {
                    //CONTINUA
                }
                numeroanterior = n;
            }
            else
            {
                numeroanterior = n;
                primeiro = true;
            }
            listBox1.Items.Add(n);
        }
    }
}
