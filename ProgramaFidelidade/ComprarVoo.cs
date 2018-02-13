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
   
    public partial class ComprarVoo : Form
    {
        int posicaoCliente;

        public ComprarVoo(int posicao)
        {
            InitializeComponent();
            posicaoCliente = posicao;
            for (int i = 0; i < ProgramaFidelidade.Cidades1.Count; i++)
            {
                comboBoxCidadeDestino.Items.Add(ProgramaFidelidade.Cidades1[i].NomeCidade);
                comboBoxCidadeOrigem.Items.Add(ProgramaFidelidade.Cidades1[i].NomeCidade);
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            MenuEscolhas menuEscolhas = new MenuEscolhas(posicaoCliente);
            this.Hide();
            menuEscolhas.Show();
        }

        private void buttonEnviarCidades_Click(object sender, EventArgs e)
        {
            bool verifica = ProgramaFidelidade.ComprarPassagem(cb_formapgto.Text, posicaoCliente, ProgramaFidelidade.LocalizaIdVoo(comboBoxCidadeOrigem.Text, comboBoxCidadeDestino.Text).IdentificaVoo);
            //ProgramaFidelidade.PreencheDados("reservas.txt");
            //ProgramaFidelidade.ExibirDadosCliente(posicaoCliente);

            if (cb_formapgto.SelectedItem == null || comboBoxCidadeDestino.SelectedItem == null || comboBoxCidadeOrigem.SelectedItem == null || textBoxExibirViagens == null)
            {
                MessageBox.Show("Você precisa completar os dados necessários!", "Erro!", MessageBoxButtons.OK);
            }

            else if (verifica == false)
            {
                MessageBox.Show("Houve um erro ao efetuar a compra!", "Erro!", MessageBoxButtons.OK);
            }

            else
            {
                Voo aux = ProgramaFidelidade.LocalizaIdVoo(comboBoxCidadeOrigem.Text, comboBoxCidadeDestino.Text);
                //Cria um voo de acordo com o tipo escolhido
                if (cb_formapgto.Text == "Normal")
                {
                    aux = new Normal(aux.IdentificaVoo, aux.CidadeOrigem, aux.CidadeDestino, DateTime.Now);
                }
                else if (cb_formapgto.Text == "Promocional")
                {
                    aux = new Promocional(aux.IdentificaVoo, aux.CidadeOrigem, aux.CidadeDestino, DateTime.Now);
                }

                else if (cb_formapgto.Text == "Fidelidade")
                {
                    aux = new Fidelidade(aux.IdentificaVoo, aux.CidadeOrigem, aux.CidadeDestino, DateTime.Now);
                    //No caso subtrai o valor da compra (a constante 10.000) do voo no saldo
                }
                //Adiciona o novo tipo de voo dentro da lista do cliente 
                ProgramaFidelidade.clientes[posicaoCliente].Voos.Add(aux);

                //Soma o Bonus da compra
                ProgramaFidelidade.clientes[posicaoCliente].PtosSaldo += aux.Bonus;

                this.Close();
                MenuEscolhas form = new MenuEscolhas(posicaoCliente);
                form.Show();
            }
        }

        private void Filtrar_Click(object sender, EventArgs e)
        {
            if (comboBoxCidadeDestino.Text == comboBoxCidadeOrigem.Text)
            {
                MessageBox.Show("Você não pode selecionar duas cidades iguais nos dois campos!", "Erro!", MessageBoxButtons.OK);
            }

            else if (comboBoxCidadeDestino.SelectedItem == null || comboBoxCidadeOrigem.SelectedItem == null)
            {
                MessageBox.Show("Você precisa selecionar duas cidades!", "Erro!", MessageBoxButtons.OK);
            }
            else
            {
                textBoxExibirViagens.Text = ProgramaFidelidade.DeterminaVoos(comboBoxCidadeOrigem.Text, comboBoxCidadeDestino.Text);
            }
        }

        private void ComprarVoo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ComprarVoo_FormClosed_1(object sender, FormClosedEventArgs e)
        {

        }
    }
}
