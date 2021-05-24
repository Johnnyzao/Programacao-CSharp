using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo1_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string corBicicleta = textBox1.Text;
            string nomeBicicleta = textBox2.Text;
            string marcaBicicleta = textBox3.Text;
            int pesoBicicleta = int.Parse(textBox4.Text);
            DateTime dataBicicleta = dateTimePicker1.Value;

            Bicicleta minhaBicicleta = new Bicicleta(" Branco ", " Ginga ", " Amélia ", 15, new DateTime(2019, 1, 12));

            Bicicleta outraBicicleta = new Bicicleta(corBicicleta, marcaBicicleta, nomeBicicleta, pesoBicicleta, dataBicicleta);
            label5.Text = " " + minhaBicicleta + "\n" + outraBicicleta;

            minhaBicicleta.Cor = "Amarelo";
            minhaBicicleta.Nome="Joana";
            label6.Text = "Nova Bike: " + minhaBicicleta;
        }
    }
}
