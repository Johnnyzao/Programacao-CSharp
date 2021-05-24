using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestarBicicleta
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

        public Bicicleta() // Construtor vazio
        {
            cor = "";
            Marca = " ";
            Nome = "";
            Peso = 0;
            Compra = new DateTime();
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
            return Nome + "Bicicleta de cor " + Cor + " Marca " + Marca + 
                " comprada em " + Compra.ToShortDateString(); 
        }
    }
}
