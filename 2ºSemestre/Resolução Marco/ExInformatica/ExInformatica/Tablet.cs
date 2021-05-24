using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExInformatica
{
    class Tablet : Informatica
    {
        private decimal ecra;

        public decimal Ecra
        {
            get { return ecra; }
            set { if (value < 0)
                    ecra = 0;
                else ecra = value; }
        }

        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public Tablet(string marcaValue,DateTime dataCompraValue,decimal ecraValue, string modeloValue) : base(marcaValue,dataCompraValue)
        {
            Ecra = ecraValue;
            Modelo = modeloValue;
        }

        public override string ToString()
        {
            return "\n" + base.ToString() + "\nModelo : " + Modelo + "\nEcrã : " + Ecra;
        }

    }
}
