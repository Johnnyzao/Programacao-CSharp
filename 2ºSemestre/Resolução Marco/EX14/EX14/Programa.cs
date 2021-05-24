using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX14
{
    class Programa
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (value.Length > 20)
                    nome = char.ToUpper(value[0]) + value.Substring(1, 20);
                else nome = value;
            }
        }

        private string canal;

        public string Canal
        {
            get { return canal; }
            set { if (value.Contains(" "))
                    canal = value.Substring(0, value.IndexOf(" "));
                else canal = value;
            }
        }

        private int duracao;

        public int Duracao
        {
            get { return duracao; }
            set { if (value >= 10 && value <= 180)
                    duracao = value;
                else duracao = 0 ; }
        }

        public Programa(string n, string c, int d)
        {
            Nome = n;
            Canal = c;
            Duracao = d;
        }

        public override string ToString()
        {
            return Duracao != 0 ?  Nome + " " + Canal + " " + Duracao : Nome + " " + Canal;;
        }

        public bool CurtaDuracao()
        {
            return Duracao <= 60 ? true : false;
        }

        public string Iniciais()
        {
             return new string(Nome.Split(' ').Select(x => x.First()).ToArray()).ToUpper();
            //string[] sigla = Nome.Split();
            //foreach (string res in sigla)
            //    nsigla[] = res.Substring(0,1);
            //return Nome.ToUpper();
        }
    }
}
