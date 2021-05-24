using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEmpresa
{
    class Repositor : Empregado
    {
        private decimal valorPorHora;

        public decimal ValorPorHora
        {
            get { return valorPorHora; }
            set { valorPorHora = value; }
        }

        private int horasTrabalho;

        public int HorasTrabalho
        {
            get { return horasTrabalho; }
            set { horasTrabalho = value; }
        }
        public Repositor(string nomeValue,string nifValue,decimal valorPorHoraValue,int horasTrabalhoValue) : base(nomeValue, nifValue)
        {
            ValorPorHora = valorPorHoraValue;
            HorasTrabalho = horasTrabalhoValue;
        }
        public override string ToString()
        {
            return base.ToString() + " trabalhou " + HorasTrabalho + " horas e recebeu " + ValorPorHora;
        }
        public override decimal Salario()
        {
            return ValorPorHora*HorasTrabalho;
        }

    }
    
    
}
