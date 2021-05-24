using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Métodos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string nome2 = textBox2.Text;
            Trofa(nome, nome2);
        }

        void Trofa(string viajante, string passageiro)
        {
            listBox1.Items.Add(viajante + " e " + passageiro + " na Trofa!");
            listBox1.Items.Add(viajante + " e " + passageiro + " de novo na Trofa!");
        }
    }
}
