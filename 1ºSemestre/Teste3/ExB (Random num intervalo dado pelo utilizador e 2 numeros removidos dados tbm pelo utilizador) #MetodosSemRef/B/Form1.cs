using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double aleatorio(int a1,int b1,int x1,int y1)
        {
            if (a1 == b1)
                return 0;

            if (x1 == a1 + 1 && y1 == a1 + 2)
                return 0;
         
            

            Random random = new Random();
            int maximum = Math.Max(a1, b1);
            int minimum = Math.Min(a1, b1);
            bool flag = false;
            double al=0;
            while (flag == false)
            {
                 al = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 0);
                if (al != x1 && al != y1)
                {
                    flag = true;
                }
                
            }
            return al;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int x = Convert.ToInt32(textBox3.Text);
            int y = Convert.ToInt32(textBox4.Text);

            label5.Text = "Nº: " + aleatorio(a, b, x, y);
            
        }
    }
}
