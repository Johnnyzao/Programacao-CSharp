using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5
{
    class Fracao
    {
        private int numerador;

        public int Numerador
        {
            get { return numerador; }
            set { numerador = value; }
        }
        private int denominador;

        public int Denominador
        {
            get { return denominador; }
            set { denominador = value; }
        }
        public Fracao(int num, int den)
        {
            for (int i = num; i >= 2; i--)
            {
                if(den%i==0 && num%i==0)
                {
                    num /= i;
                    den /= i;
                }

            }
            Numerador = num;
            Denominador = den;
        }
        public Fracao Multiplica(Fracao frac)
        {
            return (new Fracao(this.Numerador * frac.Numerador, this.Denominador * frac.Denominador));
        }
        public Fracao Divisao(Fracao frac)
        {
            return (new Fracao(this.Numerador* frac.Denominador, this.Denominador * frac.Numerador));
        }
        public Fracao Soma(Fracao frac)
        {
            return (new Fracao((this.Numerador * frac.Denominador + frac.Numerador * this.Denominador), this.Denominador * frac.Denominador));
        }
        public Fracao Subtracao(Fracao frac)
        {
            return (new Fracao((this.Numerador * frac.Denominador - frac.Numerador * this.Denominador), this.Denominador * frac.Denominador));
        }
        public override string ToString()
        {
            if (Numerador == 0)
              return "0";
            if (Denominador == 1)
            return "" + Numerador;
            else
            return "" + Numerador + "/" + Denominador; 
        }
        
    }
}
