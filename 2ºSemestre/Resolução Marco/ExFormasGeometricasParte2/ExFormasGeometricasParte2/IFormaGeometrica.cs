using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFormasGeometricasParte2
{
    interface IFormaGeometrica
    {
        string Nome { get; }
        double Area();
        double Volume();
        string ToString();
    }
}
