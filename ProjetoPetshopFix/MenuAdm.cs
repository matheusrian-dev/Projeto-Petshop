using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPetshopFix
{
    public partial class MenuAdm : Form
    {
        public MenuAdm()
        {
            InitializeComponent();
        }

        int MouPosX = 0, MouPosY = 0;
        bool mouseDown = false;

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnShowGerenciar_Click(object sender, EventArgs e)
        {
            if (!pnlChoose.Visible)
            {
                pnlChoose.Visible = true;
            }
            this.pnlChoose.Location = new Point(56, 70);
        }

        private void pnlChoose_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
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

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MenuAdm_Load(object sender, EventArgs e)
        {
            pnlChoose.Visible = false;
            Menu.Width = 70;
            picClose.Location = new Point(698, 8);

            picMinimize.Location = new Point(648, 8);
            lblTitulo.Location = new Point(301, 14);
        }

        private void btnShowEmitir_Click(object sender, EventArgs e)
        {
            if (!pnlChoose.Visible)
            {
                pnlChoose.Visible = true;
            }
            this.pnlChoose.Location = new Point(56, 144);
        }

        private void btnExpandir_Click(object sender, EventArgs e)
        {
            if(Menu.Width == 240)
            {
                Menu.Width = 70;
                picClose.Location = new Point(697, 8);

                picMinimize.Location = new Point(647, 8);
                lblTitulo.Location = new Point(301, 14);

            }
            else
            {
                Menu.Width = 240;
                picClose.Location = new Point(527, 8);

                picMinimize.Location = new Point(477, 8);
                lblTitulo.Location = new Point(131, 14);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            MouPosX = e.X;
            MouPosY = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - MouPosX, MousePosition.Y - MouPosY);
            }
        }

        
    }
}
