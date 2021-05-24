using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTenis
{
    abstract class Elemento
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string nacionalidade;

        public string Nacionalidade
        {
            get { return nacionalidade; }
            set { nacionalidade = value; }
        }

        private DateTime dataNascimento;

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public Elemento(string nomeValue,string nacionalidadeValue , DateTime dataNascimentoValue)
        {
            Nome = nomeValue;
            Nacionalidade = nacionalidadeValue;
            DataNascimento = dataNascimentoValue;
        }

        public override string ToString()
        {
            return "Nome : " + Nome + "\nNacionalidade : " + Nacionalidade + "\nData de Nascimento : " + DataNascimento.ToShortDateString();
        }

    }
}
