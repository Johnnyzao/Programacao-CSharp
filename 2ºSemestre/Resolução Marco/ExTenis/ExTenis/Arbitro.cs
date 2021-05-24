using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTenis
{
    enum enumArbitro
    {
        Principal,
        Linha,
        Auxiliar
    }

    class Arbitro : Elemento
    {

        private enumArbitro enumArbitro;

        public enumArbitro EnumArbitro
        {
            get { return enumArbitro; }
            set { enumArbitro = value; }
        }

        public Arbitro(string nomeValue, string nacionalidadeValue, DateTime dataNascimentoValue,enumArbitro enumArbitroValue) : 
            base(nomeValue,nacionalidadeValue,dataNascimentoValue)
        {
            EnumArbitro = enumArbitroValue;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
