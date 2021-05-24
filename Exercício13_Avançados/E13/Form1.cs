using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btt_go_Click(object sender, EventArgs e)
        {
            Jogador j1 = new Jogador("Gustavo",20,new DateTime(2000,7,28));
            Jogador j2 = new Jogador("Gama",2,new DateTime(1999,3,18));
            Jogador j3 = new Jogador("Calisto",16,new DateTime(2000,9,8));
            Jogador j4 = new Jogador("Joao",21,new DateTime(1990,2,15));
            Jogador j5 = new Jogador("Diogo",1,new DateTime(1930,7,28));

            List <Jogador> lj = new List<Jogador>();

            lj.Add(j1);
            lj.Add(j2);
            lj.Add(j3);
            lj.Add(j4);
            lj.Add(j5);

            Equipa eq = new Equipa("Portugal", "Carapau", lj);

            lbl_res.Text = "" + eq;
            lbl_res.Text += "\n\n" + j1;
            lbl_res.Text += "\n\nMedia das Idades: " + eq.MediaIdades();
            lbl_res.Text += "\n\nCamisolas Repetidas? " + eq.Verifica();
        }
    }
}
