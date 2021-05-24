using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício5_Avançados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int den1 = int.Parse(textBox2.Text);
            int num2 = int.Parse(textBox3.Text);
            int den2 = int.Parse(textBox4.Text);

            Racional f1 = new Racional(num1, den1);
            Racional f2 = new Racional(num2, den2);

            Racional resultadoMult = f1.Multiplica(f2);
            label1.Text = "O resultado da multlipicação é" + resultadoMult;
           Racional resultadoSoma = f1.Soma(f2);
            label2.Text = "O resultado da soma é" + resultadoSoma;
            
            Racional resultadoSubtracao = f1.Subtracao(f2);
            label3.Text = " O resultado da subtração é" + resultadoSubtracao;
            

            Racional resultadoDiv = f1.Divisao(f2);
            label4.Text = "O resultado da divisao é" + resultadoDiv;
            Racional ResultadoRed = f1.Reducao(f2);
            label5.Text = "";
            label5.Text += "\n O numerador é " + ResultadoRed + " O denominador é " + ResultadoRed;
            Racional ResultadoReducao = f1.Reducao2(f1);
            label6.Text = "";
            label6.Text += "\n O numerador é " + ResultadoReducao + " O denominador é " + ResultadoReducao;

        }
    }
}
