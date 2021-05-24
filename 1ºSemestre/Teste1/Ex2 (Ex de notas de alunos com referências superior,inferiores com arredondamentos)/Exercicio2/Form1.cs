using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            double nota1 = Convert.ToDouble(textBox2.Text);
            double nota2 = Convert.ToDouble(textBox3.Text);
            if(nota1>=10 || nota2>=10)
            {
                if (nota1 >= 15 && nota2 >= 15)
                {
                    label4.Text = nome + " vai a exame oral.";
                }
                else
                {
                    label4.Text = nome + " foi aprovada.";
                }
            }
           
            else
            {
                label4.Text = nome + " foi reprovada.";
            }
            double media = (nota1 + nota2) / 2.0;
            media = Math.Round(media);
            label4.Text += "\n\n Media: " + media;
        }
    }
}
