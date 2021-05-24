using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Equipa porto = new Equipa("Porto"," Portugal",1,new DateTime(2019,04,16));
            Equipa benfica = new Equipa("Benfica"," Moçambique", 10, new DateTime(2018, 011, 10));
            Equipa sporting = new Equipa("Sporting"," Inglaterra", 15, new DateTime(2018, 10, 01));
            Equipa tondela = new Equipa("Portooo", " Portugal", 1, new DateTime(2019, 04, 16));

            List<Equipa> ep = new List<Equipa>();
            ep.Add(porto);
            ep.Add(benfica);
            ep.Add(sporting);
            ep.Add(tondela);

            Grupo grupo = new Grupo(DesignacaoGrupo.C,ep);

            label1.Text = "" + porto + "\n" + benfica + "\n" + sporting + "\n" + tondela +"\nDiferença Ranking : "
                + porto.ComparaRanking(benfica) + "\n" + grupo + "\nEquipas repetidas : " + grupo.EquipasRepetidas();



        }
    }
}
