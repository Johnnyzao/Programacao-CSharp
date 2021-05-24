using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Programa programa1 = new Programa("feliciano de Granel","Sic Noticias", 60);
            Programa programa2 = new Programa("Casados de Fresc","Sic", 120);
            Programa programa3 = new Programa("Secret story","Tvi", 120);
            Programa programa4 = new Programa("Carro do amor","Tvi", 80);
            Programa programa5 = new Programa("Telejornal","RTP", 180);
            Programa programa6 = new Programa("Noticiario","CMTV", 100);
            label1.Text = "" + programa1 + " " + programa1.CurtaDuracao() + " " + programa1.Iniciais() +
            "\n" + programa2 + " " + programa2.CurtaDuracao() + " " + programa2.Iniciais() +
            "\n" + programa3 + " " + programa3.CurtaDuracao() + " " + programa3.Iniciais() +
            "\n" + programa4 + " " + programa4.CurtaDuracao() + " " + programa4.Iniciais() +
            "\n" + programa5 + " " + programa5.CurtaDuracao() + " " + programa5.Iniciais() +
            "\n" + programa6 + " " + programa6.CurtaDuracao() + " " + programa6.Iniciais() ;
        }
    }
}
