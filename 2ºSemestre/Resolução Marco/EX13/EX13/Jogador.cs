using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX13
{
    class Jogador
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { if (value.Length > 20)
                    nome = value.Substring(0,20);
                else nome = value; }
        }

        private int numCamisola;

        public int NumCamisola
        {
            get { return numCamisola; }
            set { if (value >= 1 && value <= 23)
                    numCamisola = value;
                else numCamisola = 0;
            }
        }

        private DateTime dataNascimento;

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        private int numGolos;

        public int NumGolos
        {
            get { return numGolos; }
            set { if (value >= 0)
                    numGolos = value;
                else numGolos = 0;
            }
        }

        public Jogador(string n, int nc, DateTime datanasc)
        {
            Nome = n;
            NumCamisola = nc;
            DataNascimento = datanasc;
            NumGolos = 0;
        }

        public override string ToString()
        {
            return "Nome :" + Nome + "\nCamisola : " + NumCamisola + "\nIdade : " + (DateTime.Now.Year - DataNascimento.Year) + "\nGolos : " + NumGolos + "\n";
        }

        public void MarcouGolos(int golos)
        {
            if (golos > 0)
                NumGolos+=golos;
        }

        public bool ComparaJogador(Jogador jogador)
        {
            if (this.NumGolos > jogador.NumGolos)
                return true;
            else return false;
        }
    }
}
