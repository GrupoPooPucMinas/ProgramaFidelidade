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
    public partial class MenuEscolhas : Form
    {
        //ProgramaFidelidade ProgramaFidelidade;
        int PosicaoCliente;
        public MenuEscolhas(int posicaoCliente)
        {

            InitializeComponent();
            PosicaoCliente = posicaoCliente;

            //Verifica a categoria toda vez que entra na página que mostra os dados do usuario
            ProgramaFidelidade.clientes[posicaoCliente].VerificaCategoria(ProgramaFidelidade.clientes[posicaoCliente].Voos);
            
            //Calcula os pontos toda vez que entra na página que mostra os dados do usuario
            ProgramaFidelidade.clientes[posicaoCliente].PtosSaldo = ProgramaFidelidade.clientes[posicaoCliente].CalculaPontos(ProgramaFidelidade.clientes[posicaoCliente].Voos);

            //Exibir os dados do cliente: nome, cpf, categoria e quantidade de pontos
            TBExibeDado.Text = ProgramaFidelidade.ExibirDadosCliente(posicaoCliente);
        }

        private void emissãoDePassagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComprarVoo comprarVoo = new ComprarVoo(PosicaoCliente);
            this.Hide();
            comprarVoo.Show();
        }

        private void emitirRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new Relatorio(PosicaoCliente);
            this.Hide();
            relatorio.Show();
        }

        private void MenuEscolhas_Load(object sender, EventArgs e)
        {

        }

        private void MenuEscolhas_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void relatório12MesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio12meses relatorio = new Relatorio12meses(PosicaoCliente);
            this.Hide();
            relatorio.Show();
        }

        private void relatório24MesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new Relatorio(PosicaoCliente);
            this.Hide();
            relatorio.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente form = new CadastroCliente(PosicaoCliente);
            this.Hide();
            form.Show();
        }

        private void TBExibeDado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
