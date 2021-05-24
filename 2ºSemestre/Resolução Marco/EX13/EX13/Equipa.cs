using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX13
{
    class Equipa
    {
        private string pais;

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        private string nomeTreinador;

        public string NomeTreinador
        {
            get { return nomeTreinador; }
            set {
                if (value.Length > 20)
                    nomeTreinador = value.Substring(0,20);
                else nomeTreinador = value; }
        }

        private List<Jogador> listaJogadores;

        public List<Jogador> ListaJogadores
        {
            get { return listaJogadores; }
            set { listaJogadores = value; }
        }

        public Equipa(string p, string nt, List<Jogador> lj)
        {
            Pais = p;
            NomeTreinador = nt;
            ListaJogadores = lj;
        }
        
        public int MediaIdades(List<Jogador> lj)
        {
            int soma = 0, media = 0;
            foreach (var lista in lj)
            {
                soma += DateTime.Now.Year - lista.DataNascimento.Year;
            }
            return media = soma / lj.Count;
        }

        public bool Verifica(List<Jogador> lj)
        {
            bool repetido = false;
            //if ()
            //{
            //    repetido = true ;
            //}
            return repetido;
        }

        public override string ToString()
        {
            string aux = "";

            for (int i = 0; i < ListaJogadores.Count; i++)
            {
                aux += ListaJogadores[i].Nome + " ";
            }
            return Pais + " " + NomeTreinador + " " + " " + aux ;
        }
    }
}
