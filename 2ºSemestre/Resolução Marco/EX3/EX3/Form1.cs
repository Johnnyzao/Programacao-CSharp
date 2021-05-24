using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX3
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
            int numero = Convert.ToInt32(textBox2.Text);
            int ano = Convert.ToInt32(textBox3.Text);
            string curso = textBox4.Text;

            string nome2 = textBox5.Text;
            int numero2 = Convert.ToInt32(textBox6.Text);
            int ano2 = Convert.ToInt32(textBox7.Text);
            string curso2 = textBox8.Text;


            Aluno aluno1 = new Aluno(nome, numero, ano, curso);
            Aluno aluno2 = new Aluno(nome2, numero2, ano2, curso2);

            label5.Text = "" + aluno1;
            label10.Text = "" + aluno2;
            if (aluno1.ChegouAntes(aluno2))
                label5.Text += "\n" + aluno1.PrimeiroUltimoNome() + " chegou antes";
            else label5.Text += "\n" + aluno2.PrimeiroUltimoNome() + " chegou antes";

        }
    }
}
