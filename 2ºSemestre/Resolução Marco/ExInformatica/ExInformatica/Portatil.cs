using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExInformatica
{
    class Portatil : Informatica
    {
        private string processador;

        public string Processador
        {
            get { return processador; }
            set { processador = value; }
        }

        private double velocidadeProcessador;

        public double VelocidadeProcessador
        {
            get { return velocidadeProcessador; }
            set { velocidadeProcessador = value; }
        }

        private decimal ecra;

        public decimal Ecra
        {
            get { return ecra; }
            set
            {
                if (value < 0)
                    ecra = 0;
                else ecra = value;
            }
        }

        public Portatil(string marcaValue,DateTime dataCompraValue, string processadorValue, double velocidadeProcessadorValue, decimal ecraValue) : base(marcaValue,dataCompraValue)
        {
            Processador = processadorValue;
            VelocidadeProcessador = velocidadeProcessadorValue;
            Ecra = ecraValue;
        }

        public override string ToString()
        {
            return base.ToString() + "\nProcessador : " + Processador + "\nVelocidade do Processador : " + VelocidadeProcessador + " Ghz\nEcrã : " + Ecra;
        }


    }
}
