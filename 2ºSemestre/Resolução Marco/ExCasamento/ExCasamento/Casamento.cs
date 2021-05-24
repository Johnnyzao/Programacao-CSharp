using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCasamento
{
    class Casamento
    {
        private string local;

        public string Local
        {
            get { return local; }
            set { local = value; }
        }

        private DateTime dataHora;

        public DateTime DataHora
        {
            get { return dataHora; }
            set { dataHora = value; }
        }

        private Noivo noivo;

        public Noivo Noivo
        {
            get { return noivo; }
            set { noivo = value; }
        }

        private Noivo noiva;

        public Noivo Noiva
        {
            get { return noiva; }
            set { noiva = value; }
        }

        private Padre padre;

        public Padre Padre
        {
            get { return padre; }
            set { padre = value; }
        }

        private List<Convidado> listaConvidados;

        public List<Convidado> ListaConvidados
        {
            get { return listaConvidados; }
            set { listaConvidados = value; }
        }

        public Casamento(string localValue, DateTime dataHoraValue, Noivo noivoValue, Noivo noivaValue, Padre padreValue,
            List<Convidado> listaConvidadosValue)
        {
            Local = localValue;
            DataHora = dataHoraValue;
            Noivo = noivoValue;
            Noiva = noivaValue;
            Padre = padreValue;
            ListaConvidados = listaConvidadosValue;
        }

        public override string ToString()
        {
            string aux = "";

            for (int i = 0; i < ListaConvidados.Count; i++)
            {
                aux += ListaConvidados[i].PrimeiroNome + " ";
            }
            return "\nCasamento de " + Noivo.PrimeiroNome + " e " + Noiva.PrimeiroNome + ", realizado no dia " +
                DataHora.ToShortDateString() + ", pelo padre " + Padre.PrimeiroNome + " " + Padre.UltimoNome +
                ", na igreja de " + Local + "\nConvidados : " + aux;
        }

        public int DiferencaIdades(int idadeNoivo, int idadeNoiva)
        {
            return Math.Abs(idadeNoivo - idadeNoiva);
        }
    }
}
