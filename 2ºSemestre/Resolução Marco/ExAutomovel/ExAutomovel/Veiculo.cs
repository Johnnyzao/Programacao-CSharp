using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAutomovel
{
    class Veiculo
    {
        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private DateTime dataMatricula;

        public DateTime DataMatricula
        {
            get { return dataMatricula; }
            set { dataMatricula = value; }
        }

        private string matricula;

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public Veiculo(string mr, DateTime dm, string mat)
        {
            Marca = mr;
            DataMatricula = dm;
            Matricula = mat;
        }
        public override string ToString()
        {
            return Marca + " de " + DataMatricula.ToShortDateString() + " " + Matricula;
        }
    }
}
