using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFormaGeometrica
{
    public abstract class FormaGeometrica
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public FormaGeometrica(string nomeValue)
        {
            Nome = nomeValue;
        }

        public override string ToString()
        {
            return Nome;
        }

        public virtual double Area()
        {
            return Area();
        }

        public virtual double Volume()
        {
            return Volume();
        }

    }
}
