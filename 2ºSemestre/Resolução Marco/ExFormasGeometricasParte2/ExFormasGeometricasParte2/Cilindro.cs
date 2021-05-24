using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFormasGeometricasParte2
{
    class Cilindro : Forma3D
    {
        private double raio;

        public double Raio
        {
            get { return raio; }
            set { raio = value; }
        }

        private double altura;

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public Cilindro(string nomeValue, double raioValue, double alturaValue) : base(nomeValue)
        {
            Raio = raioValue;
            Altura = alturaValue;
        }

        public override double Area()
        {
            return 2 * Math.PI * this.Raio * (this.Raio + this.Altura);
        }

        public override double Volume()
        {
            return Math.PI * Math.Pow(this.Raio, 2) * this.Altura;
        }

        public override string ToString()
        {
            return "Área do " + base.ToString() + " = " + Area().ToString("#0.00") + "cm2 " + " / " + "Volume = " + Volume().ToString("#0.00") + "cm3";
        }
    }
}
