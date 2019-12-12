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

namespace ProjetoPetshopFix
{
    public partial class InserirCliente : Form
    {
        public InserirCliente()
        {
            InitializeComponent();
        }

        int MouPosX = 0, MouPosY = 0;
        bool mouseDown = false;
        private void btnShowAtualizar_Click(object sender, EventArgs e)
        {
            EditarCliente editar = new EditarCliente();
            this.Hide();
            editar.Show();
        }

        private void BtnShowExcluir_Click(object sender, EventArgs e)
        {
            ExcluirCliente excluir = new ExcluirCliente();
            this.Hide();
            excluir.Show();
        }

        private void pnlTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pnlTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - MouPosX, MousePosition.Y - MouPosY);
            }
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            MouPosX = e.X;
            MouPosY = e.Y;
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

        private void btnInserirCliente_Click(object sender, EventArgs e)
        {
            DateTime dataCadastro = DateTime.Today;
            DateTime dataNascimento = dtpDataNascimentoCliente.Value;
            string nome = txtNomeCliente.Text;
            string rg = mskRGCliente.Text;
            string telefone = mskTelefoneCliente.Text;
            string email = txtEmailCliente.Text;
            string endereco = txtEnderecoCliente.Text;
            string cidade = txtCidadeCliente.Text;
            string estado = cboEstadoCliente.Text;
            string pais = txtPaisCliente.Text;
            Cliente cliente = new Cliente(dataCadastro, dataNascimento, nome, rg, telefone, email, endereco, cidade,
                estado, pais);
            cliente.Inserir();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
