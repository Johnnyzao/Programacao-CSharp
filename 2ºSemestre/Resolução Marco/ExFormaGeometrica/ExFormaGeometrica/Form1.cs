using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExFormaGeometrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circulo circulo = new Circulo("Circulo", 2);
            Quadrado quadrado= new Quadrado("Quadrado", 6);
            Triangulo triangulo= new Triangulo("Triangulo",9,7,14);
            Esfera esfera = new Esfera("Esfera", 10);
            Cilindro cilindro= new Cilindro("Cilindro", 6,5);
            Cubo cubo = new Cubo("Cubo", 5);

            List < FormaGeometrica > listaFormas = new List<FormaGeometrica>();
            listaFormas.Add(circulo);
            listaFormas.Add(quadrado);
            listaFormas.Add(triangulo);
            listaFormas.Add(esfera);
            listaFormas.Add(cilindro);
            listaFormas.Add(cubo);

            foreach (FormaGeometrica li in listaFormas)
            {
                label1.Text += "\n" + li.ToString();
            }
            
        }
    }
}
