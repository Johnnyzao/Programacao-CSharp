using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCasamento
{
    public abstract class Participante
    {
        private string primeiroNome;

        public string PrimeiroNome
        {
            get { return primeiroNome; }
            set { primeiroNome = value; }
        }

        private string ultimoNome;

        public string UltimoNome
        {
            get { return ultimoNome; }
            set { ultimoNome = value; }
        }

        public Participante(string pNomeValue,string uNomeValue)
        {
            PrimeiroNome = pNomeValue;
            UltimoNome = uNomeValue;
        }

        public override string ToString()
        {
            return "" + PrimeiroNome + " " + UltimoNome;
        }
    }
}
