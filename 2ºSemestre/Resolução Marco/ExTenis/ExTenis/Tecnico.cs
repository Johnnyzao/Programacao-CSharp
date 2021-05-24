using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTenis
{
    class Tecnico : Elemento
    {
        private int numLicenca;

        public int NumLicenca
        {
            get { return numLicenca; }
            set { if (value > 1000 && value < 9999)
                    numLicenca = value;
                else numLicenca = 0;
            }
        }

        public Tecnico(string nomeValue,string nacionalidadeValue,DateTime dataNascimentoValue,int numLicencaValue) : base(nomeValue,nacionalidadeValue,dataNascimentoValue)
        {
            NumLicenca = numLicencaValue;
        }

        public override string ToString()
        {
            return Nome + "\nNúmero de Licença : " + NumLicenca;
        }

    }
}
