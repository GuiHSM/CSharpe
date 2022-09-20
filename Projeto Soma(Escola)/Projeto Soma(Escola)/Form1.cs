using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Soma_Escola_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            box_PrimeiroValor.Text = "";
            box_SegundoValor.Text = "";
            box_Resultado.Text = "";
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (box_PrimeiroValor.Text == "")
                box_PrimeiroValor.Text = "0";
            if (box_SegundoValor.Text == "")
                box_SegundoValor.Text = "0";
            box_Resultado.Text = Convert.ToString(Int32.Parse(box_SegundoValor.Text) + Int32.Parse(box_PrimeiroValor.Text));
        }

      
    }
}
