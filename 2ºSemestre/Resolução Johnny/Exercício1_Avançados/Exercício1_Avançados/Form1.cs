using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício1_Avançados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int largura = int.Parse(textBox1.Text);
            int comprimento = int.Parse(textBox2.Text);

            Retangulo meuretangulo = new Retangulo(15, 15);

            Retangulo outroretangulo = new Retangulo(largura, comprimento);

            if (largura > 0 && comprimento > 0)
            {
                if (meuretangulo.Quadrado())
                {
                    label3.Text = "Devido aos números que inseriu a forma geométrica apresentada é um quadrado"
                        + "\nConcluiu assim que tem uma área = " + meuretangulo.Area() + " e um perimetro = "
                    + meuretangulo.Perimetro(); ;
                }
                else
                    label3.Text = "Retangulo têm \nLargura = " + largura + "\nComprimento = " + comprimento;
                if (outroretangulo.Quadrado())
                {
                    label4.Text = "Devido aos números que inseriu a forma geométrica apresentada é um quadrado \nConcluiu assim que tem uma área = " 
                        + meuretangulo.Area() + " e um perimetro = " + meuretangulo.Perimetro();
                }
                else
                    label4.Text = "Retangulo têm \nLargura = " + largura + "\nComprimento = " + comprimento +
                    "\nConcluiu assim que tem uma área = " + meuretangulo.Area() + " e um perimetro = " +
                    meuretangulo.Perimetro();
            }
            else
                MessageBox.Show("Insira números positivos", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
        }
    }
}
