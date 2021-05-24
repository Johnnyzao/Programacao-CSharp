using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
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
            int n = Convert.ToInt32(textBox1.Text);
            n++;
            bool flag = false;
            while(flag==false)
            {
                if(n%3==0)
                {
                    label1.Text = n.ToString();
                    flag = true;
                }
                else
                {
                    n++;
                }
               
            }
        }
    }
}
