using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11_CORRECAO
{
    enum ListaConcelhos
    {   
        Maia,
        Porto,
        Matosinhos,
        Gaia,
        Valongo,
        Gondomar
    }
    class Paragem
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private ListaConcelhos concelho;

        public ListaConcelhos Concelho
        {
            get { return concelho; }
            set { concelho = value; }
        }

        public Paragem(int cdg, string nm, ListaConcelhos clh)
        {
            Codigo = cdg;
            Nome = nm;
            Concelho = clh;
        }

        public override string ToString()
        {
            return "" + Codigo + " " + Nome + " " +  Concelho;
        }

    }
}
