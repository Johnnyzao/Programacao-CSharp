using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1
{
    class Bicicleta
    {
        private string cor;
        private string marca;
        private string nome;
        private int peso;
        private DateTime compra;

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
            cor = c;
            marca = m;
            nome = n;
            peso = p;
            compra = cmp;
        }

        public void Pinta (string novaCor)
        {
            cor = novaCor;
        }

        public void Batiza (string novoNome)
        {
            nome = novoNome;
        }

        public override string ToString()
        {
            return "Bicicleta de cor " + cor + " marca " + marca + " nome " + nome + " comprada em " + compra.ToShortDateString();
        }
    }
}
