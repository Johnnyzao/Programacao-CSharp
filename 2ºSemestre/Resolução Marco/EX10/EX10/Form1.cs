using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime data = new DateTime(2020, 11, 25);
            Automovel carro1 = new Automovel("Ferrari", "350GTO", "XX-78-23", 2500,new DateTime(2019,01,01));
            Automovel carro2 = new Automovel("", "", "",-1000,new DateTime());
            Automovel carro3 = new Automovel("Renault","Megane", "10-JI-85",2500,new DateTime(2010,06,10));
            Automovel carro4 = new Automovel("Ferrari", "350GTO", "XX-78-23", 3200, new DateTime(2011, 12, 21));


            label1.Text = "" + carro1 + "\n" + carro2 + "\n" + carro3;
            label2.Text = "" + carro1.ComparaData(data) + "\n" + carro1.ComparaCarro(carro4);
        }
    }
}
