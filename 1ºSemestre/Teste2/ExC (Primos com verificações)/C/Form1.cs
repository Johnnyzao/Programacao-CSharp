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
            int n1 = Convert.ToInt32(textBox1.Text);
            int n2 = Convert.ToInt32(textBox2.Text);
            if(n1 <=2 || n1>=100 || n2<=2 || n2>=100 )
            {
                MessageBox.Show("Os numeros deverão estar entre 2-100");
            }
            else if((n1+n2)<=10)
            {
                MessageBox.Show("A soma dos numeros deverá ser superior a 10");
            }
            else if( primo(n1)==1 || primo(n2)==1)
            {
                MessageBox.Show("Nenhum numero pode ser primo");
            }
            else
            {
                int soma = n1 + n2;
                lblRes.Text = soma.ToString();
            }
        }
    }
}
