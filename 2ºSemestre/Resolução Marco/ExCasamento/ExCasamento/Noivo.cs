using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCasamento
{
    enum Sexo
    {
        Masculino,
        Feminino
    }
    class Noivo : Participante
    {
        private DateTime dataNascimento;

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        private Sexo sexo;

        public Sexo Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public Noivo(string pNomeValue, string uNomeValue,DateTime dataNascValue, Sexo sexoValue) : base(pNomeValue, uNomeValue)
        {
            DataNascimento = dataNascValue;
            Sexo = sexoValue;
        }

        public override string ToString()
        {
            return base.ToString() + "\nIdade : " + Idade() + "\nSexo : " + Sexo + "\n";   
        }

        public int Idade()
        {
            return DateTime.Now.Year - DataNascimento.Year;
        }
    }
}
