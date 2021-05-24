using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            int den = Convert.ToInt32(textBox2.Text);
            int num2 = Convert.ToInt32(textBox3.Text);
            int den2 = Convert.ToInt32(textBox4.Text);

            Fracao f1 = new Fracao(num, den);
            Fracao f2 = new Fracao(num2, den2);

            Fracao resultadoMul = f1.Multiplica(f2);
            Fracao resultadoDiv = f1.Divisao(f2);
            Fracao resultadoSoma = f1.Soma(f2);
            Fracao resultadoSub = f1.Subtracao(f2);

            label1.Text ="Multiplicação = " + resultadoMul + "\nDivisão = " + resultadoDiv + "\nSoma = " + resultadoSoma + "\nSubtração = " + resultadoSub;
        }
    }
}
