namespace ProjetoPetshopFix
{
    partial class InserirFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserirFuncionario));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picRetornar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpEstado = new System.Windows.Forms.GroupBox();
            this.txtSenhaFuncionario = new System.Windows.Forms.TextBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.txtEmailFuncionario = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.mskTelefoneFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.mskRGFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataNascimentoFuncionario = new System.Windows.Forms.DateTimePicker();
            this.cboEstadoFuncionario = new System.Windows.Forms.ComboBox();
            this.cboTipoFuncionario = new System.Windows.Forms.ComboBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnderecoFuncionario = new System.Windows.Forms.TextBox();
            this.txtBairroFuncionario = new System.Windows.Forms.TextBox();
            this.txtCidadeFuncionario = new System.Windows.Forms.TextBox();
            this.txtPaisFuncionario = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.BtnShowExcluir = new System.Windows.Forms.Button();
            this.btnShowAtualizar = new System.Windows.Forms.Button();
            this.btnInserirFuncionario = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRetornar)).BeginInit();
            this.grpEstado.SuspendLayout();
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
            this.pnlTitulo.Size = new System.Drawing.Size(725, 53);
            this.pnlTitulo.TabIndex = 2;
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
            this.picMinimizar.Location = new System.Drawing.Point(674, 3);
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
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Gerenciamento de Dados dos Funcionários";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // picRetornar
            // 
            this.picRetornar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRetornar.BackgroundImage")));
            this.picRetornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picRetornar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picRetornar.ErrorImage")));
            this.picRetornar.InitialImage = ((System.Drawing.Image)(resources.GetObject("picRetornar.InitialImage")));
            this.picRetornar.Location = new System.Drawing.Point(664, 457);
            this.picRetornar.Name = "picRetornar";
            this.picRetornar.Size = new System.Drawing.Size(49, 51);
            this.picRetornar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRetornar.TabIndex = 31;
            this.picRetornar.TabStop = false;
            this.picRetornar.Click += new System.EventHandler(this.picRetornar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 24);
            this.label2.TabIndex = 60;
            this.label2.Text = "Insira as Informações do funcionário que deseja cadastrar:";
            // 
            // grpEstado
            // 
            this.grpEstado.Controls.Add(this.txtSenhaFuncionario);
            this.grpEstado.Controls.Add(this.lblDataCadastro);
            this.grpEstado.Controls.Add(this.txtEmailFuncionario);
            this.grpEstado.Controls.Add(this.lblEmail);
            this.grpEstado.Controls.Add(this.txtNomeFuncionario);
            this.grpEstado.Controls.Add(this.lblNome);
            this.grpEstado.Controls.Add(this.lblRG);
            this.grpEstado.Controls.Add(this.mskTelefoneFuncionario);
            this.grpEstado.Controls.Add(this.mskRGFuncionario);
            this.grpEstado.Controls.Add(this.dtpDataNascimentoFuncionario);
            this.grpEstado.Controls.Add(this.cboEstadoFuncionario);
            this.grpEstado.Controls.Add(this.cboTipoFuncionario);
            this.grpEstado.Controls.Add(this.lblDataNasc);
            this.grpEstado.Controls.Add(this.label4);
            this.grpEstado.Controls.Add(this.txtEnderecoFuncionario);
            this.grpEstado.Controls.Add(this.txtBairroFuncionario);
            this.grpEstado.Controls.Add(this.txtCidadeFuncionario);
            this.grpEstado.Controls.Add(this.txtPaisFuncionario);
            this.grpEstado.Controls.Add(this.lblTelefone);
            this.grpEstado.Controls.Add(this.lblPais);
            this.grpEstado.Controls.Add(this.lblEstado);
            this.grpEstado.Controls.Add(this.lblEndereco);
            this.grpEstado.Controls.Add(this.lblCidade);
            this.grpEstado.Controls.Add(this.lblBairro);
            this.grpEstado.Location = new System.Drawing.Point(46, 111);
            this.grpEstado.Name = "grpEstado";
            this.grpEstado.Size = new System.Drawing.Size(601, 330);
            this.grpEstado.TabIndex = 66;
            this.grpEstado.TabStop = false;
            this.grpEstado.Text = "Dados do Funcionário";
            this.grpEstado.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtSenhaFuncionario
            // 
            this.txtSenhaFuncionario.Location = new System.Drawing.Point(26, 187);
            this.txtSenhaFuncionario.Name = "txtSenhaFuncionario";
            this.txtSenhaFuncionario.Size = new System.Drawing.Size(261, 20);
            this.txtSenhaFuncionario.TabIndex = 88;
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCadastro.Location = new System.Drawing.Point(22, 165);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(60, 20);
            this.lblDataCadastro.TabIndex = 87;
            this.lblDataCadastro.Text = "Senha:";
            // 
            // txtEmailFuncionario
            // 
            this.txtEmailFuncionario.Location = new System.Drawing.Point(26, 144);
            this.txtEmailFuncionario.Name = "txtEmailFuncionario";
            this.txtEmailFuncionario.Size = new System.Drawing.Size(261, 20);
            this.txtEmailFuncionario.TabIndex = 86;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(22, 122);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 85;
            this.lblEmail.Text = "Email:";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(26, 58);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(261, 20);
            this.txtNomeFuncionario.TabIndex = 84;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(22, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 83;
            this.lblNome.Text = "Nome:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.Location = new System.Drawing.Point(22, 77);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(38, 20);
            this.lblRG.TabIndex = 82;
            this.lblRG.Text = "RG:";
            // 
            // mskTelefoneFuncionario
            // 
            this.mskTelefoneFuncionario.Location = new System.Drawing.Point(26, 282);
            this.mskTelefoneFuncionario.Mask = "(99) 99999-9999";
            this.mskTelefoneFuncionario.Name = "mskTelefoneFuncionario";
            this.mskTelefoneFuncionario.Size = new System.Drawing.Size(261, 20);
            this.mskTelefoneFuncionario.TabIndex = 81;
            // 
            // mskRGFuncionario
            // 
            this.mskRGFuncionario.Location = new System.Drawing.Point(26, 101);
            this.mskRGFuncionario.Mask = "AA-99,999,999";
            this.mskRGFuncionario.Name = "mskRGFuncionario";
            this.mskRGFuncionario.Size = new System.Drawing.Size(94, 20);
            this.mskRGFuncionario.TabIndex = 80;
            // 
            // dtpDataNascimentoFuncionario
            // 
            this.dtpDataNascimentoFuncionario.CustomFormat = "yyyy-MM-dd";
            this.dtpDataNascimentoFuncionario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimentoFuncionario.Location = new System.Drawing.Point(26, 233);
            this.dtpDataNascimentoFuncionario.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDataNascimentoFuncionario.Name = "dtpDataNascimentoFuncionario";
            this.dtpDataNascimentoFuncionario.Size = new System.Drawing.Size(125, 20);
            this.dtpDataNascimentoFuncionario.TabIndex = 66;
            this.dtpDataNascimentoFuncionario.ValueChanged += new System.EventHandler(this.dtpDataNascimentoFuncionario_ValueChanged);
            // 
            // cboEstadoFuncionario
            // 
            this.cboEstadoFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoFuncionario.FormattingEnabled = true;
            this.cboEstadoFuncionario.Items.AddRange(new object[] {
            "AC(Acre)",
            "AL(Alagoas)",
            "AP(Amapá)",
            "AM(Amazonas)",
            "BA(Bahia)",
            "CE(Ceará)",
            "DF(Distrito Federal)",
            "ES(Espírito Santo)",
            "GO(Goiás)",
            "MA(Maranhão)",
            "MT(Mato Grosso)",
            "MS(Mato Grosso do Sul)",
            "MG(Minas Gerais)",
            "PA(Pará) ",
            "PB(Paraíba)",
            "PR(Paraná)",
            "PE(Pernambuco)",
            "PI(Piauí)",
            "RJ(Rio de Janeiro)",
            "RN(Rio Grande do Norte)",
            "RS(Rio Grande do Sul)",
            "RO(Rondônia)",
            "RR(Roraima)",
            "SC(Santa Catarina)",
            "SP(São Paulo)",
            "SE(Sergipe)",
            "TO(Tocantins)"});
            this.cboEstadoFuncionario.Location = new System.Drawing.Point(316, 187);
            this.cboEstadoFuncionario.Name = "cboEstadoFuncionario";
            this.cboEstadoFuncionario.Size = new System.Drawing.Size(126, 21);
            this.cboEstadoFuncionario.TabIndex = 75;
            // 
            // cboTipoFuncionario
            // 
            this.cboTipoFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFuncionario.FormattingEnabled = true;
            this.cboTipoFuncionario.Location = new System.Drawing.Point(316, 281);
            this.cboTipoFuncionario.Name = "cboTipoFuncionario";
            this.cboTipoFuncionario.Size = new System.Drawing.Size(126, 21);
            this.cboTipoFuncionario.TabIndex = 74;
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.Location = new System.Drawing.Point(22, 210);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(158, 20);
            this.lblDataNasc.TabIndex = 50;
            this.lblDataNasc.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Telefone:";
            // 
            // txtEnderecoFuncionario
            // 
            this.txtEnderecoFuncionario.Location = new System.Drawing.Point(316, 58);
            this.txtEnderecoFuncionario.Name = "txtEnderecoFuncionario";
            this.txtEnderecoFuncionario.Size = new System.Drawing.Size(256, 20);
            this.txtEnderecoFuncionario.TabIndex = 41;
            // 
            // txtBairroFuncionario
            // 
            this.txtBairroFuncionario.Location = new System.Drawing.Point(316, 101);
            this.txtBairroFuncionario.Name = "txtBairroFuncionario";
            this.txtBairroFuncionario.Size = new System.Drawing.Size(256, 20);
            this.txtBairroFuncionario.TabIndex = 42;
            // 
            // txtCidadeFuncionario
            // 
            this.txtCidadeFuncionario.Location = new System.Drawing.Point(316, 144);
            this.txtCidadeFuncionario.Name = "txtCidadeFuncionario";
            this.txtCidadeFuncionario.Size = new System.Drawing.Size(256, 20);
            this.txtCidadeFuncionario.TabIndex = 43;
            // 
            // txtPaisFuncionario
            // 
            this.txtPaisFuncionario.Location = new System.Drawing.Point(316, 230);
            this.txtPaisFuncionario.Name = "txtPaisFuncionario";
            this.txtPaisFuncionario.Size = new System.Drawing.Size(256, 20);
            this.txtPaisFuncionario.TabIndex = 45;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(312, 257);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(152, 20);
            this.lblTelefone.TabIndex = 51;
            this.lblTelefone.Text = "Tipo de Funcionário:";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(312, 208);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(43, 20);
            this.lblPais.TabIndex = 56;
            this.lblPais.Text = "País:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(312, 165);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 20);
            this.lblEstado.TabIndex = 55;
            this.lblEstado.Text = "Estado:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(312, 36);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(82, 20);
            this.lblEndereco.TabIndex = 52;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(312, 122);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(63, 20);
            this.lblCidade.TabIndex = 54;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(312, 79);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(55, 20);
            this.lblBairro.TabIndex = 53;
            this.lblBairro.Text = "Bairro:";
            // 
            // BtnShowExcluir
            // 
            this.BtnShowExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.BtnShowExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.BtnShowExcluir.FlatAppearance.BorderSize = 2;
            this.BtnShowExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowExcluir.Location = new System.Drawing.Point(439, 457);
            this.BtnShowExcluir.Name = "BtnShowExcluir";
            this.BtnShowExcluir.Size = new System.Drawing.Size(169, 45);
            this.BtnShowExcluir.TabIndex = 69;
            this.BtnShowExcluir.Text = "Página de Exclusão de Registro";
            this.BtnShowExcluir.UseVisualStyleBackColor = false;
            this.BtnShowExcluir.Click += new System.EventHandler(this.BtnShowExcluir_Click);
            // 
            // btnShowAtualizar
            // 
            this.btnShowAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnShowAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnShowAtualizar.FlatAppearance.BorderSize = 2;
            this.btnShowAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAtualizar.Location = new System.Drawing.Point(89, 457);
            this.btnShowAtualizar.Name = "btnShowAtualizar";
            this.btnShowAtualizar.Size = new System.Drawing.Size(169, 45);
            this.btnShowAtualizar.TabIndex = 68;
            this.btnShowAtualizar.Text = "Página de Atualização de Registro";
            this.btnShowAtualizar.UseVisualStyleBackColor = false;
            this.btnShowAtualizar.Click += new System.EventHandler(this.btnShowAtualizar_Click);
            // 
            // btnInserirFuncionario
            // 
            this.btnInserirFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnInserirFuncionario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnInserirFuncionario.FlatAppearance.BorderSize = 2;
            this.btnInserirFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirFuncionario.Location = new System.Drawing.Point(264, 457);
            this.btnInserirFuncionario.Name = "btnInserirFuncionario";
            this.btnInserirFuncionario.Size = new System.Drawing.Size(169, 45);
            this.btnInserirFuncionario.TabIndex = 67;
            this.btnInserirFuncionario.Text = "Cadastrar";
            this.btnInserirFuncionario.UseVisualStyleBackColor = false;
            this.btnInserirFuncionario.Click += new System.EventHandler(this.btnInserirFuncionario_Click);
            // 
            // InserirFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(725, 520);
            this.Controls.Add(this.picRetornar);
            this.Controls.Add(this.BtnShowExcluir);
            this.Controls.Add(this.btnShowAtualizar);
            this.Controls.Add(this.btnInserirFuncionario);
            this.Controls.Add(this.grpEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InserirFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InserirFuncionário";
            this.Load += new System.EventHandler(this.InserirFuncionário_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRetornar)).EndInit();
            this.grpEstado.ResumeLayout(false);
            this.grpEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.PictureBox picRetornar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpEstado;
        private System.Windows.Forms.TextBox txtSenhaFuncionario;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.TextBox txtEmailFuncionario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.MaskedTextBox mskTelefoneFuncionario;
        private System.Windows.Forms.MaskedTextBox mskRGFuncionario;
        private System.Windows.Forms.DateTimePicker dtpDataNascimentoFuncionario;
        private System.Windows.Forms.ComboBox cboEstadoFuncionario;
        private System.Windows.Forms.ComboBox cboTipoFuncionario;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnderecoFuncionario;
        private System.Windows.Forms.TextBox txtBairroFuncionario;
        private System.Windows.Forms.TextBox txtCidadeFuncionario;
        private System.Windows.Forms.TextBox txtPaisFuncionario;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Button BtnShowExcluir;
        private System.Windows.Forms.Button btnShowAtualizar;
        private System.Windows.Forms.Button btnInserirFuncionario;
    }
}