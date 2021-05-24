using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E13
{
    class Jogador
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set
            {
                if(value.Length > 20)
                {
                    value = value.Replace(" ", String.Empty);
                    nome = value.Substring(0,20);
                }
                else
                {
                    value = value.Replace(" ", String.Empty);
                    nome = value;
                }
            }
        }

        private int camisola;

        public int Camisola
        {
            get { return camisola; }
            set
            {
                if(value > 0 && value < 23)
                {
                    camisola = value;
                }
                else
                {
                    camisola = 0;
                }                
            }
        }

        private DateTime nascimento;

        public DateTime Nascimento
        {
            get { return nascimento; }
            set { nascimento = value; }
        }

        private int golos;

        public int Golos
        {
            get { return golos; }
            set
            {
                if(value > 0)
                {
                    golos = value;
                }
                else
                {
                    golos = 0;
                }                
            }
        }

        public Jogador(string n, int c, DateTime nasc)
        {
            Nome = n;
            Camisola = c;
            Nascimento = nasc;
            Golos = 0;
        }

        public override string ToString()
        {
            if(Camisola != 0)
            {
                return "Nome: " + Nome + "\nCamisola: " + Camisola + "\nIdade: " + (DateTime.Today.Year - Nascimento.Year);
            }
            else
            {
                return "Nao defenido";
            }            
        }

        public int MarcouGolos(int golosValue)
        {
            return (Golos + golosValue);
        }

        public bool ComparaJogador(Jogador j)
        {
            if(this.Golos > j.Golos)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
