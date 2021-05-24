using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFormaGeometrica
{
    class Circulo : Forma2D
    {
        private double raio;

        public double Raio
        {
            get { return raio; }
            set { raio = value; }
        }

        public Circulo(string nomeValue, double raioValue) : base(nomeValue)
        {
            Raio = raioValue;
        }

        public override double Area()
        {
            return Math.PI * (this.Raio * 2);
        }

        public override string ToString()
        {
            return "Área do " + base.ToString() + " = " + Area().ToString("#0.00") + "cm2";
        }
    }
}
