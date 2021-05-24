using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFormasGeometricasParte2
{
    class Triangulo : Forma2D
    {
        private double lado1;

        public double Lado1
        {
            get { return lado1; }
            set { lado1 = value; }
        }

        private double lado2;

        public double Lado2
        {
            get { return lado2; }
            set { lado2 = value; }
        }

        private double lado3;

        public double Lado3
        {
            get { return lado3; }
            set { lado3 = value; }
        }

        public Triangulo(string nomeValue, double lado1Value, double lado2Value, double lado3Value) : base(nomeValue)
        {
            Lado1 = lado1Value;
            Lado2 = lado2Value;
            Lado3 = lado3Value;
        }

        public override double Area()
        {
            double p = (this.Lado1 + this.Lado2 + this.Lado3) / 2;
            double conta = p * (p - this.Lado1) * (p - this.Lado2) * (p - this.Lado3);
            return conta > 0 ? Math.Sqrt(Math.Abs(conta)) : 0;
        }

        public override string ToString()
        {
            return "Área do " + base.ToString() + " = " + Area().ToString("#0.00") + "cm2";
        }
    }
}
