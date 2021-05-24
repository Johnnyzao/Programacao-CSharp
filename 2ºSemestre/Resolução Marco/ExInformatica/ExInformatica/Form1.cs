using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExInformatica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Portatil portatil = new Portatil("HP", new DateTime (2019, 05, 25), "Intel i7", 3.2,new decimal(15.6));
            Tablet tablet = new Tablet("LENOVO", new DateTime(2018, 07, 21), new decimal(-10.1), "YXR-10");
            Impressora impressora = new Impressora("CANON", new DateTime(2010, 11, 03), TipoImpressora.Inkjet, TipoTinta.Cor);

            List<Informatica> listaEquipamentos = new List<Informatica>();
            listaEquipamentos.Add(portatil);
            listaEquipamentos.Add(tablet);
            listaEquipamentos.Add(impressora);

            Funcionario funcionario = new Funcionario("Marco", new DateTime(1998, 11, 25), "512413",listaEquipamentos);

            label1.Text = "" + funcionario;
        }
    }
}
