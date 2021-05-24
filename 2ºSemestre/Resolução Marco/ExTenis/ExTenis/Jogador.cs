using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTenis
{
    enum enumSexos
    {
        Masculino,
        Feminino
    }
    class Jogador : Elemento
    {
        private enumSexos sexo;

        public enumSexos Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private int rankingAtp;
            
        public int RankingAtp
        {
            get { return rankingAtp; }
            set { if (value > 1 && value < 1000)
                    rankingAtp = value;
                else rankingAtp = 0;}
        }

        private Tecnico tecnico;
        public Tecnico Tecnico
        {
            get { return tecnico; }
            set { tecnico = value; }
        }

        public Jogador(string nomeValue, string nacionalidadeValue, DateTime dataNascimentoValue, enumSexos sexoValue, int rankingAtpValue,
            Tecnico tecnicoValue) : base(nomeValue, nacionalidadeValue, dataNascimentoValue)
        {
            Sexo = sexoValue;
            RankingAtp = rankingAtpValue;
            Tecnico = tecnicoValue;
        }

        public override string ToString()
        {
            return base.ToString() + "\nSexo : " + Sexo + "\nRanking ATP : " + RankingAtp + "\nTecnico : " + Tecnico;
        }



    }
}
