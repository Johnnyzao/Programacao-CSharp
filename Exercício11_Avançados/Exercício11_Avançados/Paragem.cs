using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício11_Avançados
{
    enum ListaConcelhos
    {
        Naodefinido,
        Maia,
        Porto,
        Valongo,
        Gondomar,
        Gaia,
        Matosinhos,
    }
    class Paragem
    {
        private int codparagem;

        public int CodParagem
        {
            get { return codparagem; }
            set {
                if (value >1 && value <10000)
                    codparagem = value;
                else
                    codparagem = 0;
            }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set {
                if (value == "")
                    nome = "Não definido";
                else
                    nome = value;
            }
        }

        private ListaConcelhos concelho;

        public ListaConcelhos Concelho
        {
            get { return concelho; }
            set { concelho = value; }                      
        }

        public Paragem(int cp, string n, ListaConcelhos c)
        {
            CodParagem = cp;
            Nome = n;
            Concelho = c;
        }
        public Paragem()
        {
            CodParagem = 0;
            Nome = "";
            Concelho = ListaConcelhos.Naodefinido;
        }

        public override string ToString()
        {
            return (CodParagem + ":" + Nome +"-"+ Concelho );
        }




    }
}
