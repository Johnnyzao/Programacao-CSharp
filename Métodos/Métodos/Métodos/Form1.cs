using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Métodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Alguém premiu o botão");
            Trofa();
            listBox1.Items.Add("Voltei da Trofa para o botão!");
        }

        void Trofa()
        {
            listBox1.Items.Add("Estou na Trofa!");
            Paris();
            listBox1.Items.Add("Estou outra vez na Trofa!");
        }

        void Paris()
        {
            listBox1.Items.Add("Estou em Paris!");
        }
    }
}
