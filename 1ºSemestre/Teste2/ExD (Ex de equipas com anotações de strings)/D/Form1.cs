using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Ne1 = textBox1.Text;
            string Ne2 = textBox2.Text;
            int golosE1 = Convert.ToInt32(textBox3.Text);
            int golosE2 = Convert.ToInt32(textBox4.Text);
            
            if (golosE1 >= 0 && golosE2 >= 0)
            {
                if (golosE1 > golosE2)
                {
                    label5.Text = Ne1 + ": " + "3 pts" + "\n" + Ne2 + ": " + "0 pts";
                }
                else if (golosE2 > golosE1)
                {
                    label5.Text = Ne2 + ": " + "3 pts" + "\n" + Ne1 + ": " + "0 pts";
                }
                else
                {
                    label5.Text = equipas[0] + ": " + "1 pt" + "\n" + equipas[1] + ": " + "1 pt";
                }
            }
            else
            {
                MessageBox.Show("Insira numeros >= 0");
            }
        }
    }
}
