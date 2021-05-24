using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEquipaFutebol
{
    abstract class Elemento
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string nacionalidade;

        public string Nacionalidade
        {
            get { return nacionalidade; }
            set { nacionalidade = value; }
        }

        private string numInscricao;

        public string NumInscricao
        {
            get { return numInscricao; }
            set { numInscricao = value; }
        }

        private int salario;

        public int Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        private DateTime dataInicioContrato;

        public DateTime DataInicioContrato
        {
            get { return dataInicioContrato; }
            set { dataInicioContrato = value; }
        }

        private DateTime dataFimContrato;

        public DateTime DataFimContrato
        {
            get { return dataFimContrato; }
            set { dataFimContrato = value; }
        }

        private DateTime dataNascimento;

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public Elemento(string nomeValue, string nacionalidadeValue, string numInscricaoValue, int salarioValue,DateTime dataInicioContratoValue,DateTime dataFimContratoValue,DateTime dataNascimentoValue)
        {
            Nome = nomeValue;
            Nacionalidade = nacionalidadeValue;
            NumInscricao = numInscricaoValue;
            Salario = salarioValue;
            DataInicioContrato = dataInicioContratoValue;
            DataFimContrato = dataFimContratoValue;
            DataNascimento = dataNascimentoValue;
        }

        public override string ToString()
        {
            return "Nome : " + Nome + "\nNacionalidade : " + Nacionalidade + "\nNúmero Inscrição : " + NumInscricao + "\nSalário : " + Salario +
                "\nData Inicio Contrato : " + DataInicioContrato + "\nData Fim Contrato : " + DataFimContrato + "\nData Nascimento : " + DataNascimento;
        }


    }
}
