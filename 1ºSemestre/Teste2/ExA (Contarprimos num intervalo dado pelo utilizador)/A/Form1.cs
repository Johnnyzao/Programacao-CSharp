using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A
{
    public partial class Form1 : Form
    {
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }
        int primo(int n)
        {
            int i;
            if (n == 1) return 0;
            for (i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return 0;
            }
            return 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int n = Convert.ToInt32(textBox1.Text);
            if(n>1 && n<20)
            {
                listBox1.Items.Add(n);
               if(primo(n)==1)
                {
                    contador++;
                }
                label1.Text = "Numeros primos: " + contador;

            }
            else if(n==0)
            {
                button1.Enabled = false;
            }
           else
            {
               MessageBox.Show("Insira numero entre 1-20");
            }
            }
            

        }
}

