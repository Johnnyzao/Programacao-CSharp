using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12
{
    class Equipa
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string pais;

        public string Pais
        {
            get { return pais; }
            set {
                if (value != "")
                    pais = value;
                else pais = "N/A";
            }
        }

        private int rankingFifa;

        public int RankingFifa
        {
            get { return rankingFifa; }
            set {
                if (value > 0 && value < 100)
                    rankingFifa = value;
                else rankingFifa = 0;
            }
        }

        private DateTime dataInscricao;

        public DateTime DataInscricao
        {
            get { return dataInscricao; }
            set {
                if (value > DateTime.Today)
                    dataInscricao = DateTime.Today;
                else dataInscricao = value;
            }
        }

        public Equipa(string n,string p,int rf,DateTime data)
        {
            Nome = n;
            Pais = p;
            RankingFifa = rf;
            DataInscricao = data;
        }

        public override string ToString()
        {
            return Nome + " - " + Pais + " | RANKING " + RankingFifa + " | DATA INSCRICAO : " + DataInscricao.ToShortDateString();
        }

        public int ComparaRanking(Equipa rank)
        {
            return Math.Max(this.RankingFifa, rank.RankingFifa) - Math.Min(this.RankingFifa, rank.RankingFifa);
        }
    }
}
