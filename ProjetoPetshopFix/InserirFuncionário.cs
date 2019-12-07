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
    public partial class InserirFuncionário : Form
    {
        public InserirFuncionário()
        {
            InitializeComponent();
        }

        private void btnInserirFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void InserirFuncionário_Load(object sender, EventArgs e)
        {
            cboCodTipoFuncionario.DataSource = Enum.GetValues(typeof(TipoFuncionario));

        }

        private void BtnShowExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnShowAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtpDataNascimentoFuncionario_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
