using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10
{
    class Automovel
    {
        private string marca;

        public string Marca
        {
            get { return marca; }
            set {
                if (value == "")
                    marca = "N/A";
                else marca = value;
            }
        }

        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set {
                if (value == "")
                    modelo = "N/A";
                else modelo = value;
            }
        }

        private string matricula;

        public string Matricula
        {
            get { return matricula; }
            set {
                if (value == "")
                    matricula = "N/A";
                else matricula = value; }
        }

        private int cilindrada;

        public int Cilindrada
        {
            get { return cilindrada; }
            set {
                if (value < 0)
                    cilindrada = 0;
                else cilindrada = value; }
        }

        private DateTime dataMatricula;

        public DateTime DataMatricula
        {
            get { return dataMatricula; }
            set {
                if (value <= DateTime.MinValue)
                    dataMatricula = new DateTime(1900, 01, 01);
                else dataMatricula = value; }
        }

        public Automovel()
        {
            marca = "";
            modelo = "";
            matricula = "AA-00-00";
            cilindrada = 0;
            dataMatricula = new DateTime(1990, 01, 01);
        }

        public Automovel(string m,string mo,string ma,int c,DateTime dataM)
        {
            Marca = m;
            Modelo = mo;
            Matricula = ma;
            Cilindrada = c;
            DataMatricula = dataM;
        }

        public override string ToString()
        {
            return Marca + " " + Modelo + " " + Matricula + " " + Cilindrada + " " + DataMatricula.ToShortDateString();
        }

        public bool ComparaCarro(Automovel carro)
        {
            if (this.Marca == carro.Marca && this.Modelo == carro.Modelo && this.Matricula == carro.Matricula)
                return true;
            else return false;
        }

        public bool ComparaData(DateTime data)
        {
            if (this.DataMatricula > data)
                return true;
            else return false;
        }
    }
}
