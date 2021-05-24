using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExCasamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Noivo noivo = new Noivo("Diogo", "Castro", new DateTime(1999, 08, 27), Sexo.Masculino);
            Noivo noiva = new Noivo("Ricardo", "Cunha", new DateTime(1998, 04, 12), Sexo.Feminino);

            Padre padre = new Padre("Filipe", "Teixeira", "Gueifães");

            Convidado convidado1 = new Convidado("Marco", "Martins", tipoConvidado.Musico, lado.Noivo, Sexo.Masculino);
            Convidado convidado2 = new Convidado("Diogo", "Magalhães", tipoConvidado.Madrinha, lado.Noiva, Sexo.Feminino);

            List<Convidado> listaConvidados = new List<Convidado>();
            listaConvidados.Add(convidado1);
            listaConvidados.Add(convidado2);

            Casamento casamento = new Casamento("Nogueira", new DateTime(),noivo,noiva,padre,listaConvidados);

            label1.Text = "Noivo : " + noivo + "\nNoiva : " + noiva + "\nPadre : " + padre + "\nConvidados" + "\n"
                + casamento + "\nDiferença de Idades : " + casamento.DiferencaIdades(noivo.Idade(),noiva.Idade());
        }
    }
}
