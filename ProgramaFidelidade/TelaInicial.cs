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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void BemVindo_Click(object sender, EventArgs e)
        {

        }

        private void buttonMenuInicial_Click(object sender, EventArgs e)
        {
            MenuInicial menuInicial = new MenuInicial();
            this.Hide();
            menuInicial.Show();
        }

        private void TelaInicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
