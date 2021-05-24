using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPessoaArvore
{
    class Arvore : IIdade
    {
        int anoPlantacao;

        public int Idade
        {
            get { return DateTime.Today.Year - anoPlantacao; }
        }
        private string especie;

        public string Nome
        {
            get { return especie; }
            set { especie = value; }
        }

        private decimal altura;

        public decimal Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public Arvore(int anoPlantacaoValue, string especieValue,decimal alturaValue)
        {
            anoPlantacao = anoPlantacaoValue;
            Nome = especieValue;
            Altura = alturaValue;
        }

        public override string ToString()
        {
            return "Espécie " + Nome + " Idade " + Idade;
        }
    }
}
