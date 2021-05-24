using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marca = textBox1.Text;
            string processador = textBox2.Text;
            int velocidade = Convert.ToInt32(textBox3.Text);
            string monitor = textBox4.Text;
            string marca2 = textBox5.Text;
            string processador2 = textBox6.Text;
            int velocidade2 = Convert.ToInt32(textBox7.Text);
            string monitor2 = textBox8.Text;


            Computador pc = new Computador(marca,processador,velocidade,monitor);
            Computador pc2 = new Computador(marca2, processador2, velocidade2, monitor2);

            label1.Text = "" + pc + "\n" + pc2 + "\n" + pc.ComparaComputador(pc2);

        }
    }
}
