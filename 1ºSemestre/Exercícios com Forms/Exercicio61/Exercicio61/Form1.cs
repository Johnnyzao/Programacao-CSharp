using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio61 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        string vogais = "aeiou";
        Random aleatorio = new Random();
        private void button1_Click(object sender, EventArgs e) {
            label1.Text = "" + vogais[aleatorio.Next(0, vogais.Length)];
        }
    }
}
