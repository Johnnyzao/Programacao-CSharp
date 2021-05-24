using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    class Aluno
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private int ano;

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        private string curso;

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        public Aluno(string n,int num,int a,string c)
        {
            Nome = n;
            Numero = num;
            Ano = a;
            Curso = c;
        }

        public override string ToString()
        {
            return "Nome : " + Nome + "\nNúmero : " + Numero + "\nAno : " + Ano + "º" + "\nCurso : " + Curso;
        }

        public bool ChegouAntes(Aluno a)
        {
            if (this.Numero > a.Numero)
                return false;
            else return true;
        }

        public string PrimeiroUltimoNome()
        {
            string fullName = nome;
            string[] names = fullName.Split(' ');
            return "" + names[0] + " " + names[names.Length - 1]; 
        }
    }
}
