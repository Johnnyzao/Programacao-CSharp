using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ex._9_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;
            string d = textBox4.Text;

            List<string> listA = new List<string>();
            listA.Add(a);
            listA.Add(b);
            listA.Add(c);
            listA.Add(d);

            QuatroPalavras um = new QuatroPalavras(listA);

            label12.Text = "Todas iguais: " + um.TodasIguais();
            label13.Text = "Todas diferentes: " + um.TodasDiferentes();
            label14.Text = "Duas iguais: " + um.HaDuasIguais();

            if ((textBox5.Text == "") || (textBox6.Text == ""))
            {
                label1.Text = "" + um;
            }
            else
            {
                int numeroMudar = int.Parse(textBox5.Text);
                string palavraMudar = textBox6.Text;
                um.SetPalavra(palavraMudar, numeroMudar - 1);
                label1.Text = "" + um;
            }

            if (textBox7.Text == "")
            {
                label1.Text = "" + um;
            }
            else
            {
                int palavraVer = int.Parse(textBox7.Text);
                label9.Text = "Palavra: " + um.GetPalavra(palavraVer - 1);
            }
        }
    }
}
