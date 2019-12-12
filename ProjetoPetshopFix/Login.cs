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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        int MouPosX = 0, MouPosY = 0;
        bool mouseDown = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Email = txtEmail.Text;
            funcionario.Senha = txtSenha.Text;
            funcionario.RealizarLogin();
            if(funcionario.TipoFuncionario == TipoFuncionario.Administrador){
                MenuAdm menuAdm = new MenuAdm();
                this.Hide();
                menuAdm.Show(); 
            }
            //else if(funcionario.TipoFuncionario == Veterinario){
            // MenuVeterinario menuVeterinario = new MenuVeterinario();}
            // this.Hide();
            // menuVeterinario.Show();}
            else if(funcionario.TipoFuncionario == TipoFuncionario.Balconista)
            {
                 MenuBalconista menuBalconista = new MenuBalconista();
                this.Hide(); 
                menuBalconista.Show();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja finalizar o programa?", "Sim", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - MouPosX, MousePosition.Y - MouPosY);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            MouPosX = e.X;
            MouPosY = e.Y;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            MouPosX = e.X;
            MouPosY = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - MouPosX, MousePosition.Y - MouPosY);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // new EsqueceuSenha esqueceuSenha = new EsqueceuSenha();
            // this.Hide();
            // esqueceuSenha.Show();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
