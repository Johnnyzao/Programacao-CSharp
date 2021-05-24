using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio59
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Random rand = new Random();
            int num1 = rand.Next(1, 50);

            int num2 = rand.Next(1, 50);
            while (num2 == num1)
                num2 = rand.Next(1, 50);

            int num3 = rand.Next(1, 50);
            while (num3 == num2 || num3 == num1)
                num3 = rand.Next(1, 50);

            int num4 = rand.Next(1, 50);
            while (num4 == num3 || num4 == num2 || num4 == num1)
                num4 = rand.Next(1, 50);

            int num5 = rand.Next(1, 50);
            while (num5 == num4 || num5 == num3 || num5 == num2 || num5 == num1)
                num5 = rand.Next(1, 50);

            int num6 = rand.Next(1, 50);
            while (num6 == num5 || num6 == num4 || num6 == num3 || num6 == num2 || num6 == num1)
                num6 = rand.Next(1, 50);

            int estrela = rand.Next(1, 14);

            label1.Text = "Números: " + num1 + " " 
                + num2 + " " + num3 + " " 
                + num4 + " " + num5 + " " 
                + num6 + "\n" + "Estrela: " + estrela;

        }
    }
}
