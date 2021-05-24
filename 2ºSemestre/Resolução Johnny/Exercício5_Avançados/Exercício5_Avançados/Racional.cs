using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício5_Avançados
{
    class Racional
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

        public Racional(int num, int den)
        {
            for (int i = num; i >= 2; i--)
            {
                if(den%i==0 && num % i == 0)
                {
                    num /= i;
                    den /= i;
                }
            }
            Denominador = den;
            Numerador = num;
        }
        public Racional Multiplica(Racional frac)
        {
            return (new Racional(this.Numerador * frac.Numerador, this.Denominador * frac.Denominador));
        }

        public Racional Soma (Racional frac)
        {
            if (this.Denominador == frac.Denominador)
            {
                return (new Racional(this.Numerador + frac.Numerador, frac.Denominador));
            }
            return (new Racional(this.Numerador + frac.Numerador, this.Denominador * frac.Denominador));
        }
        public Racional Subtracao (Racional frac)
        {
            return (new Racional(this.Numerador * frac.Denominador - this.Denominador * frac.Numerador, this.Denominador * frac.Denominador));
        }

        public Racional Divisao (Racional frac)
        {
            return (new Racional(this.Numerador * frac.Denominador, this.Denominador * frac.Numerador));
        }
        public Racional Reducao(Racional frac)
        {
            for (int i = this.Numerador; i > 1; i++)
            {

                int num = this.Numerador / i;
                int den = this.Denominador /= i;


                
            }
            return (frac);
        }
        public Racional Reducao2(Racional frac)
        {
            for (int i = frac.Numerador; i > 1; i++)
            {

                int num = frac.Numerador / i;
                int den = frac.Denominador /= i;



            }
            return (frac);
        }
        public override string ToString()
        {
            if (Denominador == 1)
                return "" + Numerador;
            else if (Numerador == 0)
                return "0";
            else
                return "" + Numerador + "/" + Denominador;
        }


    }
}
