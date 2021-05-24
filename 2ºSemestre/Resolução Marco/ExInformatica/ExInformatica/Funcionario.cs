using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExInformatica
{
    class Funcionario
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private DateTime dataNascimento;

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { if (value > DateTime.Now)
                    dataNascimento = DateTime.Now;
            else dataNascimento = value; }
        }

        private string bi;

        public string Bi
        {
            get { return bi; }
            set { bi = value; }
        }

        private List<Informatica> listaEquipamentos;

        public List<Informatica> ListaEquipamentos
        {
            get { return listaEquipamentos; }
            set { listaEquipamentos = value; }
        }


        public Funcionario(string nomeValue, DateTime dataNascimentoValue, string biValue, List<Informatica> listaEquipamentosValue)
        {
            Nome = nomeValue;
            DataNascimento = dataNascimentoValue;
            Bi = biValue;
            ListaEquipamentos = listaEquipamentosValue;
        }

        public override string ToString()
        {
            string aux = "";

            for (int i = 0; i < ListaEquipamentos.Count; i++)
            {
                aux += ListaEquipamentos[i] + "\n";
            }
            return "Nome : " + Nome + "\nData de Nascimento : " + DataNascimento.ToShortDateString() + "\nBi : " + Bi + "\n" + "\n" + aux;
        }
    }
}
