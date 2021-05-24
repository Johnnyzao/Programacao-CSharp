using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4
{
    class Disciplina
    {
        private int nome;

        public int Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int cargaHoraria;

        public int CargaHoraria
        {
            get { return cargaHoraria; }
            set {
                if (value < 0 || value > 8)
                    cargaHoraria = 0;
                else cargaHoraria = value;
            }
        }

        private int nomeDocente;

        public int NomeDocente
        {
            get { return nomeDocente; }
            set { nomeDocente = value; }
        }

        private int nomeCurso;

        public int NomeCurso
        {
            get { return nomeCurso; }
            set { nomeCurso = value; }
        }

        private int numeroAlunos;

        public int NumeroAlunos
        {
            get { return numeroAlunos; }
            set { numeroAlunos = value; }
        }


        public Disciplina()
        {

        }
        public Disciplina()
        {

        }
    }
}
