using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFormasGeometricasParte2
{
    class Cubo : Forma3D
    {
        private double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public Cubo(string nomeValue, double ladoValue) : base(nomeValue)
        {
            Lado = ladoValue;
        }

        public override double Area()
        {
            return 6 * Math.Pow(this.Lado, 2);
        }

        public override double Volume()
        {
            return Math.Pow(this.Lado, 3);
        }

        public override string ToString()
        {
            return "Área do " + base.ToString() + " = " + Area().ToString("#0.00") + "cm2 " + " / " + "Volume = " + Volume().ToString("#0.00") + "cm3";
        }
    }
}
