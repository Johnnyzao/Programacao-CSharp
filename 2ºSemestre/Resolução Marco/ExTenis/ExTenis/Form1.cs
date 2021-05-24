using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExTenis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tecnico tecnico1 = new Tecnico("José", "PT", new DateTime(1980, 12, 03), 3242);
            Tecnico tecnico2 = new Tecnico("Alfred", "EN", new DateTime(1985, 04, 03), 894);
            Jogador jogador1 = new Jogador("Marco", "PT", new DateTime(1998, 11, 25), enumSexos.Masculino, 34,tecnico1);
            Jogador jogador2 = new Jogador("Diogo", "PT", new DateTime(1999, 07, 09), enumSexos.Feminino, 34,tecnico2);
            Arbitro arbitro = new Arbitro("Julio", "ES", new DateTime(1975, 05, 19), enumArbitro.Principal);

            Jogo jogo = new Jogo(new DateTime(2019, 05, 02), jogador1, jogador2, arbitro, "OPEN ALGARVE");

            label1.Text = "\n" + jogo + "\nFavorito : " + jogo.GetNomeFavorito(jogador1,jogador2);
        }
    }
}
