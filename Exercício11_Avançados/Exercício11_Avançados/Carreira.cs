using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício11_Avançados
{
    class Carreira
    {
        private int numeroCarreira;

        public int NumeroCarreira
        {
            get { return numeroCarreira; }
            set {
                if (value > 1 && value < 99)
                    numeroCarreira = value;
                else
                    numeroCarreira = 0;
            }
        }

        private bool noturno;

        public bool Noturno
        {
            get { return noturno; }
            set { noturno = value; }
        }

        private bool fimdesemana;

        public bool FimDeSemana
        {
            get { return fimdesemana; }
            set { fimdesemana = value; }
        }

        private List <Paragem> listaparagens;

        public List <Paragem> ListaParagens
        {
            get { return listaparagens; }
            set { listaparagens = value; }
        }

        public int ComparaParagens(Carreira c)
        {
            return (0);
        }

        public int ComparaCarreiras(Carreira c)
        {
            return (0);
        }

        public Carreira(int n, bool not, bool fds, List <Paragem> lp)
        {
            NumeroCarreira = n;
            Noturno = not;
            FimDeSemana = fds;
            ListaParagens = lp;
        }

        public override string ToString()
        {
            return "" + NumeroCarreira + " " + ListaParagens.First().Nome + " " + ListaParagens.Last().Nome;
        }


    }
}
