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
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void buttonEnviarNome_Click(object sender, EventArgs e)
        {
            int posicaoCliente;
            string login = textBoxPreencherNome.Text;
            login = login.Replace(",",".");
            //Confere se o usuário realmente preencheu o nome
            if (textBoxPreencherNome.Text == "")
            {
                MessageBox.Show("Voce deve preencher o seu nome!", "Erro!", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    //ProgramaFidelidade programaFidelidade = new ProgramaFidelidade();
                    posicaoCliente = ProgramaFidelidade.PesquisarCliente(login);
                    if (posicaoCliente == -1)
                    {
                        MessageBox.Show("Esse cliente não existe! Tente Novamente.", "Erro!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MenuEscolhas menuEscolhas = new MenuEscolhas(posicaoCliente);
                        this.Hide();
                        menuEscolhas.Show();
                    }
                }
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("Arquivo não encontrado!", "Erro!", MessageBoxButtons.OK);
                }
            }
        }

        private void MenuInicial_Load(object sender, EventArgs e)
        {

        }

        private void MenuInicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
