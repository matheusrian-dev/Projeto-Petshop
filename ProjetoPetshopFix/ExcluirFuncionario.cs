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
    public partial class ExcluirFuncionario : Form
    {
        public ExcluirFuncionario()
        {
            InitializeComponent();
        }

        int MouPosX = 0, MouPosY = 0;
        bool mouseDown = false;

        private void ExcluirFuncionario_Load(object sender, EventArgs e)
        {
            cboTipoFuncionario.DataSource = Enum.GetValues(typeof(TipoFuncionario));
        }

        private void btnBuscarFuncionarioExcluir_Click(object sender, EventArgs e)
        {
            if (txtBuscaNome.Text.Length < 4 && !mskRgBusca.MaskCompleted && txtBuscaEmail.Text.Length < 4)
            {
                MessageBox.Show("Os Campos de Busca requerem um mínimo de 4 caracteres.");
            }
            else
            {
                string nome = txtBuscaNome.Text;
                string email = txtBuscaEmail.Text;
                string rg = mskRgBusca.Text;
                Funcionario funcionario = new Funcionario();
                dataGridView1.DataSource = funcionario.RetFuncionarioEspecifico(nome, rg, email);
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtCodFuncionario.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            dtpDataCadastroFuncionario.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dtpDataNascimentoFuncionario.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtNomeFuncionario.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            mskRgFuncionario.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            mskTelefoneFuncionario.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtEmailFuncionario.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtSenhaFuncionario.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtEnderecoFuncionario.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtCidadeFuncionario.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            cboEstadoFuncionario.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            txtPaisFuncionario.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            Enum.TryParse<TipoFuncionario>(dataGridView1.SelectedRows[0].Cells[12].Value.ToString(), out TipoFuncionario tipoFuncionario);
            cboTipoFuncionario.Text = tipoFuncionario.ToString();

            txtCodFuncionario.ReadOnly = true;
            dtpDataCadastroFuncionario.Enabled = false;
            dtpDataNascimentoFuncionario.Enabled = false;
            txtNomeFuncionario.ReadOnly = true;
            mskRgFuncionario.ReadOnly = true;
            mskTelefoneFuncionario.ReadOnly = true;
            txtEmailFuncionario.ReadOnly = true;
            txtSenhaFuncionario.ReadOnly = true;
            txtEnderecoFuncionario.ReadOnly = true;
            txtCidadeFuncionario.ReadOnly = true;
            cboEstadoFuncionario.Enabled = false;
            txtPaisFuncionario.ReadOnly = true;
            cboTipoFuncionario.Enabled = false;
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

        private void pnlTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picRetornar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja retornar ao menu anterior?", "Sim", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                this.Close();
            }
            else
            {

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja atualizar dados do funcionário?", "Sim", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                new Funcionario().Excluir(int.Parse(txtCodFuncionario.Text));
            }
            else
            {

            }
        }
    }
}
