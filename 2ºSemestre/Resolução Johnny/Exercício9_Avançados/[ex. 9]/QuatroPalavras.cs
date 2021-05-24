using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ex._9_
{
    class QuatroPalavras
    {
        private List<string> wordsList;

        public List<string> WordsList
        {
            get { return wordsList; }
            set { wordsList = value; }
        }

        public QuatroPalavras()
        {
            WordsList[0] = "";
            WordsList[1] = "";
            WordsList[2] = "";
            WordsList[3] = "";
        }

        public QuatroPalavras(List<string> a)
        {
            WordsList = a;

            for (int i = 0; i < WordsList.Count; i++)
            {
                WordsList[i] = WordsList[i].Replace(" ", String.Empty).ToLower();
            }
        }

        public QuatroPalavras(string a, string b, string c, string d)
        {
            WordsList[0] = a;
            WordsList[1] = b;
            WordsList[2] = c;
            WordsList[3] = d;
        }

        public void SetPalavra(string pal, int numero)
        {
            if (numero <= WordsList.Count)
                WordsList[numero] = pal;
            else
                throw new System.ArgumentException("O valor indicado está fora dos limites", "Erro");
        }

        public string GetPalavra(int numero)
        {
            if (numero <= WordsList.Count)
                return WordsList[numero];
            return "";
        }

        public bool TodasIguais()
        {
            if (WordsList.Distinct().Count() == 1)
                    return true;
            return false;
        }

        public bool TodasDiferentes()
        {
            if (WordsList.Distinct().Count() == 4)
                return true;
            return false;
        }

        public bool HaDuasIguais()
        {
            if (WordsList.Distinct().Count() <= 3)
                return true;
            return false;
        }

        public override string ToString()
        {
            return String.Join(" ", WordsList);
        }
    }
}
