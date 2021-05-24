using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestarBicicleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string corBici = textBox1.Text;
            string marcaBici = textBox3.Text;
            string nomeBici = textBox2.Text;
            int pesoBici = Convert.ToInt32(textBox4.Text);
            DateTime dataBici = dateTimePicker1.Value;

            Bicicleta minhaBicicleta = new Bicicleta("Branco", "Ginga", "Amélia",15,new DateTime(2019,1,12));

            Bicicleta outraBicicleta = new Bicicleta(corBici, marcaBici,nomeBici, pesoBici, dataBici);

            label5.Text = "" + minhaBicicleta + "\n" + outraBicicleta;

            minhaBicicleta.Cor = "Amarelo";
            minhaBicicleta.Nome = "Joana";

            label6.Text = "Nova Bike : " + minhaBicicleta;
        }
    }
}
