using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    class Rectangulo
    {
        private int largura;

        public int Largura
        {
            get { return largura; }
            set {
                if (value <= 0 || value > 20)
                    largura = 1;
                else largura = value; }
        }
        private int comprimento;

        public int Comprimento
        {
            get { return comprimento; }
            set {
                if (value <= 0 || value > 20)
                    comprimento = 1;
                else comprimento = value;
            }
        }

        public Rectangulo()
        {
            Largura = 1;
            Comprimento = 1;
        }
        public Rectangulo(int l, int c)
        {
            Largura = l;
            Comprimento = c;
        }
        public override string ToString()
        {
            return "Largura : " + Largura + "\n" + "Comprimento : " + Comprimento;
        }
        public int Perimetro()
        {
            return (Largura * 2) + (Comprimento * 2);
        }
        public int Area()
        {
            return Largura * Comprimento;
        }
        public bool Quadradro()
        {
            if (Largura == Comprimento)
            {
                return true;
            }
            else return false;
        }
    }
}
