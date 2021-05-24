using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício12_Avançados
{
        class Grupo
        {

            private char designacao;

            public char Designacao
            {
                get { return designacao; }
                set
                {
                    if (value >= 'A' && value <= 'H')
                    {
                        designacao = value;
                    }
                    else
                    {
                        designacao = 'Z';
                    }

                }
            }

            private List<Equipa> listaequipas;

            public List<Equipa> ListaEquipas
            {
                get { return listaequipas; }
                set { listaequipas = value; }
            }

            public Grupo(char d, List<Equipa> le)
            {
                Designacao = d;
                ListaEquipas = le;
            }

            public bool EquipasRepetidas(Equipa e)
            {
                bool flag = true;
                //int z = 0;

                //for (int i = 0; i < this.ListaEquipas.Count; i++)
                //{
                //    z = i + 1;

                //    if (z <= i)
                //    {
                //        if (ListaEquipas[i].Pais == ListaEquipas[z].Pais)
                //        {
                //            flag = true;
                //        }
                //        else
                //        {
                //            flag = false;
                //        }
                //    }
                //}

                //return flag;

                for (int i = 0; i < this.ListaEquipas.Count; i++)
                {
                    if (this.ListaEquipas[i].Pais == e.Pais)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }

                return flag;
            }

            public override string ToString()
            {
                string aux = "";

                for (int i = 0; i < this.ListaEquipas.Count; i++)
                {
                    aux += this.ListaEquipas[i].Pais + ",";
                }

                return "Grupo " + Designacao + ": " + aux + "\n" + "\n" + "Equipas repetidas? ";
            }


        }
    }
