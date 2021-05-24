using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFormaGeometrica
{
    abstract class Forma2D : FormaGeometrica
    {

        public Forma2D(string nomeValue) :  base(nomeValue)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
