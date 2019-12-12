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
using ProjetoPetshopFix.Entities.Enum;

namespace ProjetoPetshopFix
{
    public partial class InserirFuncionario : Form
    {
        public InserirFuncionario()
        {
            InitializeComponent();
        }

        int MouPosX = 0, MouPosY = 0;
        bool mouseDown = false;
        private void btnInserirFuncionario_Click(object sender, EventArgs e)
        {
            DateTime dataCadastro = DateTime.Today;
            DateTime dataNascimento = dtpDataNascimentoFuncionario.Value;
            string nome = txtNomeFuncionario.Text;
            string rg = mskRGFuncionario.Text;
            string telefone = mskTelefoneFuncionario.Text;
            string email = txtEmailFuncionario.Text;
            string senha = txtSenhaFuncionario.Text;
            string endereco = txtEnderecoFuncionario.Text;
            string cidade = txtCidadeFuncionario.Text;
            string estado = cboEstadoFuncionario.Text;
            string pais = txtPaisFuncionario.Text;
            Enum.TryParse<TipoFuncionario>(cboTipoFuncionario.Text, out TipoFuncionario tipoFuncionario);
            Funcionario funcionario = new Funcionario(dataCadastro, dataNascimento, nome, rg, telefone, email,
                senha, endereco, cidade, estado, pais, tipoFuncionario);
            funcionario.Inserir();
        }

        private void InserirFuncionário_Load(object sender, EventArgs e)
        {
            cboTipoFuncionario.DataSource = Enum.GetValues(typeof(TipoFuncionario));

        }

        private void BtnShowExcluir_Click(object sender, EventArgs e)
        {
            ExcluirFuncionario excluir = new ExcluirFuncionario();
            this.Hide();
            excluir.Show();
        }

        private void btnShowAtualizar_Click(object sender, EventArgs e)
        {
            EditarFuncionario editar = new EditarFuncionario();
            this.Hide();
            editar.Show();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            MouPosX = e.X;
            MouPosY = e.Y;
        }

        private void pnlTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - MouPosX, MousePosition.Y - MouPosY);
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            MouPosX = e.X;
            MouPosY = e.Y;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - MouPosX, MousePosition.Y - MouPosY);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pnlTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
