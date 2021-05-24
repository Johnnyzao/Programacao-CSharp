using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1_v2
{
    class Bicicleta
    {
        private string cor;
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        private int peso;

        public int Peso
        {
            get { return peso; }
            set {
                if (value > 0)
                    peso = value;
                else
                    peso = 10;
            }
        }

        private DateTime compra;

        public DateTime Compra
        {
            get { return compra; }
            set { compra = value; }
        }

        public Bicicleta()  //construtor vazio
        {
            cor = "Branco";
            marca = "Sem Marca";
            nome = "bicicleta";
            peso = 0;
            compra = new DateTime();
        }
        public Bicicleta(string c, string m, string n, int p, DateTime cmp)
        {
            Cor = c;
            Marca = m;
            Nome = n;
            Peso = p;
            Compra = cmp;
        }

       
        public override string ToString()
        {
            return "Bicicleta de cor " + Cor + " marca " + Marca + " nome " + Nome + " comprada em " + Compra.ToShortDateString();
        }
    }
}

