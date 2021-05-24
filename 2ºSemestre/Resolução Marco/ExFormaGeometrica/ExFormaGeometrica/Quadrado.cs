using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFormaGeometrica
{
    class Quadrado : Forma2D
    {
        private double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public Quadrado(string nomeValue,double ladoValue) : base(nomeValue)
        {
            Lado = ladoValue;
        }

        public override double Area()
        {
            return Lado * Lado;
        }

        public override string ToString()
        {
            return "Área do " + base.ToString() + " = " + Area().ToString("#0.00") + "cm2";
        }
    }
}
