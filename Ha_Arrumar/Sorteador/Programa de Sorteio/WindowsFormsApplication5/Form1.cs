using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        List<string> nomes = new List<string>();
        int b = 0;
        public Form1()
        {
            InitializeComponent();
            nomes = Iniciar.PuxarArquivos("PrimeiroAno");
        }

        private void btn_Sorteio_Click(object sender, EventArgs e)
        {
           
            if (nomes.Count > 0)
            {
                b += 1;
                string sorteado = Sorteio.Sortear(nomes);
                nomes.Remove(sorteado);
                lab_NomeSortiado.Text = sorteado;
            }
            else if (b == 40)
            {
                string sorteado = nomes[0];
                nomes.Remove(sorteado);
                lab_NomeSortiado.Text = sorteado;
            }
                MessageBox.Show("Termino");
        }

        private void btn_Reinicia_Click(object sender, EventArgs e)
        {
            nomes = Iniciar.PuxarArquivos("PrimeiroAno");
        }
    }
}
