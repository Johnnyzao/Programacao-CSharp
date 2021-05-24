using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int altura = Convert.ToInt32(textBox1.Text);
            int largura = Convert.ToInt32(textBox2.Text);
            int comprimento = Convert.ToInt32(textBox3.Text);

            Paralelepipedo paralelepipedo = new Paralelepipedo(altura, largura, comprimento);

            label4.Text = "" + paralelepipedo;
        }
    }
}
