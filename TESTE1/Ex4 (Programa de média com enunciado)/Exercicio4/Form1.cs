using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBox1.Text);
            int n2 = Convert.ToInt32(textBox2.Text);
            int n3 = Convert.ToInt32(textBox3.Text);
            double media = 0.0;
            int[] arr= { n1, n2, n3 };

            if (arr.Min() < 10)
            {
                media = ((arr.Sum()) - arr.Min()) / 2.0;
            }
            else
            {
                media = arr.Sum() / 3.0;
            }
           
            media = Math.Round(media, 1);
            label4.Text = "Media: " + media;
        }
    }
}
