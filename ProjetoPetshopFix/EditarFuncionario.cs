using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPetshopFix.Services;
using ProjetoPetshopFix.Entities;
using ProjetoPetshopFix.Entities.Enum;

namespace ProjetoPetshopFix
{
    public partial class EditarFuncionario : Form
    {
        public EditarFuncionario()
        {
            InitializeComponent();
        }

        int MouPosX = 0, MouPosY = 0;
        bool mouseDown = false;

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void EditarFuncionario_Load(object sender, EventArgs e)
        {
            cboTipoFuncionario.DataSource = Enum.GetValues(typeof(TipoFuncionario));
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

        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
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
            mskRGFuncionario.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            mskTelefoneFuncionario.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtEmailFuncionario.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtSenhaFuncionario.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtEnderecoFuncionario.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtCidadeFuncionario.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            cboEstadoFuncionario.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            txtPaisFuncionario.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            Enum.TryParse<TipoFuncionario>(dataGridView1.SelectedRows[0].Cells[12].Value.ToString(), out TipoFuncionario tipoFuncionario);
            cboTipoFuncionario.Text = tipoFuncionario.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodFuncionario.Text.Length < 1 || dtpDataNascimentoFuncionario.Value == null
                || dtpDataNascimentoFuncionario.Value == null || txtNomeFuncionario.Text.Length < 4
                || !mskRGFuncionario.MaskCompleted || !mskTelefoneFuncionario.MaskCompleted
                || txtEmailFuncionario.Text.Length < 4 || txtSenhaFuncionario.Text.Length < 4
                || txtEnderecoFuncionario.Text.Length < 4 || txtCidadeFuncionario.Text.Length < 4
                || cboEstadoFuncionario.Text.Length < 2 || txtPaisFuncionario.Text.Length < 2 || cboTipoFuncionario.Text.Length < 4)
            {
                MessageBox.Show("Por favor, preencha todos os campos para poder atualizar os dados!");
            }
            else
            {

                DialogResult result = MessageBox.Show("Tem certeza que deseja atualizar dados do funcionário?", "Sim", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    int codFuncionario = int.Parse(txtCodFuncionario.Text);
                    DateTime dataCadastro = dtpDataCadastroFuncionario.Value;
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
                    Funcionario funcionario = new Funcionario(codFuncionario, dataCadastro, dataNascimento, nome, rg, telefone, email,
                        senha, endereco, cidade, estado, pais, tipoFuncionario);
                    funcionario.Editar();
                }
                else
                {

                }
            }
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
    }
}
