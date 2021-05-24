using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCasamento
{
    class Padre : Participante
    {
        private string paroquia;

        public string Paroquia
        {
            get { return paroquia; }
            set { paroquia = value; }
        }

        public Padre(string pNomeValue, string uNomeValue, string paroquiaValue) : base(pNomeValue,uNomeValue)
        {
            Paroquia = paroquiaValue;
        }

        public override string ToString()
        {
            return base.ToString() + " páraco de " + Paroquia; 
        }
    }
}
