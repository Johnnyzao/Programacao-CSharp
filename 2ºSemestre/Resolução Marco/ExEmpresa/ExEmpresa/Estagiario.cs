using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEmpresa
{
    class Estagiario : Empregado
    {
        private int numHoras;

        public int NumHoras
        {
            get { return numHoras; }
            set { numHoras = value; }
        }

        private string instituicao;

        public string Instituicao
        {
            get { return instituicao; }
            set { instituicao = value; }
        }

        public Estagiario(string nomeValue,string nifValue,int numHorasValue, string instituicaoValue) : base(nomeValue,nifValue)
        {
            NumHoras = numHorasValue;
            Instituicao = instituicaoValue;
        }

        public override string ToString()
        {
            return base.ToString() + " vem de " + Instituicao;
        }
        public override decimal Salario()
        {
            return 0;
        }
    }
}
