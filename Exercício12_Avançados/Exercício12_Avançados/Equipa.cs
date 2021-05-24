using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício12_Avançados
{
        enum ListaPaises
        {
            NaoDefenido,
            Portugal,
            Espanha,
            Franca,
            Russia,
            Brasil,
            Alemanha,
            Africa
        }

        class Equipa
        {

            private ListaPaises pais;

            public ListaPaises Pais
            {
                get { return pais; }
                set { pais = value; }
            }

            private int ranking;

            public int Ranking
            {
                get { return ranking; }
                set
                {
                    if (value <= 100)
                    {
                        ranking = value;
                    }
                    else
                    {
                        ranking = 0;
                    }
                }
            }

            private DateTime data;

            public DateTime Data
            {
                get { return data; }
                set
                {
                    if (value < DateTime.Now)
                    {
                        data = value;
                    }
                    else
                    {
                        data = DateTime.Now;
                    }

                }
            }

            public Equipa(ListaPaises p, int r, DateTime d)
            {
                Pais = p;
                Ranking = r;
                Data = d;
            }

            public int ComparaRankings(Equipa e)
            {
                return (this.Ranking - e.Ranking);
            }

            public override string ToString()
            {
                return "Pais: " + Pais + "\n" + "Ranking: " + Ranking;
            }
        }
    }
