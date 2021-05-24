using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    class Paralelepipedo
    {
        private int altura;

        public int Altura
        {
            get { return altura; }
            set {
                if (value < 0)
                    altura = 0;
                else altura = value;}
        }

        private int largura;

        public int Largura
        {
            get { return largura; }
            set {
                if (value < 0)
                    largura = 0;
                else largura = value;}
        }

        private int comprimento;

        public int Comprimento
        {
            get { return comprimento; }
            set {
                    if (value < 0)
                        comprimento = 0;
                    else comprimento = value;}
            }

        public Paralelepipedo()
        {
            altura = 0;
            largura = 0;
            comprimento = 0;
        }

        public Paralelepipedo(int a, int l, int c)
        {
            Altura = a;
            Largura = l;
            Comprimento = c;
        }

        public override string ToString()
        {
            return "Volume = " + Volume() + "\nÁrea = " + Area() + "\nCubo = " + EumCubo() + "\n3D = " + Tem3D();
                //base.ToString();
        }

        public int Volume()
        {
            return Altura*Largura*Comprimento;
        }

        public int Area()
        {
            return 2 * (Altura * Largura) + 2 * (Altura * Comprimento) + 2 * (Largura * Comprimento);
        }

        public bool EumCubo()
        {
            if (Altura == Largura && Largura == Comprimento)
                return true;
            else return false;
        }

        public bool Tem3D()
        {
            if (Altura != 0 && Largura != 0 && Comprimento != 0)
                return true;
            else return false;
        }
    }
}
