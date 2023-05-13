namespace CasaMendes.Formularios
{
    partial class frmCadastrarFornecedores
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
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mkbCelular = new System.Windows.Forms.MaskedTextBox();
            this.mkbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.lblInscricaoEstadual = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.dtpDataDoCadastro = new System.Windows.Forms.DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDataDoCadastro = new System.Windows.Forms.Label();
            this.mkbInscricaoEstadual = new System.Windows.Forms.MaskedTextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.mkbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mkbCep = new System.Windows.Forms.MaskedTextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lbltxtCodigoDoFornecedor = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtCodigoDoFornecedor = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbEstado
            // 
            this.cbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEstado.BackColor = System.Drawing.SystemColors.Window;
            this.cbEstado.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbEstado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbEstado.Location = new System.Drawing.Point(12, 143);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbEstado.Size = new System.Drawing.Size(57, 21);
            this.cbEstado.TabIndex = 163;
            this.cbEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbEstado_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(200, 208);
            this.txtEmail.MaxLength = 80;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 20);
            this.txtEmail.TabIndex = 161;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Blue;
            this.lblEmail.Location = new System.Drawing.Point(200, 190);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 160;
            this.lblEmail.Text = "Email:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.BackColor = System.Drawing.SystemColors.Control;
            this.lblCelular.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.ForeColor = System.Drawing.Color.Blue;
            this.lblCelular.Location = new System.Drawing.Point(101, 190);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCelular.Size = new System.Drawing.Size(56, 15);
            this.lblCelular.TabIndex = 159;
            this.lblCelular.Text = "Celeular:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.SystemColors.Control;
            this.lblTelefone.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.Blue;
            this.lblTelefone.Location = new System.Drawing.Point(9, 190);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTelefone.Size = new System.Drawing.Size(58, 15);
            this.lblTelefone.TabIndex = 157;
            this.lblTelefone.Text = "Telefone:";
            // 
            // mkbCelular
            // 
            this.mkbCelular.Location = new System.Drawing.Point(104, 208);
            this.mkbCelular.Mask = "(##) #####-####";
            this.mkbCelular.Name = "mkbCelular";
            this.mkbCelular.Size = new System.Drawing.Size(80, 20);
            this.mkbCelular.TabIndex = 156;
            this.mkbCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mkbCelular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mkbCelular_KeyDown);
            // 
            // mkbTelefone
            // 
            this.mkbTelefone.Location = new System.Drawing.Point(12, 208);
            this.mkbTelefone.Mask = "(##) ####-####";
            this.mkbTelefone.Name = "mkbTelefone";
            this.mkbTelefone.Size = new System.Drawing.Size(80, 20);
            this.mkbTelefone.TabIndex = 154;
            this.mkbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mkbTelefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mkbTelefone_KeyDown);
            // 
            // txtSite
            // 
            this.txtSite.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSite.Location = new System.Drawing.Point(12, 273);
            this.txtSite.MaxLength = 80;
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(396, 20);
            this.txtSite.TabIndex = 144;
            this.txtSite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSite_KeyDown);
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.BackColor = System.Drawing.SystemColors.Control;
            this.lblSite.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSite.ForeColor = System.Drawing.Color.Blue;
            this.lblSite.Location = new System.Drawing.Point(12, 255);
            this.lblSite.Name = "lblSite";
            this.lblSite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSite.Size = new System.Drawing.Size(31, 15);
            this.lblSite.TabIndex = 142;
            this.lblSite.Text = "Site:";
            // 
            // lblInscricaoEstadual
            // 
            this.lblInscricaoEstadual.AutoSize = true;
            this.lblInscricaoEstadual.BackColor = System.Drawing.SystemColors.Control;
            this.lblInscricaoEstadual.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblInscricaoEstadual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscricaoEstadual.ForeColor = System.Drawing.Color.Blue;
            this.lblInscricaoEstadual.Location = new System.Drawing.Point(197, 126);
            this.lblInscricaoEstadual.Name = "lblInscricaoEstadual";
            this.lblInscricaoEstadual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInscricaoEstadual.Size = new System.Drawing.Size(83, 15);
            this.lblInscricaoEstadual.TabIndex = 153;
            this.lblInscricaoEstadual.Text = "Insc Estadual:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.SystemColors.Control;
            this.lblBairro.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.Blue;
            this.lblBairro.Location = new System.Drawing.Point(269, 69);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBairro.Size = new System.Drawing.Size(43, 15);
            this.lblBairro.TabIndex = 152;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.AcceptsReturn = true;
            this.txtBairro.BackColor = System.Drawing.SystemColors.Window;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBairro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBairro.Location = new System.Drawing.Point(272, 87);
            this.txtBairro.MaxLength = 35;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBairro.Size = new System.Drawing.Size(136, 20);
            this.txtBairro.TabIndex = 151;
            this.txtBairro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBairro_KeyDown);
            // 
            // dtpDataDoCadastro
            // 
            this.dtpDataDoCadastro.CustomFormat = "##/##/####";
            this.dtpDataDoCadastro.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDataDoCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDoCadastro.Location = new System.Drawing.Point(323, 144);
            this.dtpDataDoCadastro.Name = "dtpDataDoCadastro";
            this.dtpDataDoCadastro.Size = new System.Drawing.Size(85, 20);
            this.dtpDataDoCadastro.TabIndex = 130;
            this.dtpDataDoCadastro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDataDoCadastro_KeyDown);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.SystemColors.Control;
            this.lblEstado.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Blue;
            this.lblEstado.Location = new System.Drawing.Point(9, 125);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEstado.Size = new System.Drawing.Size(48, 15);
            this.lblEstado.TabIndex = 150;
            this.lblEstado.Text = "Estado:";
            // 
            // lblDataDoCadastro
            // 
            this.lblDataDoCadastro.AutoSize = true;
            this.lblDataDoCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.lblDataDoCadastro.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDataDoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDoCadastro.ForeColor = System.Drawing.Color.Blue;
            this.lblDataDoCadastro.Location = new System.Drawing.Point(320, 126);
            this.lblDataDoCadastro.Name = "lblDataDoCadastro";
            this.lblDataDoCadastro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDataDoCadastro.Size = new System.Drawing.Size(88, 15);
            this.lblDataDoCadastro.TabIndex = 141;
            this.lblDataDoCadastro.Text = "Data Cadastro:";
            // 
            // mkbInscricaoEstadual
            // 
            this.mkbInscricaoEstadual.AllowPromptAsInput = false;
            this.mkbInscricaoEstadual.Location = new System.Drawing.Point(200, 144);
            this.mkbInscricaoEstadual.Mask = "000,000,000,000";
            this.mkbInscricaoEstadual.Name = "mkbInscricaoEstadual";
            this.mkbInscricaoEstadual.Size = new System.Drawing.Size(91, 20);
            this.mkbInscricaoEstadual.TabIndex = 129;
            this.mkbInscricaoEstadual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mkbInscricaoEstadual_KeyDown);
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.BackColor = System.Drawing.SystemColors.Control;
            this.lblCnpj.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.ForeColor = System.Drawing.Color.Blue;
            this.lblCnpj.Location = new System.Drawing.Point(80, 125);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCnpj.Size = new System.Drawing.Size(41, 15);
            this.lblCnpj.TabIndex = 143;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.SystemColors.Control;
            this.lblCidade.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.Color.Blue;
            this.lblCidade.Location = new System.Drawing.Point(80, 69);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCidade.Size = new System.Drawing.Size(49, 15);
            this.lblCidade.TabIndex = 149;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.AcceptsReturn = true;
            this.txtCidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCidade.Location = new System.Drawing.Point(83, 87);
            this.txtCidade.MaxLength = 35;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCidade.Size = new System.Drawing.Size(162, 20);
            this.txtCidade.TabIndex = 148;
            this.txtCidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCidade_KeyDown);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.BackColor = System.Drawing.SystemColors.Control;
            this.lblCep.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.ForeColor = System.Drawing.Color.Blue;
            this.lblCep.Location = new System.Drawing.Point(9, 69);
            this.lblCep.Name = "lblCep";
            this.lblCep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCep.Size = new System.Drawing.Size(40, 15);
            this.lblCep.TabIndex = 146;
            this.lblCep.Text = "C.E.P:";
            // 
            // mkbCNPJ
            // 
            this.mkbCNPJ.Location = new System.Drawing.Point(83, 143);
            this.mkbCNPJ.Mask = "##.###.###/####-##";
            this.mkbCNPJ.Name = "mkbCNPJ";
            this.mkbCNPJ.Size = new System.Drawing.Size(101, 20);
            this.mkbCNPJ.TabIndex = 128;
            this.mkbCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mkbCNPJ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mkbCNPJ_KeyDown);
            // 
            // mkbCep
            // 
            this.mkbCep.Location = new System.Drawing.Point(12, 87);
            this.mkbCep.Mask = "#####-###";
            this.mkbCep.Name = "mkbCep";
            this.mkbCep.Size = new System.Drawing.Size(55, 20);
            this.mkbCep.TabIndex = 147;
            this.mkbCep.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mkbCep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mkbCep_KeyDown);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.SystemColors.Control;
            this.lblEndereco.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.Color.Blue;
            this.lblEndereco.Location = new System.Drawing.Point(269, 8);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEndereco.Size = new System.Drawing.Size(63, 15);
            this.lblEndereco.TabIndex = 140;
            this.lblEndereco.Text = "Endereco:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.AcceptsReturn = true;
            this.txtEndereco.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndereco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEndereco.Location = new System.Drawing.Point(272, 26);
            this.txtEndereco.MaxLength = 35;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndereco.Size = new System.Drawing.Size(136, 20);
            this.txtEndereco.TabIndex = 139;
            this.txtEndereco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEndereco_KeyDown);
            // 
            // lbltxtCodigoDoFornecedor
            // 
            this.lbltxtCodigoDoFornecedor.AutoSize = true;
            this.lbltxtCodigoDoFornecedor.Location = new System.Drawing.Point(9, 10);
            this.lbltxtCodigoDoFornecedor.Name = "lbltxtCodigoDoFornecedor";
            this.lbltxtCodigoDoFornecedor.Size = new System.Drawing.Size(43, 13);
            this.lbltxtCodigoDoFornecedor.TabIndex = 138;
            this.lbltxtCodigoDoFornecedor.Text = "Código:";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Location = new System.Drawing.Point(347, 307);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(61, 46);
            this.btnFechar.TabIndex = 137;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGravar.Location = new System.Drawing.Point(12, 307);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(65, 46);
            this.btnGravar.TabIndex = 134;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtCodigoDoFornecedor
            // 
            this.txtCodigoDoFornecedor.AcceptsReturn = true;
            this.txtCodigoDoFornecedor.BackColor = System.Drawing.Color.White;
            this.txtCodigoDoFornecedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoDoFornecedor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCodigoDoFornecedor.Location = new System.Drawing.Point(12, 26);
            this.txtCodigoDoFornecedor.MaxLength = 0;
            this.txtCodigoDoFornecedor.Name = "txtCodigoDoFornecedor";
            this.txtCodigoDoFornecedor.ReadOnly = true;
            this.txtCodigoDoFornecedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodigoDoFornecedor.Size = new System.Drawing.Size(55, 20);
            this.txtCodigoDoFornecedor.TabIndex = 132;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.BackColor = System.Drawing.SystemColors.Control;
            this.lblRazaoSocial.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.ForeColor = System.Drawing.Color.Blue;
            this.lblRazaoSocial.Location = new System.Drawing.Point(80, 8);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRazaoSocial.Size = new System.Drawing.Size(83, 15);
            this.lblRazaoSocial.TabIndex = 133;
            this.lblRazaoSocial.Text = "Razao Social:";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.AcceptsReturn = true;
            this.txtRazaoSocial.BackColor = System.Drawing.SystemColors.Window;
            this.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazaoSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRazaoSocial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRazaoSocial.Location = new System.Drawing.Point(83, 26);
            this.txtRazaoSocial.MaxLength = 35;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRazaoSocial.Size = new System.Drawing.Size(162, 20);
            this.txtRazaoSocial.TabIndex = 126;
            this.txtRazaoSocial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRazaoSocial_KeyDown);
            // 
            // frmCadastrarFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 365);
            this.ControlBox = false;
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.mkbCelular);
            this.Controls.Add(this.mkbTelefone);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.lblInscricaoEstadual);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.dtpDataDoCadastro);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblDataDoCadastro);
            this.Controls.Add(this.mkbInscricaoEstadual);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.mkbCNPJ);
            this.Controls.Add(this.mkbCep);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lbltxtCodigoDoFornecedor);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtCodigoDoFornecedor);
            this.Controls.Add(this.lblRazaoSocial);
            this.Controls.Add(this.txtRazaoSocial);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarFornecedores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFornecedores";
            //this.Load += new System.EventHandler(this.frmCadastrarFornecedores_Load);
            //this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmCadastrarFornecedores_Paint);
            //this.Move += new System.EventHandler(this.frmCadastrarFornecedores_Move);
            //this.Resize += new System.EventHandler(this.frmCadastrarFornecedores_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbEstado;
        internal System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.Label lblCelular;
        public System.Windows.Forms.Label lblTelefone;
        internal System.Windows.Forms.MaskedTextBox mkbCelular;
        internal System.Windows.Forms.MaskedTextBox mkbTelefone;
        internal System.Windows.Forms.TextBox txtSite;
        public System.Windows.Forms.Label lblSite;
        public System.Windows.Forms.Label lblInscricaoEstadual;
        public System.Windows.Forms.Label lblBairro;
        public System.Windows.Forms.TextBox txtBairro;
        internal System.Windows.Forms.DateTimePicker dtpDataDoCadastro;
        public System.Windows.Forms.Label lblEstado;
        public System.Windows.Forms.Label lblDataDoCadastro;
        public System.Windows.Forms.MaskedTextBox mkbInscricaoEstadual;
        public System.Windows.Forms.Label lblCnpj;
        public System.Windows.Forms.Label lblCidade;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.Label lblCep;
        internal System.Windows.Forms.MaskedTextBox mkbCNPJ;
        internal System.Windows.Forms.MaskedTextBox mkbCep;
        public System.Windows.Forms.Label lblEndereco;
        public System.Windows.Forms.TextBox txtEndereco;
        internal System.Windows.Forms.Label lbltxtCodigoDoFornecedor;
        internal System.Windows.Forms.Button btnFechar;
        internal System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.TextBox txtCodigoDoFornecedor;
        public System.Windows.Forms.Label lblRazaoSocial;
        public System.Windows.Forms.TextBox txtRazaoSocial;
    }
}