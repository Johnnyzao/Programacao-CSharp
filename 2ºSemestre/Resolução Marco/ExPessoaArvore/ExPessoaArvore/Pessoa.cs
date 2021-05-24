using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPessoaArvore
{
    class Pessoa : IIdade 
    {
        DateTime dataNascimento;
        public int Idade
        {
            get { return DateTime.Today.Year - dataNascimento.Year; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private decimal altura;

        public decimal Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public Pessoa(DateTime dataNascimentoValue, string nomeValue, decimal alturaValue)
        {
            dataNascimento = dataNascimentoValue;
            Nome = nomeValue;
            Altura = alturaValue;
        }

        public override string ToString()
        {
            return Nome + " Idade " + Idade;
        }

    }
}
