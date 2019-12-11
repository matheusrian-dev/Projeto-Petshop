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
            this.txtBuscaNomeExcluir = new System.Windows.Forms.TextBox();
            this.btnExcluirFuncionario = new System.Windows.Forms.Button();
            this.btnBuscarFuncionarioExcluir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscaEmailFuncionarioExcluir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscaRGFuncionarioExcluir = new System.Windows.Forms.TextBox();
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
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.pnlTitulo.Size = new System.Drawing.Size(1250, 53);
            this.pnlTitulo.TabIndex = 4;
            // 
            // picMinimizar
            // 
            this.picMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMinimizar.BackgroundImage")));
            this.picMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMinimizar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picMinimizar.ErrorImage")));
            this.picMinimizar.InitialImage = ((System.Drawing.Image)(resources.GetObject("picMinimizar.InitialImage")));
            this.picMinimizar.Location = new System.Drawing.Point(1204, 3);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(39, 42);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimizar.TabIndex = 32;
            this.picMinimizar.TabStop = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(447, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(360, 320);
            this.dataGridView1.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 21);
            this.label2.TabIndex = 102;
            this.label2.Text = "Digite o Nome do funcionário desejado:";
            // 
            // txtBuscaNomeExcluir
            // 
            this.txtBuscaNomeExcluir.Location = new System.Drawing.Point(25, 128);
            this.txtBuscaNomeExcluir.Name = "txtBuscaNomeExcluir";
            this.txtBuscaNomeExcluir.Size = new System.Drawing.Size(361, 20);
            this.txtBuscaNomeExcluir.TabIndex = 101;
            // 
            // btnExcluirFuncionario
            // 
            this.btnExcluirFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnExcluirFuncionario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnExcluirFuncionario.FlatAppearance.BorderSize = 0;
            this.btnExcluirFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirFuncionario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluirFuncionario.Location = new System.Drawing.Point(226, 347);
            this.btnExcluirFuncionario.Name = "btnExcluirFuncionario";
            this.btnExcluirFuncionario.Size = new System.Drawing.Size(190, 77);
            this.btnExcluirFuncionario.TabIndex = 100;
            this.btnExcluirFuncionario.Text = "Editar Cadastro do Funcionário";
            this.btnExcluirFuncionario.UseVisualStyleBackColor = false;
            // 
            // btnBuscarFuncionarioExcluir
            // 
            this.btnBuscarFuncionarioExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnBuscarFuncionarioExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarFuncionarioExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBuscarFuncionarioExcluir.FlatAppearance.BorderSize = 0;
            this.btnBuscarFuncionarioExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFuncionarioExcluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFuncionarioExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscarFuncionarioExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarFuncionarioExcluir.Location = new System.Drawing.Point(16, 347);
            this.btnBuscarFuncionarioExcluir.Name = "btnBuscarFuncionarioExcluir";
            this.btnBuscarFuncionarioExcluir.Size = new System.Drawing.Size(204, 77);
            this.btnBuscarFuncionarioExcluir.TabIndex = 99;
            this.btnBuscarFuncionarioExcluir.Text = "Buscar Funcionário";
            this.btnBuscarFuncionarioExcluir.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 21);
            this.label3.TabIndex = 98;
            this.label3.Text = "Digite o Email do funcionário desejado:";
            // 
            // txtBuscaEmailFuncionarioExcluir
            // 
            this.txtBuscaEmailFuncionarioExcluir.Location = new System.Drawing.Point(25, 278);
            this.txtBuscaEmailFuncionarioExcluir.Name = "txtBuscaEmailFuncionarioExcluir";
            this.txtBuscaEmailFuncionarioExcluir.Size = new System.Drawing.Size(361, 20);
            this.txtBuscaEmailFuncionarioExcluir.TabIndex = 97;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 21);
            this.label5.TabIndex = 96;
            this.label5.Text = "Digite o RG do funcionário desejado:";
            // 
            // txtBuscaRGFuncionarioExcluir
            // 
            this.txtBuscaRGFuncionarioExcluir.Location = new System.Drawing.Point(25, 202);
            this.txtBuscaRGFuncionarioExcluir.Name = "txtBuscaRGFuncionarioExcluir";
            this.txtBuscaRGFuncionarioExcluir.Size = new System.Drawing.Size(361, 20);
            this.txtBuscaRGFuncionarioExcluir.TabIndex = 95;
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
            this.grpEstado.Location = new System.Drawing.Point(832, 104);
            this.grpEstado.Name = "grpEstado";
            this.grpEstado.Size = new System.Drawing.Size(411, 320);
            this.grpEstado.TabIndex = 104;
            this.grpEstado.TabStop = false;
            this.grpEstado.Text = "Dados do Funcionário";
            // 
            // txtSenhaFuncionario
            // 
            this.txtSenhaFuncionario.Location = new System.Drawing.Point(26, 187);
            this.txtSenhaFuncionario.Name = "txtSenhaFuncionario";
            this.txtSenhaFuncionario.Size = new System.Drawing.Size(125, 20);
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
            this.txtEmailFuncionario.Size = new System.Drawing.Size(125, 20);
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
            this.txtNomeFuncionario.Location = new System.Drawing.Point(26, 59);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(125, 20);
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
            this.mskTelefoneFuncionario.Size = new System.Drawing.Size(125, 20);
            this.mskTelefoneFuncionario.TabIndex = 81;
            // 
            // mskRGFuncionario
            // 
            this.mskRGFuncionario.Location = new System.Drawing.Point(26, 101);
            this.mskRGFuncionario.Mask = "AA-99,999,999";
            this.mskRGFuncionario.Name = "mskRGFuncionario";
            this.mskRGFuncionario.Size = new System.Drawing.Size(125, 20);
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
            this.cboEstadoFuncionario.Location = new System.Drawing.Point(243, 187);
            this.cboEstadoFuncionario.Name = "cboEstadoFuncionario";
            this.cboEstadoFuncionario.Size = new System.Drawing.Size(126, 21);
            this.cboEstadoFuncionario.TabIndex = 75;
            // 
            // cboTipoFuncionario
            // 
            this.cboTipoFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFuncionario.FormattingEnabled = true;
            this.cboTipoFuncionario.Location = new System.Drawing.Point(243, 281);
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
            this.txtEnderecoFuncionario.Location = new System.Drawing.Point(243, 59);
            this.txtEnderecoFuncionario.Name = "txtEnderecoFuncionario";
            this.txtEnderecoFuncionario.Size = new System.Drawing.Size(125, 20);
            this.txtEnderecoFuncionario.TabIndex = 41;
            // 
            // txtBairroFuncionario
            // 
            this.txtBairroFuncionario.Location = new System.Drawing.Point(243, 101);
            this.txtBairroFuncionario.Name = "txtBairroFuncionario";
            this.txtBairroFuncionario.Size = new System.Drawing.Size(126, 20);
            this.txtBairroFuncionario.TabIndex = 42;
            // 
            // txtCidadeFuncionario
            // 
            this.txtCidadeFuncionario.Location = new System.Drawing.Point(243, 144);
            this.txtCidadeFuncionario.Name = "txtCidadeFuncionario";
            this.txtCidadeFuncionario.Size = new System.Drawing.Size(125, 20);
            this.txtCidadeFuncionario.TabIndex = 43;
            // 
            // txtPaisFuncionario
            // 
            this.txtPaisFuncionario.Location = new System.Drawing.Point(243, 230);
            this.txtPaisFuncionario.Name = "txtPaisFuncionario";
            this.txtPaisFuncionario.Size = new System.Drawing.Size(126, 20);
            this.txtPaisFuncionario.TabIndex = 45;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(239, 257);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(152, 20);
            this.lblTelefone.TabIndex = 51;
            this.lblTelefone.Text = "Tipo de Funcionário:";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(239, 208);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(43, 20);
            this.lblPais.TabIndex = 56;
            this.lblPais.Text = "País:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(239, 165);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 20);
            this.lblEstado.TabIndex = 55;
            this.lblEstado.Text = "Estado:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(239, 36);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(82, 20);
            this.lblEndereco.TabIndex = 52;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(239, 122);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(63, 20);
            this.lblCidade.TabIndex = 54;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(239, 79);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(55, 20);
            this.lblBairro.TabIndex = 53;
            this.lblBairro.Text = "Bairro:";
            // 
            // EditarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1250, 450);
            this.Controls.Add(this.grpEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscaNomeExcluir);
            this.Controls.Add(this.btnExcluirFuncionario);
            this.Controls.Add(this.btnBuscarFuncionarioExcluir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscaEmailFuncionarioExcluir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBuscaRGFuncionarioExcluir);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarFuncionario";
            this.Text = "EditarFuncionario";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpEstado.ResumeLayout(false);
            this.grpEstado.PerformLayout();
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
        private System.Windows.Forms.TextBox txtBuscaNomeExcluir;
        private System.Windows.Forms.Button btnExcluirFuncionario;
        private System.Windows.Forms.Button btnBuscarFuncionarioExcluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscaEmailFuncionarioExcluir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscaRGFuncionarioExcluir;
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
    }
}