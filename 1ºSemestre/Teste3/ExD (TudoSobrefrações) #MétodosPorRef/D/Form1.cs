using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void teste(ref int num,ref int den)
        {
          

            for (int i = Math.Min(num, den); i >= 2; i--)
            {
                if (num % i == 0 && den % i == 0)
                {
                    num /= i;
                    den /= i;
                }
            }

        }
        void Somafracoes(int a,int b,int c,int d,ref int soma1,ref int soma2)
        {
            
            if (b==d)
            {
                soma1 = a + c;
                soma2 = b;
            }
            else
            {
                a = a * d;
                c = c * b;
                b = b * d;
                d = d * b;

               
                soma1 = a + c;
                soma2 = b;
            }
            teste(ref soma1, ref soma2);
        }
        void Subtraifracoes(int a, int b, int c, int d, ref int sub1, ref int sub2)
        {

            if (b == d)
            {
                sub1 = a-c;
                sub2 = b;
            }
            else
            {
                a = a * d;
                c = c * b;
                b = b * d;
                d = d * b;


                sub1 = a - c;
                sub2 = b;
            }
            teste(ref sub1, ref sub2);
        }
        void Dividfracoes(int a, int b, int c, int d, ref int div1, ref int div2)
        {
            div1 = a * d;
            div2 = b * c;
            
            teste(ref div1, ref div2);
        }
        void Multfracoes(int a, int b, int c, int d, ref int mult1, ref int mult2)
        {
            mult1 = a * c;
            mult2 = b * d;

            teste(ref mult1, ref mult2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBox1.Text);
            int n2 = Convert.ToInt32(textBox2.Text);
            teste(ref n1, ref n2);
            label3.Text = n1 + "";
            label4.Text = n2 + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBox3.Text);
            int n2 = Convert.ToInt32(textBox4.Text);

            int n3 = Convert.ToInt32(textBox5.Text);
            int n4 = Convert.ToInt32(textBox6.Text);

            int somaA=0, somaB=0;
            Somafracoes(n1, n2, n3, n4,ref somaA,ref somaB);
            label9.Text = somaA + "";
            label8.Text = somaB + "";

            int subA=0, subB=0;
            Subtraifracoes(n1, n2, n3, n4, ref subA, ref subB);
            label12.Text = subA + "";
            label11.Text = subB + "";

            int divA = 0, divB = 0;
            Dividfracoes(n1, n2, n3, n4, ref divA, ref divB);
            label15.Text = divA + "";
            label14.Text = divB + "";

            int multA = 0, multB = 0;
            Multfracoes(n1, n2, n3, n4, ref multA, ref multB);
            label18.Text = multA + "";
            label17.Text = multB + "";

        }
    }
}
