using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12
{
    enum DesignacaoGrupo
    {
        A,
        B,
        C,
        D,
        E,
        F,
        G,
        H
    }
    
    class Grupo
    {
        private DesignacaoGrupo designacao;

        public DesignacaoGrupo Designacao
        {
            get { return designacao; }
            set { designacao = value; }
        }

        private List<Equipa> equipasParticipantes;

        public List<Equipa> EquipasParticipantes
        {
            get { return equipasParticipantes; }
            set { equipasParticipantes = value; }
        }

        public Grupo(DesignacaoGrupo d, List<Equipa> ep)
        {
            Designacao = d;
            EquipasParticipantes = ep;
        }

        public override string ToString()
        {
            return "Grupo " + Designacao + " : " + EquipasParticipantes[0].Nome + " " + EquipasParticipantes[1].Nome + " "
                + EquipasParticipantes[2].Nome + " " + EquipasParticipantes[3].Nome;
        }

        public bool EquipasRepetidas()
        {
            bool duasIguais = false;
            for (int i = 0; i < EquipasParticipantes.Count;i++)
            {
                for (int j = 0; j < EquipasParticipantes.Count; j++)
                {
                    if (EquipasParticipantes[0].Nome == EquipasParticipantes[j].Nome)
                        duasIguais = true;
                }
            }
            return duasIguais;
        }
    }
}
