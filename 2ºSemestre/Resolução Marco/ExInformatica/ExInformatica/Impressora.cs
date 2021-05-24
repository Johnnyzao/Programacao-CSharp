using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExInformatica
{
    enum TipoImpressora
    {
        Laser,
        Inkjet,
        Agulhas
    }
    enum TipoTinta
    {
        Cor,
        PretoEBranco
    }
    class Impressora : Informatica
    {
        private TipoImpressora tipoImpressora;

        public TipoImpressora TipoImpressora
        {
            get { return tipoImpressora; }
            set { tipoImpressora = value; }
        }

        private TipoTinta tipoTinta;

        public TipoTinta TipoTinta
        {
            get { return tipoTinta; }
            set { tipoTinta = value; }
        }

        public Impressora(string marcaValue, DateTime dataCompraValue, TipoImpressora tipoImpressoraValue, TipoTinta tipoTintaValue) : base(marcaValue,dataCompraValue)
        {
            TipoImpressora = tipoImpressoraValue;
            TipoTinta = tipoTintaValue;
        }

        public override string ToString()
        {
            return "\n" + base.ToString() + "\nTipo de Impressora : " + TipoImpressora + "\nTipo de Tinteiros : " + TipoTinta;
        }
    }
}
