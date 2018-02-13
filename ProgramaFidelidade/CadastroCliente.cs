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
    public partial class CadastroCliente : Form
    {
        int posicaoCliente;

        public CadastroCliente(int posCliente)
        {
            InitializeComponent();
            posicaoCliente = posCliente;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //CADASTRAR NOVO CLIENTE
            string cpf = txtCpf.Text;
            cpf = cpf.Replace(",", ".");
            string nome = txtNome.Text;

            try
            {
                Cliente.CadastraClienteArquivo(cpf, nome);
                MessageBox.Show("Cadastro realizado com sucesso!");
                this.Close();
                MenuEscolhas form = new MenuEscolhas(posicaoCliente);
                form.Show();
            }
            catch
            {
                MessageBox.Show("Falha ao realizar cadastro");
            }
            
        }
    }
}
