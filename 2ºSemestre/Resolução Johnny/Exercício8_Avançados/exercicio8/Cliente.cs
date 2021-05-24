using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio8
{
    class Cliente
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string apelido;

        public string Apelido
        {
            get { return apelido; }
            set { apelido = value; }
        }

        private string numContribuinte;

        public string NumContribuinte
        {
            get { return numContribuinte; }
            set {if (value.Length == 9)
                {
                    numContribuinte = value.Replace(" ", String.Empty);
                    string aux = value.Substring(1, 2);
                }
                else
                {
                    numContribuinte = value.Replace(" ", String.Empty);
                    numContribuinte = numContribuinte.Substring(0, 9);
                    string aux = value.Substring(1, 2);
                }
            }
        }

        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set {
                if (value.Length == 9)
                {
                    string aux = value.Substring(1, 2);
                    if (aux == "92")
                    {
                        telefone = value;
                    }
                    else
                    {
                        telefone = "O número não começa pelo indicativo 92.";
                    }
                }
                else if (value.Length > 9)
                {
                    telefone = value.Replace("", String.Empty);
                    telefone = telefone.Substring(0, 9);
                    string aux = value.Substring(0, 2);
                    if (aux == "92")
                    {
                        telefone = value;
                    }
                    else
                    {
                        telefone = "O número não começa pelo indicativo 92.";
                    }
                }
                else if (value.Length < 9)
                {
                    telefone = "Telefone Incorreto.";
                }
                }
            }
  
        private int credito;

        public int Credito
        {
            get { return credito; }
            set { credito = value; }
        }

        public Cliente(string _nome, string _apelido, string _numcontribuinte)
        {
            Nome = _nome;
            Apelido = _apelido;
            NumContribuinte = _numcontribuinte;
            Telefone = "000000000";
            Credito = 0;
        }

        public Cliente(string _nome, string _apelido, string _numcontribuinte, string _telefone, int _credito)
        {
            Nome = _nome;
            Apelido = _apelido;
            NumContribuinte = _numcontribuinte;
            Telefone = _telefone;
            Credito = _credito;
        }

        public int VariaCredito(int dinheiro)
        {
            return Credito = dinheiro + credito;
        }

        public bool CreditoPositivo()
        {
            if (Credito > 0)
                return true;
            return false;
        }

        public override string ToString()
        {
            return String.Format("O nome do cliente é {0} e o telefone é {1} e {2}.",Nome,Telefone,NumContribuinte);
        }

        public string CreditoTelefone()
        {
            return String.Format("{0} crédito: {1}", Telefone, Credito);
        }
    }
}
