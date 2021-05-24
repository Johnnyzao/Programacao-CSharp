using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCasamento
{
    enum tipoConvidado
    {
        Normal,
        Musico,
        Fotografo,
        Padrinho,
        Madrinha
    }

    enum lado
    {
        Noivo,
        Noiva
    }
    class Convidado : Participante
    {
        private tipoConvidado tipoConvidado;

        public tipoConvidado TipoConvidado
        {
            get { return tipoConvidado; }
            set { tipoConvidado = value; }
        }

        private lado lado;

        public lado Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        private Sexo sexo;

        public Sexo Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public Convidado(string pNomeValue, string uNomeValue,tipoConvidado tipoConvidadoValue,lado ladoValue,Sexo sexoValue) 
            : base(pNomeValue,uNomeValue)
        {
            TipoConvidado = tipoConvidado;
            Lado = ladoValue;
            Sexo = sexoValue;
        }

        public override string ToString()
        {

            return base.ToString() + "\n" + TipoConvidado + " vem do lado do " + Lado + "\nSexo : " + Sexo;
        }

    }
}
