using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEmpresa
{
    public abstract class Empregado
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string nif;

        public string Nif
        {
            get { return nif; }
            set { nif = value; }
        }

        public Empregado(string nomeValue,string nifValue)
        {
            Nome = nomeValue;
            Nif = nifValue;
        }

        public override string ToString()
        {
            return Nome + " " + Nif;
        }

        public abstract decimal Salario();
    }
}
