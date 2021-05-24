using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Funcionario
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private DateTime dataNascimento;

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        private Veiculo carro;

        public Veiculo Carro
        {
            get { return carro; }
            set { carro = value; }
        }
        public Funcionario(string n, DateTime dn, Veiculo c)
        {
            Nome = n;
            DataNascimento = dn;
            Carro = c;
        }
        public override string ToString()
        {
            return Nome + " nascido em "+ DataNascimento.ToShortDateString()+" Veiculo atribuido " + Carro;
        }
    }
}
