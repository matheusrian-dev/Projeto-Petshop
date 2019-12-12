namespace ProjetoPetshopFix
{
    partial class InserirCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserirCliente));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPaisCliente = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.cboEstadoCliente = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtEnderecoCliente = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.mskTelefoneCliente = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.dtpDataNascimentoCliente = new System.Windows.Forms.DateTimePicker();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mskRGCliente = new System.Windows.Forms.MaskedTextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtBairroCliente = new System.Windows.Forms.TextBox();
            this.txtCidadeCliente = new System.Windows.Forms.TextBox();
            this.BtnShowExcluir = new System.Windows.Forms.Button();
            this.btnShowAtualizar = new System.Windows.Forms.Button();
            this.btnInserirCliente = new System.Windows.Forms.Button();
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
            this.pnlTitulo.Size = new System.Drawing.Size(800, 53);
            this.pnlTitulo.TabIndex = 3;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            this.pnlTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseMove);
            this.pnlTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseUp);
            // 
            // picMinimizar
            // 
            this.picMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMinimizar.BackgroundImage")));
            this.picMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMinimizar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picMinimizar.ErrorImage")));
            this.picMinimizar.InitialImage = ((System.Drawing.Image)(resources.GetObject("picMinimizar.InitialImage")));
            this.picMinimizar.Location = new System.Drawing.Point(758, 3);
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
            this.label1.Size = new System.Drawing.Size(479, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Gerenciamento de Dados dos Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Insira as Informações do cliente que deseja cadastrar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPaisCliente);
            this.groupBox1.Controls.Add(this.lblPais);
            this.groupBox1.Controls.Add(this.cboEstadoCliente);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.lblCidade);
            this.groupBox1.Controls.Add(this.lblBairro);
            this.groupBox1.Controls.Add(this.txtEnderecoCliente);
            this.groupBox1.Controls.Add(this.lblEndereco);
            this.groupBox1.Controls.Add(this.mskTelefoneCliente);
            this.groupBox1.Controls.Add(this.lblTelefone);
            this.groupBox1.Controls.Add(this.dtpDataNascimentoCliente);
            this.groupBox1.Controls.Add(this.lblDataNasc);
            this.groupBox1.Controls.Add(this.txtEmailCliente);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.mskRGCliente);
            this.groupBox1.Controls.Add(this.lblRG);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 295);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Pessoais";
            // 
            // txtPaisCliente
            // 
            this.txtPaisCliente.Location = new System.Drawing.Point(217, 254);
            this.txtPaisCliente.Name = "txtPaisCliente";
            this.txtPaisCliente.Size = new System.Drawing.Size(211, 20);
            this.txtPaisCliente.TabIndex = 102;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(213, 229);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(43, 20);
            this.lblPais.TabIndex = 101;
            this.lblPais.Text = "País:";
            // 
            // cboEstadoCliente
            // 
            this.cboEstadoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCliente.FormattingEnabled = true;
            this.cboEstadoCliente.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboEstadoCliente.Location = new System.Drawing.Point(217, 202);
            this.cboEstadoCliente.Name = "cboEstadoCliente";
            this.cboEstadoCliente.Size = new System.Drawing.Size(211, 21);
            this.cboEstadoCliente.TabIndex = 100;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(213, 181);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 20);
            this.lblEstado.TabIndex = 99;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(213, 133);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(63, 20);
            this.lblCidade.TabIndex = 98;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(213, 85);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(55, 20);
            this.lblBairro.TabIndex = 97;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtEnderecoCliente
            // 
            this.txtEnderecoCliente.Location = new System.Drawing.Point(217, 61);
            this.txtEnderecoCliente.Name = "txtEnderecoCliente";
            this.txtEnderecoCliente.Size = new System.Drawing.Size(211, 20);
            this.txtEnderecoCliente.TabIndex = 96;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(213, 37);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(82, 20);
            this.lblEndereco.TabIndex = 95;
            this.lblEndereco.Text = "Endereço:";
            // 
            // mskTelefoneCliente
            // 
            this.mskTelefoneCliente.Location = new System.Drawing.Point(26, 254);
            this.mskTelefoneCliente.Mask = "(99) 99999-9999";
            this.mskTelefoneCliente.Name = "mskTelefoneCliente";
            this.mskTelefoneCliente.Size = new System.Drawing.Size(185, 20);
            this.mskTelefoneCliente.TabIndex = 94;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(22, 229);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(75, 20);
            this.lblTelefone.TabIndex = 93;
            this.lblTelefone.Text = "Telefone:";
            // 
            // dtpDataNascimentoCliente
            // 
            this.dtpDataNascimentoCliente.CustomFormat = "yyyy-MM-dd";
            this.dtpDataNascimentoCliente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimentoCliente.Location = new System.Drawing.Point(26, 203);
            this.dtpDataNascimentoCliente.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDataNascimentoCliente.Name = "dtpDataNascimentoCliente";
            this.dtpDataNascimentoCliente.Size = new System.Drawing.Size(185, 20);
            this.dtpDataNascimentoCliente.TabIndex = 92;
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.Location = new System.Drawing.Point(22, 181);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(158, 20);
            this.lblDataNasc.TabIndex = 91;
            this.lblDataNasc.Text = "Data de Nascimento:";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(26, 157);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(185, 20);
            this.txtEmailCliente.TabIndex = 88;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(22, 133);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 87;
            this.lblEmail.Text = "Email:";
            // 
            // mskRGCliente
            // 
            this.mskRGCliente.Location = new System.Drawing.Point(26, 109);
            this.mskRGCliente.Mask = "Aa-99.999.999";
            this.mskRGCliente.Name = "mskRGCliente";
            this.mskRGCliente.Size = new System.Drawing.Size(185, 20);
            this.mskRGCliente.TabIndex = 86;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.Location = new System.Drawing.Point(22, 85);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(38, 20);
            this.lblRG.TabIndex = 85;
            this.lblRG.Text = "RG:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(26, 61);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(185, 20);
            this.txtNomeCliente.TabIndex = 84;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(22, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 83;
            this.lblNome.Text = "Nome:";
            // 
            // txtBairroCliente
            // 
            this.txtBairroCliente.Location = new System.Drawing.Point(233, 200);
            this.txtBairroCliente.Name = "txtBairroCliente";
            this.txtBairroCliente.Size = new System.Drawing.Size(211, 20);
            this.txtBairroCliente.TabIndex = 98;
            // 
            // txtCidadeCliente
            // 
            this.txtCidadeCliente.Location = new System.Drawing.Point(233, 248);
            this.txtCidadeCliente.Name = "txtCidadeCliente";
            this.txtCidadeCliente.Size = new System.Drawing.Size(211, 20);
            this.txtCidadeCliente.TabIndex = 99;
            // 
            // BtnShowExcluir
            // 
            this.BtnShowExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.BtnShowExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.BtnShowExcluir.FlatAppearance.BorderSize = 3;
            this.BtnShowExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowExcluir.Location = new System.Drawing.Point(504, 366);
            this.BtnShowExcluir.Name = "BtnShowExcluir";
            this.BtnShowExcluir.Size = new System.Drawing.Size(169, 72);
            this.BtnShowExcluir.TabIndex = 102;
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
            this.btnShowAtualizar.Location = new System.Drawing.Point(504, 128);
            this.btnShowAtualizar.Name = "btnShowAtualizar";
            this.btnShowAtualizar.Size = new System.Drawing.Size(169, 72);
            this.btnShowAtualizar.TabIndex = 101;
            this.btnShowAtualizar.Text = "Página de Atualização de Registro";
            this.btnShowAtualizar.UseVisualStyleBackColor = false;
            this.btnShowAtualizar.Click += new System.EventHandler(this.btnShowAtualizar_Click);
            // 
            // btnInserirCliente
            // 
            this.btnInserirCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnInserirCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnInserirCliente.FlatAppearance.BorderSize = 3;
            this.btnInserirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirCliente.Location = new System.Drawing.Point(504, 248);
            this.btnInserirCliente.Name = "btnInserirCliente";
            this.btnInserirCliente.Size = new System.Drawing.Size(169, 72);
            this.btnInserirCliente.TabIndex = 100;
            this.btnInserirCliente.Text = "Cadastrar";
            this.btnInserirCliente.UseVisualStyleBackColor = false;
            this.btnInserirCliente.Click += new System.EventHandler(this.btnInserirCliente_Click);
            // 
            // picRetornar
            // 
            this.picRetornar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRetornar.BackgroundImage")));
            this.picRetornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picRetornar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picRetornar.ErrorImage")));
            this.picRetornar.InitialImage = ((System.Drawing.Image)(resources.GetObject("picRetornar.InitialImage")));
            this.picRetornar.Location = new System.Drawing.Point(739, 387);
            this.picRetornar.Name = "picRetornar";
            this.picRetornar.Size = new System.Drawing.Size(49, 51);
            this.picRetornar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRetornar.TabIndex = 103;
            this.picRetornar.TabStop = false;
            this.picRetornar.Click += new System.EventHandler(this.picRetornar_Click);
            // 
            // InserirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picRetornar);
            this.Controls.Add(this.BtnShowExcluir);
            this.Controls.Add(this.btnShowAtualizar);
            this.Controls.Add(this.btnInserirCliente);
            this.Controls.Add(this.txtCidadeCliente);
            this.Controls.Add(this.txtBairroCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InserirCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InserirCliente";
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
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mskRGCliente;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cboEstadoCliente;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtEnderecoCliente;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.MaskedTextBox mskTelefoneCliente;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.DateTimePicker dtpDataNascimentoCliente;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.TextBox txtBairroCliente;
        private System.Windows.Forms.TextBox txtCidadeCliente;
        private System.Windows.Forms.TextBox txtPaisCliente;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Button BtnShowExcluir;
        private System.Windows.Forms.Button btnShowAtualizar;
        private System.Windows.Forms.Button btnInserirCliente;
        private System.Windows.Forms.PictureBox picRetornar;
    }
}