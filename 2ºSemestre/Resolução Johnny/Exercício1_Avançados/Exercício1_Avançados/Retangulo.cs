using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício1_Avançados
{
    class Retangulo
    {
        private int largura;

        public int Largura
        {
            get { return largura; }
            set
            {
                if (value > 0)
                    largura = value;
                else
                    largura = 1;
            }
        }

        private int comprimento;

        public int Comprimento
        {
            get { return comprimento; }
            set {
                if (value > 0)
                    comprimento = value;
                else
                    comprimento = 20;
            }

        }

        public bool Quadrado()
        {
            if (Largura == Comprimento)
                return (true);

            return (false);
        }
        public int Area()
        {
            return Largura * Comprimento;
        }
        public int Perimetro()
        {
            return 2*(Largura + Comprimento);
        }


        public Retangulo()
        {
            Largura = 0;
            Comprimento = 0;
        }

        public Retangulo(int l, int c )
        {
            Largura=l;
            Comprimento=c;
        }
        

        public override string ToString()
        {
            return "Largura = " + Largura + "\n Comprimento = " + Comprimento;
        }

    }
}
