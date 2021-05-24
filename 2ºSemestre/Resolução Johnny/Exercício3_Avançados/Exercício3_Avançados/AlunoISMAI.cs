using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício3_Avançados
{
    enum CursoIsmai
    {
        IG,
        RSI,
        TPSI,
        Psicologia,
        Naodefinido
    }
    class AlunoISMAI
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private int numero;

        public  int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private string ano;

        public string  Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        private CursoIsmai cursos;

        public CursoIsmai Cursos
        {
            get { return cursos; }
            set { cursos = value; }
        }

        public AlunoISMAI(string n, int num, string a, CursoIsmai c)
        {
            Nome = n;
            Numero = num;
            Ano = a;
            Cursos = c;
        }
        public AlunoISMAI()
        {
            Nome = "";
            Numero = 0;
            Ano = "";
            Cursos = CursoIsmai.Naodefinido;
        }
        public bool ChegouAntes(AlunoISMAI a)
        {
            if (this.numero < a.numero)
                return true;
            else
                return false;
        }

        public string PrimeiroUltimoNome(AlunoISMAI al)
        {
            string nomeal = al.Nome;
            string[] primeiro = nomeal.Split(' ');
            return "" + primeiro[0] + " " + primeiro[primeiro.Length - 1];

        }

        public override string ToString()
        {
            return Nome + " Nº: " + Numero + "," + Ano + Cursos;
        }        

    }

    
}
