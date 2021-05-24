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
        int cont = 0;
        int[] numeros={0,0,0,0};
        public Form1()
        {
            InitializeComponent();
        }
        int primo(int n)
        {
            int i;
            if (n == 1 || n<0) return 0;
            for (i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return 0;
            }
            return 1;
        }
        int contaprimos(int []n)
        {
            int conta = 0;
            for(int i=0;i<cont;i++)
            {
                if(primo(n[i])==1)
                {
                    conta++;
                }
            }
            return conta;
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            if(cont<4)
            {
                int n = Convert.ToInt32(textBox1.Text);
                listBox1.Items.Add(n);
                numeros[cont] = n;
                cont++;
                if(cont==4)
                {
                    button1.Enabled = false;
                    int contador = contaprimos(numeros);
                    label1.Text = "Nº primos: " + contador;
                }
                
            }
        
       
        }
    }
}
