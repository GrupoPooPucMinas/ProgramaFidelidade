using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaFidelidade
{
    public partial class Relatorio : Form
    {
        String Nome = "";
        int posicaoCliente;
        public Relatorio(int pos)
        {
            InitializeComponent();
            posicaoCliente = pos;
            textBoxInfRelatorios.Text = "CÓDIGO DO VOO  CIDADE HORIGEM  CIDADE DESTINO  DATA DE EMISSAO\r\n";
            textBoxInfRelatorios.Text +=  ProgramaFidelidade.ExibeVoosdoCliente(ProgramaFidelidade.clientes[posicaoCliente].Cpf);
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            MenuEscolhas menuEscolhas = new MenuEscolhas(posicaoCliente);
            this.Hide();
            menuEscolhas.Show();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {

        }

        private void Relatorio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuEscolhas menuEscolhas = new MenuEscolhas(posicaoCliente);
            this.Hide();
            menuEscolhas.Show();
        }
    }
}
