using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício3_Avançados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome1=textBox1.Text;
            int numero1=int.Parse(textBox2.Text);
            string ano1 = textBox3.Text;
            string curso1=textBox4.Text;

            string nome2 = textBox5.Text;
            int numero2 = int.Parse(textBox6.Text);
            string ano2 = textBox7.Text;
            string curso2 = textBox8.Text;

            AlunoISMAI Pessoa1 = new AlunoISMAI(nome1,numero1,ano1, CursoIsmai.TPSI);

            AlunoISMAI Pessoa2 = new AlunoISMAI(nome2, numero2, ano2, CursoIsmai.Psicologia);

            if (Pessoa1.ChegouAntes(Pessoa2))
                label5.Text = "O " + Pessoa1.PrimeiroUltimoNome(Pessoa1) + " inscreveu-se primeiro que o " + Pessoa2.PrimeiroUltimoNome(Pessoa2) + " no curso " +CursoIsmai.TPSI;
            else
                label5.Text = "O " + Pessoa2.PrimeiroUltimoNome(Pessoa2) + " inscreveu-se primeiro que o " + Pessoa1.PrimeiroUltimoNome(Pessoa1) + " no curso " + CursoIsmai.Psicologia;



        }
    }
}
