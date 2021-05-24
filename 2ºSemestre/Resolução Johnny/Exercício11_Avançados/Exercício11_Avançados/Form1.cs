using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício11_Avançados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paragem PrimeiraParagem = new Paragem (1234, "Castelo", ListaConcelhos.Porto);
            Paragem SegundaParagem = new Paragem(2342,"Baixo",ListaConcelhos.Gaia);
            Paragem TerceiraParagem = new Paragem(3214, "Centro", ListaConcelhos.Valongo);
            Paragem QuartaParagem = new Paragem(124, "Lindo", ListaConcelhos.Matosinhos);

            List<Paragem> lp = new List<Paragem>();
            lp.Add(PrimeiraParagem);
            lp.Add(SegundaParagem);
            lp.Add(TerceiraParagem);
            lp.Add(QuartaParagem);

            Carreira carr = new Carreira(12, true, true, lp);
            label1.Text ="Carreira : " + carr;

        }
    }
}
