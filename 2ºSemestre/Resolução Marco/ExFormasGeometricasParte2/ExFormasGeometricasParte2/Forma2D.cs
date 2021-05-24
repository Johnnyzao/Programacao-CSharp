using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFormasGeometricasParte2
{
    abstract class Forma2D : IFormaGeometrica
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Forma2D(string nomeValue)
        {
            Nome = nomeValue;
        }

        public virtual double Area()
        {
            return Area();
        }

        public virtual double Volume()
        {
            return Volume();
        }

        public override string ToString()
        {
            return Nome;
        }
    }

}
