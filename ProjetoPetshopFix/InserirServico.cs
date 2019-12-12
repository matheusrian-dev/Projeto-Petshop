using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPetshopFix.Entities;
using ProjetoPetshopFix.Services;

namespace ProjetoPetshopFix
{
    public partial class InserirServico : Form
    {
        public InserirServico()
        {
            InitializeComponent();
        }

        int MouPosX = 0, MouPosY = 0;
        bool mouseDown = false;

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void InserirServico_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void InserirServico_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - MouPosX, MousePosition.Y - MouPosY);
            }
        }

        private void InserirServico_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            MouPosX = e.X;
            MouPosY = e.Y;
        }

        private void btnShowAtualizar_Click(object sender, EventArgs e)
        {
            EditarServico editar = new EditarServico();
            this.Hide();
            editar.Show();
        }

        private void BtnShowExcluir_Click(object sender, EventArgs e)
        {
            ExcluirServico excluir = new ExcluirServico();
            this.Hide();
            excluir.Show();
        }

        private void btnInserirServico_Click(object sender, EventArgs e)
        {
            string nome = txtNomeServico.Text;
            string descricao = txtDescricaoServico.Text;
            double valor = double.Parse(mskValorServico.Text);
            Servicos servico = new Servicos(nome, descricao, valor);
        }

        private void picRetornar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja retornar ao menu principal?", "Sim", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                this.Close();
            }
            else
            {

            }
        }
    }
}
