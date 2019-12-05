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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario(DateTime.Now, Convert.ToDateTime("1998-09-08"), "Matheus", "MG18100892", "(31) 99916-0683", "matheusrian332@gmail.com", "1234", "Rua Dr Beatris", "BH", "MG", "Brasil", TipoFuncionario.Veterinario);
            funcionario.Inserir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Funcionario().RetFuncionarios();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //new Funcionario().Excluir(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario(1, DateTime.Now, Convert.ToDateTime("1998-09-08"), "Matheus", "MG18100892", "(31) 99916-0683", "matheusrian332@gmail.com", "1234", "Rua Dr Beatris", "BH", "MG", "Brasil", TipoFuncionario.Veterinario);
            funcionario.Editar();
        }
    }
}
