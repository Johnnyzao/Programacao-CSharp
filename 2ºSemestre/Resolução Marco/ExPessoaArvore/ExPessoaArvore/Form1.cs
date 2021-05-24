using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExPessoaArvore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa(new DateTime(1998,11,25),"Marco",(decimal) 1.75);
            Pessoa pessoa2 = new Pessoa(new DateTime(2002,07,13),"Diogo",(decimal) 1.50);

            Arvore arvore = new Arvore(2002, "Carvalho", (decimal)2.50);
            Arvore arvore2 = new Arvore(2010, "Cerejeira", (decimal)5.23);

            List<IIdade> listaDeCoisas = new List<IIdade>();

            listaDeCoisas.Add(pessoa);
            listaDeCoisas.Add(pessoa2);
            listaDeCoisas.Add(arvore);
            listaDeCoisas.Add(arvore2);

            foreach (IIdade var in listaDeCoisas)
            {
                label1.Text += "\n" + var.ToString() + " Altura " + var.Altura;
            }
        }
    }
}
