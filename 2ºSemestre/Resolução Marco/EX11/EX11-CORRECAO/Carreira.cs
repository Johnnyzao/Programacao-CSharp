using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11_CORRECAO
{
    class Carreira
    {
        private int num;

        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        private bool servoNoturno;

        public bool ServoNoturno
        {
            get { return servoNoturno; }
            set { servoNoturno = value; }
        }

        private bool servoFDS;

        public bool ServoFDS
        {
            get { return servoFDS; }
            set { servoFDS = value; }
        }
        private List<Paragem> listaParagens;

        public List<Paragem> ListaParagens
        {
            get { return listaParagens; }
            set { listaParagens = value; }
        }
        public Carreira(int n, bool not, bool fds, List<Paragem> lp)
        {
            Num = n;
            ServoNoturno = not;
            ServoFDS = fds;
            ListaParagens = lp;

        }
        public override string ToString()
        {
            return "" + Num + " " + ListaParagens.First().Nome + " " + ListaParagens.Last().Nome;
        }
    }
}
