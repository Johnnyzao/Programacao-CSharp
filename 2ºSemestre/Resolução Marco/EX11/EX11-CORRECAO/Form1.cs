using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX11_CORRECAO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paragem p1 = new Paragem(1234, "Areosa", ListaConcelhos.Porto);
            Paragem p2 = new Paragem(1234, "Alto", ListaConcelhos.Maia);
            Paragem p3 = new Paragem(1234, "Baixo", ListaConcelhos.Matosinhos);
            Paragem p4 = new Paragem(1234, "Centro", ListaConcelhos.Gaia);

            List<Paragem> lp = new List<Paragem>();
            lp.Add(p1);
            lp.Add(p2);
            lp.Add(p3);
            lp.Add(p4);

            Carreira carr = new Carreira(12, true, false, lp);

            label1.Text = " Carreira " + carr;

        }
    }
}
