using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX6
{
    class Computador
    {
        private string marca;

        public string Marca
        {
            get { return marca; }
            set {
                if (value == "")
                    marca = "N/A";
                else marca = value;
            }
        }

        private string processador;

        public string Processador
        {
            get { return processador; }
            set {
                if (value == "")
                    processador = "N/A";
                else processador = value;
            }
        }

        private int velocidade;

        public int Velocidade
        {
            get { return velocidade; }
            set {
                if (value < 0)
                    velocidade = 0;
                else velocidade = value;
            }
        }

        private string monitor;

        public string Monitor
        {
            get { return monitor; }
            set{
                if (value == "")
                    monitor = "N/A";
                else monitor = value;
            }
        }
        public Computador()
        {
            marca = "";
            processador = "";
            velocidade = 0;
            monitor = "";
        }
        public Computador(string m,string p, int v, string mo)
        {
            Marca = m;
            Processador = p;
            Velocidade = v;
            Monitor = mo;
        }

        public override string ToString()
        {
            return Marca + " " + Processador + " " + Velocidade + " " + Monitor;
        }

        public int ComparaComputador(Computador pc)
        {
            if (this.Velocidade == pc.Velocidade)
                return 0;
            else if (this.Velocidade > pc.Velocidade)
                return -1;
            else return 1;
        }
    }
}
