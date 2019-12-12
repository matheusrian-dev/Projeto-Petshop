namespace ProjetoPetshopFix
{
    partial class EditarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarFuncionario));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscarFuncionario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscaEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.txtCidadeFuncionario = new System.Windows.Forms.TextBox();
            this.txtPaisFuncionario = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.mskRgBusca = new System.Windows.Forms.MaskedTextBox();
            this.picRetornar = new System.Windows.Forms.PictureBox();
            this.txtCodFuncionario = new System.Windows.Forms.TextBox();
            this.lblCodFuncionario = new System.Windows.Forms.Label();
            this.dtpDataCadastroFuncionario = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpEstado.SuspendLayout();
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
            this.pnlTitulo.Size = new System.Drawing.Size(1166, 53);
            this.pnlTitulo.TabIndex = 4;
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
            this.picMinimizar.Location = new System.Drawing.Point(1115, 5);
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
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Gerenciamento de Dados dos Funcionários";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(466, 24);
            this.label6.TabIndex = 103;
            this.label6.Text = "Insira as Informações do funcionário que deseja editar:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(313, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(360, 320);
            this.dataGridView1.TabIndex = 94;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 20);
            this.label2.TabIndex = 102;
            this.label2.Text = "Digite o Nome do funcionário desejado:";
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.Location = new System.Drawing.Point(25, 128);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(282, 20);
            this.txtBuscaNome.TabIndex = 101;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditar.Location = new System.Drawing.Point(156, 360);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(146, 63);
            this.btnEditar.TabIndex = 100;
            this.btnEditar.Text = "Editar Cadastro do Funcionário";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBuscarFuncionario
            // 
            this.btnBuscarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnBuscarFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarFuncionario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBuscarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnBuscarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarFuncionario.Location = new System.Drawing.Point(25, 360);
            this.btnBuscarFuncionario.Name = "btnBuscarFuncionario";
            this.btnBuscarFuncionario.Size = new System.Drawing.Size(125, 63);
            this.btnBuscarFuncionario.TabIndex = 99;
            this.btnBuscarFuncionario.Text = "Buscar Funcionário";
            this.btnBuscarFuncionario.UseVisualStyleBackColor = false;
            this.btnBuscarFuncionario.Click += new System.EventHandler(this.btnBuscarFuncionario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 20);
            this.label3.TabIndex = 98;
            this.label3.Text = "Digite o Email do funcionário desejado:";
            // 
            // txtBuscaEmail
            // 
            this.txtBuscaEmail.Location = new System.Drawing.Point(25, 278);
            this.txtBuscaEmail.Name = "txtBuscaEmail";
            this.txtBuscaEmail.Size = new System.Drawing.Size(279, 20);
            this.txtBuscaEmail.TabIndex = 97;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 20);
            this.label5.TabIndex = 96;
            this.label5.Text = "Digite o RG do funcionário desejado:";
            // 
            // grpEstado
            // 
            this.grpEstado.Controls.Add(this.dtpDataCadastroFuncionario);
            this.grpEstado.Controls.Add(this.label7);
            this.grpEstado.Controls.Add(this.txtCodFuncionario);
            this.grpEstado.Controls.Add(this.txtSenhaFuncionario);
            this.grpEstado.Controls.Add(this.lblCodFuncionario);
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
            this.grpEstado.Controls.Add(this.txtCidadeFuncionario);
            this.grpEstado.Controls.Add(this.txtPaisFuncionario);
            this.grpEstado.Controls.Add(this.lblTelefone);
            this.grpEstado.Controls.Add(this.lblPais);
            this.grpEstado.Controls.Add(this.lblEstado);
            this.grpEstado.Controls.Add(this.lblEndereco);
            this.grpEstado.Controls.Add(this.lblCidade);
            this.grpEstado.Location = new System.Drawing.Point(679, 59);
            this.grpEstado.Name = "grpEstado";
            this.grpEstado.Size = new System.Drawing.Size(411, 379);
            this.grpEstado.TabIndex = 104;
            this.grpEstado.TabStop = false;
            this.grpEstado.Text = "Dados do Funcionário";
            // 
            // txtSenhaFuncionario
            // 
            this.txtSenhaFuncionario.Location = new System.Drawing.Point(26, 206);
            this.txtSenhaFuncionario.Name = "txtSenhaFuncionario";
            this.txtSenhaFuncionario.Size = new System.Drawing.Size(154, 20);
            this.txtSenhaFuncionario.TabIndex = 88;
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCadastro.Location = new System.Drawing.Point(22, 184);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(60, 20);
            this.lblDataCadastro.TabIndex = 87;
            this.lblDataCadastro.Text = "Senha:";
            // 
            // txtEmailFuncionario
            // 
            this.txtEmailFuncionario.Location = new System.Drawing.Point(26, 163);
            this.txtEmailFuncionario.Name = "txtEmailFuncionario";
            this.txtEmailFuncionario.Size = new System.Drawing.Size(154, 20);
            this.txtEmailFuncionario.TabIndex = 86;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(22, 141);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 85;
            this.lblEmail.Text = "Email:";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(26, 78);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(154, 20);
            this.txtNomeFuncionario.TabIndex = 84;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(22, 55);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 83;
            this.lblNome.Text = "Nome:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.Location = new System.Drawing.Point(22, 98);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(38, 20);
            this.lblRG.TabIndex = 82;
            this.lblRG.Text = "RG:";
            // 
            // mskTelefoneFuncionario
            // 
            this.mskTelefoneFuncionario.Location = new System.Drawing.Point(26, 301);
            this.mskTelefoneFuncionario.Mask = "(99) 99999-9999";
            this.mskTelefoneFuncionario.Name = "mskTelefoneFuncionario";
            this.mskTelefoneFuncionario.Size = new System.Drawing.Size(154, 20);
            this.mskTelefoneFuncionario.TabIndex = 81;
            // 
            // mskRGFuncionario
            // 
            this.mskRGFuncionario.Location = new System.Drawing.Point(26, 120);
            this.mskRGFuncionario.Mask = "AA-99,999,999";
            this.mskRGFuncionario.Name = "mskRGFuncionario";
            this.mskRGFuncionario.Size = new System.Drawing.Size(154, 20);
            this.mskRGFuncionario.TabIndex = 80;
            // 
            // dtpDataNascimentoFuncionario
            // 
            this.dtpDataNascimentoFuncionario.CustomFormat = "yyyy-MM-dd";
            this.dtpDataNascimentoFuncionario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimentoFuncionario.Location = new System.Drawing.Point(26, 252);
            this.dtpDataNascimentoFuncionario.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDataNascimentoFuncionario.Name = "dtpDataNascimentoFuncionario";
            this.dtpDataNascimentoFuncionario.Size = new System.Drawing.Size(154, 20);
            this.dtpDataNascimentoFuncionario.TabIndex = 66;
            // 
            // cboEstadoFuncionario
            // 
            this.cboEstadoFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoFuncionario.FormattingEnabled = true;
            this.cboEstadoFuncionario.Items.AddRange(new object[] {
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
            this.cboEstadoFuncionario.Location = new System.Drawing.Point(186, 163);
            this.cboEstadoFuncionario.Name = "cboEstadoFuncionario";
            this.cboEstadoFuncionario.Size = new System.Drawing.Size(200, 21);
            this.cboEstadoFuncionario.TabIndex = 75;
            // 
            // cboTipoFuncionario
            // 
            this.cboTipoFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFuncionario.FormattingEnabled = true;
            this.cboTipoFuncionario.Location = new System.Drawing.Point(186, 300);
            this.cboTipoFuncionario.Name = "cboTipoFuncionario";
            this.cboTipoFuncionario.Size = new System.Drawing.Size(200, 21);
            this.cboTipoFuncionario.TabIndex = 74;
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.Location = new System.Drawing.Point(22, 229);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(158, 20);
            this.lblDataNasc.TabIndex = 50;
            this.lblDataNasc.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Telefone:";
            // 
            // txtEnderecoFuncionario
            // 
            this.txtEnderecoFuncionario.Location = new System.Drawing.Point(186, 78);
            this.txtEnderecoFuncionario.Name = "txtEnderecoFuncionario";
            this.txtEnderecoFuncionario.Size = new System.Drawing.Size(200, 20);
            this.txtEnderecoFuncionario.TabIndex = 41;
            // 
            // txtCidadeFuncionario
            // 
            this.txtCidadeFuncionario.Location = new System.Drawing.Point(186, 120);
            this.txtCidadeFuncionario.Name = "txtCidadeFuncionario";
            this.txtCidadeFuncionario.Size = new System.Drawing.Size(200, 20);
            this.txtCidadeFuncionario.TabIndex = 43;
            // 
            // txtPaisFuncionario
            // 
            this.txtPaisFuncionario.Location = new System.Drawing.Point(186, 206);
            this.txtPaisFuncionario.Name = "txtPaisFuncionario";
            this.txtPaisFuncionario.Size = new System.Drawing.Size(200, 20);
            this.txtPaisFuncionario.TabIndex = 45;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(186, 276);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(152, 20);
            this.lblTelefone.TabIndex = 51;
            this.lblTelefone.Text = "Tipo de Funcionário:";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(186, 186);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(43, 20);
            this.lblPais.TabIndex = 56;
            this.lblPais.Text = "País:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(182, 141);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 20);
            this.lblEstado.TabIndex = 55;
            this.lblEstado.Text = "Estado:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(182, 55);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(82, 20);
            this.lblEndereco.TabIndex = 52;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(182, 98);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(63, 20);
            this.lblCidade.TabIndex = 54;
            this.lblCidade.Text = "Cidade:";
            // 
            // mskRgBusca
            // 
            this.mskRgBusca.Location = new System.Drawing.Point(25, 201);
            this.mskRgBusca.Mask = "AA-99,999,999";
            this.mskRgBusca.Name = "mskRgBusca";
            this.mskRgBusca.Size = new System.Drawing.Size(125, 20);
            this.mskRgBusca.TabIndex = 105;
            // 
            // picRetornar
            // 
            this.picRetornar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRetornar.BackgroundImage")));
            this.picRetornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picRetornar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picRetornar.ErrorImage")));
            this.picRetornar.InitialImage = ((System.Drawing.Image)(resources.GetObject("picRetornar.InitialImage")));
            this.picRetornar.Location = new System.Drawing.Point(1105, 387);
            this.picRetornar.Name = "picRetornar";
            this.picRetornar.Size = new System.Drawing.Size(49, 51);
            this.picRetornar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRetornar.TabIndex = 106;
            this.picRetornar.TabStop = false;
            this.picRetornar.Click += new System.EventHandler(this.picRetornar_Click);
            // 
            // txtCodFuncionario
            // 
            this.txtCodFuncionario.Location = new System.Drawing.Point(196, 27);
            this.txtCodFuncionario.Name = "txtCodFuncionario";
            this.txtCodFuncionario.ReadOnly = true;
            this.txtCodFuncionario.Size = new System.Drawing.Size(154, 20);
            this.txtCodFuncionario.TabIndex = 108;
            // 
            // lblCodFuncionario
            // 
            this.lblCodFuncionario.AutoSize = true;
            this.lblCodFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodFuncionario.Location = new System.Drawing.Point(21, 26);
            this.lblCodFuncionario.Name = "lblCodFuncionario";
            this.lblCodFuncionario.Size = new System.Drawing.Size(172, 20);
            this.lblCodFuncionario.TabIndex = 107;
            this.lblCodFuncionario.Text = "Código do Funcionário:";
            // 
            // dtpDataCadastroFuncionario
            // 
            this.dtpDataCadastroFuncionario.CustomFormat = "yyyy-MM-dd";
            this.dtpDataCadastroFuncionario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastroFuncionario.Location = new System.Drawing.Point(190, 252);
            this.dtpDataCadastroFuncionario.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDataCadastroFuncionario.Name = "dtpDataCadastroFuncionario";
            this.dtpDataCadastroFuncionario.Size = new System.Drawing.Size(196, 20);
            this.dtpDataCadastroFuncionario.TabIndex = 110;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(186, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 109;
            this.label7.Text = "Data de Cadastro:";
            // 
            // EditarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1166, 450);
            this.Controls.Add(this.picRetornar);
            this.Controls.Add(this.mskRgBusca);
            this.Controls.Add(this.grpEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscaNome);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscarFuncionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscaEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarFuncionario";
            this.Load += new System.EventHandler(this.EditarFuncionario_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpEstado.ResumeLayout(false);
            this.grpEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRetornar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscarFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscaEmail;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.TextBox txtCidadeFuncionario;
        private System.Windows.Forms.TextBox txtPaisFuncionario;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.MaskedTextBox mskRgBusca;
        private System.Windows.Forms.PictureBox picRetornar;
        private System.Windows.Forms.TextBox txtCodFuncionario;
        private System.Windows.Forms.Label lblCodFuncionario;
        private System.Windows.Forms.DateTimePicker dtpDataCadastroFuncionario;
        private System.Windows.Forms.Label label7;
    }
}