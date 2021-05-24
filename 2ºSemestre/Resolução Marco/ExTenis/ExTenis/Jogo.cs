using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTenis
{
    class Jogo
    {
        private DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        private Jogador jogador1;

        public Jogador Jogador1
        {
            get { return jogador1; }
            set { jogador1 = value; }
        }

        private Jogador jogador2;

        public Jogador Jogador2
        {
            get { return jogador2; }
            set { jogador2 = value; }
        }

        private Arbitro arbitro;

        public Arbitro Arbitro
        {
            get { return arbitro; }
            set { arbitro = value; }
        }

        private string nomeTorneio;

        public string NomeTorneio
        {
            get { return nomeTorneio; }
            set { nomeTorneio = value; }
        }

        public Jogo(DateTime dataValue, Jogador jogador1Value, Jogador jogador2Value, Arbitro arbitroValue, string nomeTorneioValue)
        {
            Data = dataValue;
            Jogador1 = jogador1Value;
            Jogador2 = jogador2Value;
            Arbitro = arbitroValue;
            NomeTorneio = nomeTorneioValue;
        }
        public override string ToString()
        {
            return "Torneio " + NomeTorneio + "\n" + jogador1.Nome + " vs " + Jogador2.Nome + "\nArbitro : " + arbitro;
        }

        public string GetNomeFavorito(Jogador j1, Jogador j2)
        {
            return j1.RankingAtp > j2.RankingAtp ? j1.Nome : j2.Nome;
        }
    }
}
