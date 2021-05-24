using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício12_Avançados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Equipa e1 = new Equipa(ListaPaises.Portugal, 23, DateTime.Now);
            Equipa e2 = new Equipa(ListaPaises.Franca, 15, DateTime.Now);
            Equipa e3 = new Equipa(ListaPaises.Alemanha, 95, DateTime.Now);
            Equipa e4 = new Equipa(ListaPaises.Portugal, 2, DateTime.Now);

            List<Equipa> le = new List<Equipa>();

            le.Add(e1);
            le.Add(e2);
            le.Add(e3);
            le.Add(e4);

            Grupo g1 = new Grupo('C', le);

            int comparar = e1.ComparaRankings(e2);
            bool repetidas = g1.EquipasRepetidas(e1);

            label1.Text = "Equipa 1: " + "\n" + e1 + "\n";
            label1.Text += "\n" + "Equipa 2: " + "\n" + e2 + "\n";
            label1.Text += "\n" + "Diferenca de ranking: " + comparar + "\n";
            label1.Text += "\n" + g1;
            label1.Text += "" + repetidas;    }
    }
}
