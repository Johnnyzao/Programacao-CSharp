using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2_Avançados
{
    class Paralelepipedo
    {
        private int altura;

        public int Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        private int largura;

        public int Largura
        {
            get { return largura; }
            set { largura = value; }
        }
        private int comprimento;

        public int Comprimento
        {
            get { return comprimento; }
            set { comprimento = value; }
        }

        public Paralelepipedo()
        {
            Altura = 0;
            Largura = 0;
            Comprimento = 0;
        }

        public Paralelepipedo(int a, int l, int c)
        {
            Altura = a;
            Largura = l;
            Comprimento = c;
        }

        public override string ToString()
        {
            return "Altura = " + Altura + "\nLargura = " + Largura + "\nComprimento = " + Comprimento;
        }



    }
}
