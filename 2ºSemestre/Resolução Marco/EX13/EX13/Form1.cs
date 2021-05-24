using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jogador jogador1 = new Jogador("Marco Filipe Teixeira Martins",7,new DateTime(1998,11,25));
            Jogador jogador2 = new Jogador("Diogo", 3, new DateTime(1998, 11, 25));
            Jogador jogador3 = new Jogador("João", 4, new DateTime(1998, 11, 25));
            Jogador jogador4 = new Jogador("José", 24, new DateTime(1998, 11, 25));
            Jogador jogador5 = new Jogador("Marco", 4, new DateTime(1998, 11, 25));
            jogador1.MarcouGolos(5);
            jogador2.MarcouGolos(3);
            List<Jogador> lj = new List<Jogador>();
            lj.Add(jogador1);
            lj.Add(jogador2);
            lj.Add(jogador3);
            lj.Add(jogador4);
            lj.Add(jogador5);
            Equipa equipa = new Equipa("Portugal", "Mourinho", lj);
            label1.Text = "" + jogador1.ComparaJogador(jogador2) + "\n" + equipa + "\n" + equipa.MediaIdades(lj) + " " + equipa.Verifica(lj);
        }
    }
}
