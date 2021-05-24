using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E13
{
    class Equipa
    {
        private string pais;

        public string Pais
        {
            get { return pais; }
            set
            {
                if(value.Length > 20)
                {
                    pais = value.Substring(0,20);
                }
                else
                {
                    pais = value;
                }                
            }
        }

        private string treinador;

        public string Treinador
        {
            get { return treinador; }
            set
            {
                if(value.Length > 20)
                {
                    treinador = value.Substring(0, 20);
                }
                else
                {
                    treinador = value;
                }                
            }
        }

        private List<Jogador> listajogadores;

        public List<Jogador> ListaJogadores
        {
            get { return listajogadores; }
            set { listajogadores = value; }
        }

        public Equipa(string p, string t, List<Jogador> lj)
        {
            Pais = p;
            Treinador = t;
            ListaJogadores = lj;
        }

        public override string ToString()
        {
            return "Pais: " + Pais + "\nTreinador: " + Treinador;
        }

        public double MediaIdades()
        {
            int aux = 0;

            for (int i = 0; i < ListaJogadores.Count; i++)
            {
                aux += DateTime.Today.Year - ListaJogadores[i].Nascimento.Year;
            }

            return aux / ListaJogadores.Count;
        }

        public bool Verifica()
        {
            int[] camisolas = new int[ListaJogadores.Count];
            int contador = 0;
            foreach (Jogador jog in ListaJogadores)
            {
                if (camisolas.Contains(jog.Camisola))
                    return false;
                camisolas[contador] = jog.Camisola;
                contador++;
            }
            return true;
        }

    }
}
