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
    public partial class Relatorio12meses : Form
    {
        int posicaoCliente;
        public Relatorio12meses(int pos)
        {
            InitializeComponent();
            //InitializeComponent();
            //PosicaoCliente = pos;
            //textBox12meses.Text = "CÓDIGO DO VOO  CIDADE HORIGEM  CIDADE DESTINO  DATA DE EMISSAO\r\n";
            //textBox12meses.Text += ProgramaFidelidade.ExibeVoosdoCliente(ProgramaFidelidade.clientes[PosicaoCliente].Cpf, 12);
            posicaoCliente = pos;
            textBox12meses.Text = "CÓDIGO DO VOO  CIDADE HORIGEM  CIDADE DESTINO  DATA DE EMISSAO\r\n";
            textBox12meses.Text += ProgramaFidelidade.ExibeVoosdoCliente(ProgramaFidelidade.clientes[posicaoCliente].Cpf, 12);
        }

        private void Relatorio12meses_Load(object sender, EventArgs e)
        {

        }

        private void textBox12meses_TextChanged(object sender, EventArgs e)
        {

        }

        private void Relatorio12meses_FormClosed(object sender, FormClosedEventArgs e)
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
