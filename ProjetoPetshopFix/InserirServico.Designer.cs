namespace ProjetoPetshopFix
{
    partial class InserirServico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserirServico));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskValorServico = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtDescricaoServico = new System.Windows.Forms.TextBox();
            this.txtNomeServico = new System.Windows.Forms.TextBox();
            this.BtnShowExcluir = new System.Windows.Forms.Button();
            this.btnShowAtualizar = new System.Windows.Forms.Button();
            this.btnInserirServiço = new System.Windows.Forms.Button();
            this.picRetornar = new System.Windows.Forms.PictureBox();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRetornar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.pnlTitulo.Controls.Add(this.picMinimizar);
            this.pnlTitulo.Controls.Add(this.label1);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(750, 53);
            this.pnlTitulo.TabIndex = 4;
            // 
            // picMinimizar
            // 
            this.picMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMinimizar.BackgroundImage")));
            this.picMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMinimizar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picMinimizar.ErrorImage")));
            this.picMinimizar.InitialImage = ((System.Drawing.Image)(resources.GetObject("picMinimizar.InitialImage")));
            this.picMinimizar.Location = new System.Drawing.Point(706, 3);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(39, 42);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimizar.TabIndex = 32;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.picMinimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Gerenciamento de Dados dos Serviços\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Insira as Informações do serviço que deseja cadastrar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskValorServico);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtDescricaoServico);
            this.groupBox1.Controls.Add(this.txtNomeServico);
            this.groupBox1.Location = new System.Drawing.Point(16, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 295);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de Serviço";
            // 
            // mskValorServico
            // 
            this.mskValorServico.Location = new System.Drawing.Point(19, 262);
            this.mskValorServico.Mask = "$999.99";
            this.mskValorServico.Name = "mskValorServico";
            this.mskValorServico.Size = new System.Drawing.Size(361, 20);
            this.mskValorServico.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Valor do Serviço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 67;
            this.label4.Text = "Descrição do Serviço:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(15, 29);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(133, 20);
            this.lblNome.TabIndex = 67;
            this.lblNome.Text = "Nome do Serviço:";
            // 
            // txtDescricaoServico
            // 
            this.txtDescricaoServico.Location = new System.Drawing.Point(19, 106);
            this.txtDescricaoServico.Multiline = true;
            this.txtDescricaoServico.Name = "txtDescricaoServico";
            this.txtDescricaoServico.Size = new System.Drawing.Size(361, 129);
            this.txtDescricaoServico.TabIndex = 36;
            // 
            // txtNomeServico
            // 
            this.txtNomeServico.Location = new System.Drawing.Point(19, 55);
            this.txtNomeServico.Name = "txtNomeServico";
            this.txtNomeServico.Size = new System.Drawing.Size(361, 20);
            this.txtNomeServico.TabIndex = 35;
            // 
            // BtnShowExcluir
            // 
            this.BtnShowExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.BtnShowExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.BtnShowExcluir.FlatAppearance.BorderSize = 3;
            this.BtnShowExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowExcluir.Location = new System.Drawing.Point(480, 289);
            this.BtnShowExcluir.Name = "BtnShowExcluir";
            this.BtnShowExcluir.Size = new System.Drawing.Size(169, 72);
            this.BtnShowExcluir.TabIndex = 105;
            this.BtnShowExcluir.Text = "Página de Exclusão de Registro";
            this.BtnShowExcluir.UseVisualStyleBackColor = false;
            this.BtnShowExcluir.Click += new System.EventHandler(this.BtnShowExcluir_Click);
            // 
            // btnShowAtualizar
            // 
            this.btnShowAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnShowAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnShowAtualizar.FlatAppearance.BorderSize = 3;
            this.btnShowAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAtualizar.Location = new System.Drawing.Point(480, 104);
            this.btnShowAtualizar.Name = "btnShowAtualizar";
            this.btnShowAtualizar.Size = new System.Drawing.Size(169, 72);
            this.btnShowAtualizar.TabIndex = 104;
            this.btnShowAtualizar.Text = "Página de Atualização de Registro";
            this.btnShowAtualizar.UseVisualStyleBackColor = false;
            this.btnShowAtualizar.Click += new System.EventHandler(this.btnShowAtualizar_Click);
            // 
            // btnInserirServiço
            // 
            this.btnInserirServiço.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnInserirServiço.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnInserirServiço.FlatAppearance.BorderSize = 3;
            this.btnInserirServiço.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirServiço.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirServiço.Location = new System.Drawing.Point(480, 193);
            this.btnInserirServiço.Name = "btnInserirServiço";
            this.btnInserirServiço.Size = new System.Drawing.Size(169, 72);
            this.btnInserirServiço.TabIndex = 103;
            this.btnInserirServiço.Text = "Cadastrar";
            this.btnInserirServiço.UseVisualStyleBackColor = false;
            this.btnInserirServiço.Click += new System.EventHandler(this.btnInserirServico_Click);
            // 
            // picRetornar
            // 
            this.picRetornar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRetornar.BackgroundImage")));
            this.picRetornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picRetornar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picRetornar.ErrorImage")));
            this.picRetornar.InitialImage = ((System.Drawing.Image)(resources.GetObject("picRetornar.InitialImage")));
            this.picRetornar.Location = new System.Drawing.Point(696, 371);
            this.picRetornar.Name = "picRetornar";
            this.picRetornar.Size = new System.Drawing.Size(49, 51);
            this.picRetornar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRetornar.TabIndex = 106;
            this.picRetornar.TabStop = false;
            this.picRetornar.Click += new System.EventHandler(this.picRetornar_Click);
            // 
            // InserirServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(750, 430);
            this.Controls.Add(this.picRetornar);
            this.Controls.Add(this.BtnShowExcluir);
            this.Controls.Add(this.btnShowAtualizar);
            this.Controls.Add(this.btnInserirServiço);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InserirServico";
            this.Text = "InserirServico";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InserirServico_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InserirServico_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InserirServico_MouseUp);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRetornar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskValorServico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtDescricaoServico;
        private System.Windows.Forms.TextBox txtNomeServico;
        private System.Windows.Forms.Button BtnShowExcluir;
        private System.Windows.Forms.Button btnShowAtualizar;
        private System.Windows.Forms.Button btnInserirServiço;
        private System.Windows.Forms.PictureBox picRetornar;
    }
}