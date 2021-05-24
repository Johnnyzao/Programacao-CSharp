using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFormaGeometrica
{
    class Esfera : Forma3D
    {
        private double raio;

        public double Raio
        {
            get { return raio; }
            set { raio = value; }
        }

        public Esfera(string nomeValue, double raioValue) : base(nomeValue)
        {
            Raio = raioValue;
        }

        public override double Area()
        {
            return 4 * Math.PI * Math.Pow(this.Raio,2);
        }

        public override double Volume()
        {
            return 4.0/3.0 * Math.PI * Math.Pow(this.Raio,3);
        }

        public override string ToString()
        {
            return "Área do " + base.ToString() + " = " + Area().ToString("#0.00") + "cm2 " + " / " + "Volume = " + Volume().ToString("#0.00") + "cm3" ;
        }
    }
}
