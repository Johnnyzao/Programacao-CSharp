using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExInformatica
{
    public abstract class Informatica
    {
        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private DateTime dataCompra;

        public DateTime DataCompra
        {
            get { return dataCompra; }
            set { if (value >= DateTime.Now)
                    dataCompra = DateTime.Now;
            else dataCompra = value; }
        }

        public Informatica(string marcaValue, DateTime dataCompraValue)
        {
            Marca = marcaValue;
            DataCompra = dataCompraValue;
        }

        public override string ToString()
        {
            return "Marca : " + Marca + "\nData de Compra : " + DataCompra.ToShortDateString(); 
        }


    }
}
