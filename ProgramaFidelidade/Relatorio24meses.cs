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
    public partial class Relatorio24meses : Form
    {
        int posicaoCliente;
        public Relatorio24meses(int pos)
        {
            InitializeComponent();
            posicaoCliente = pos;
            textBox24meses.Text = "CÓDIGO DO VOO  CIDADE HORIGEM  CIDADE DESTINO  DATA DE EMISSAO\r\n";
            textBox24meses.Text += ProgramaFidelidade.ExibeVoosdoCliente(ProgramaFidelidade.clientes[posicaoCliente].Cpf, 24);
        }

        private void textBox24meses_TextChanged(object sender, EventArgs e)
        {

        }

        private void Relatorio24meses_Load(object sender, EventArgs e)
        {

        }

        private void Relatorio24meses_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            MenuEscolhas menuEscolhas = new MenuEscolhas(posicaoCliente);
            this.Hide();
            menuEscolhas.Show();
        }
    }
}
