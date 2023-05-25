namespace CasaMendes
{
    partial class FrmCadFornecedores
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
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblCelular = new System.Windows.Forms.Label();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.MkbCelular = new System.Windows.Forms.MaskedTextBox();
            this.MkbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.TxtSite = new System.Windows.Forms.TextBox();
            this.LblSite = new System.Windows.Forms.Label();
            this.LblInscricaoEstadual = new System.Windows.Forms.Label();
            this.LblBairro = new System.Windows.Forms.Label();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.DtpDataDoCadastro = new System.Windows.Forms.DateTimePicker();
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblDataDoCadastro = new System.Windows.Forms.Label();
            this.MkbInscricaoEstadual = new System.Windows.Forms.MaskedTextBox();
            this.LblCnpj = new System.Windows.Forms.Label();
            this.LblCidade = new System.Windows.Forms.Label();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.LblCep = new System.Windows.Forms.Label();
            this.MkbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.MkbCep = new System.Windows.Forms.MaskedTextBox();
            this.LblEndereco = new System.Windows.Forms.Label();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.LbltxtCodigoDoFornecedor = new System.Windows.Forms.Label();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.TxtCodigoDoFornecedor = new System.Windows.Forms.TextBox();
            this.LblRazaoSocial = new System.Windows.Forms.Label();
            this.TxtRazaoSocial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CbEstado
            // 
            this.CbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbEstado.BackColor = System.Drawing.SystemColors.Window;
            this.CbEstado.Cursor = System.Windows.Forms.Cursors.Default;
            this.CbEstado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CbEstado.Location = new System.Drawing.Point(12, 143);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CbEstado.Size = new System.Drawing.Size(57, 21);
            this.CbEstado.TabIndex = 163;
            this.CbEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CbEstado_KeyDown);
            // 
            // TxtEmail
            // 
            this.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtEmail.Location = new System.Drawing.Point(200, 208);
            this.TxtEmail.MaxLength = 80;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(208, 20);
            this.TxtEmail.TabIndex = 161;
            this.TxtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEmail_KeyDown);
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.BackColor = System.Drawing.SystemColors.Control;
            this.LblEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.ForeColor = System.Drawing.Color.Blue;
            this.LblEmail.Location = new System.Drawing.Point(200, 190);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblEmail.Size = new System.Drawing.Size(42, 15);
            this.LblEmail.TabIndex = 160;
            this.LblEmail.Text = "Email:";
            // 
            // LblCelular
            // 
            this.LblCelular.AutoSize = true;
            this.LblCelular.BackColor = System.Drawing.SystemColors.Control;
            this.LblCelular.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCelular.ForeColor = System.Drawing.Color.Blue;
            this.LblCelular.Location = new System.Drawing.Point(101, 190);
            this.LblCelular.Name = "LblCelular";
            this.LblCelular.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblCelular.Size = new System.Drawing.Size(56, 15);
            this.LblCelular.TabIndex = 159;
            this.LblCelular.Text = "Celeular:";
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.BackColor = System.Drawing.SystemColors.Control;
            this.LblTelefone.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefone.ForeColor = System.Drawing.Color.Blue;
            this.LblTelefone.Location = new System.Drawing.Point(9, 190);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblTelefone.Size = new System.Drawing.Size(58, 15);
            this.LblTelefone.TabIndex = 157;
            this.LblTelefone.Text = "Telefone:";
            // 
            // MkbCelular
            // 
            this.MkbCelular.Location = new System.Drawing.Point(104, 208);
            this.MkbCelular.Mask = "(##) #####-####";
            this.MkbCelular.Name = "MkbCelular";
            this.MkbCelular.Size = new System.Drawing.Size(80, 20);
            this.MkbCelular.TabIndex = 156;
            this.MkbCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.MkbCelular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MkbCelular_KeyDown);
            // 
            // MkbTelefone
            // 
            this.MkbTelefone.Location = new System.Drawing.Point(12, 208);
            this.MkbTelefone.Mask = "(##) ####-####";
            this.MkbTelefone.Name = "MkbTelefone";
            this.MkbTelefone.Size = new System.Drawing.Size(80, 20);
            this.MkbTelefone.TabIndex = 154;
            this.MkbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.MkbTelefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MkbTelefone_KeyDown);
            // 
            // TxtSite
            // 
            this.TxtSite.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtSite.Location = new System.Drawing.Point(12, 273);
            this.TxtSite.MaxLength = 80;
            this.TxtSite.Name = "TxtSite";
            this.TxtSite.Size = new System.Drawing.Size(396, 20);
            this.TxtSite.TabIndex = 144;
            this.TxtSite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSite_KeyDown);
            // 
            // LblSite
            // 
            this.LblSite.AutoSize = true;
            this.LblSite.BackColor = System.Drawing.SystemColors.Control;
            this.LblSite.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSite.ForeColor = System.Drawing.Color.Blue;
            this.LblSite.Location = new System.Drawing.Point(12, 255);
            this.LblSite.Name = "LblSite";
            this.LblSite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblSite.Size = new System.Drawing.Size(31, 15);
            this.LblSite.TabIndex = 142;
            this.LblSite.Text = "Site:";
            // 
            // LblInscricaoEstadual
            // 
            this.LblInscricaoEstadual.AutoSize = true;
            this.LblInscricaoEstadual.BackColor = System.Drawing.SystemColors.Control;
            this.LblInscricaoEstadual.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblInscricaoEstadual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInscricaoEstadual.ForeColor = System.Drawing.Color.Blue;
            this.LblInscricaoEstadual.Location = new System.Drawing.Point(197, 126);
            this.LblInscricaoEstadual.Name = "LblInscricaoEstadual";
            this.LblInscricaoEstadual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblInscricaoEstadual.Size = new System.Drawing.Size(83, 15);
            this.LblInscricaoEstadual.TabIndex = 153;
            this.LblInscricaoEstadual.Text = "Insc Estadual:";
            // 
            // LblBairro
            // 
            this.LblBairro.AutoSize = true;
            this.LblBairro.BackColor = System.Drawing.SystemColors.Control;
            this.LblBairro.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBairro.ForeColor = System.Drawing.Color.Blue;
            this.LblBairro.Location = new System.Drawing.Point(269, 69);
            this.LblBairro.Name = "LblBairro";
            this.LblBairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblBairro.Size = new System.Drawing.Size(43, 15);
            this.LblBairro.TabIndex = 152;
            this.LblBairro.Text = "Bairro:";
            // 
            // TxtBairro
            // 
            this.TxtBairro.AcceptsReturn = true;
            this.TxtBairro.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBairro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtBairro.Location = new System.Drawing.Point(272, 87);
            this.TxtBairro.MaxLength = 35;
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtBairro.Size = new System.Drawing.Size(136, 20);
            this.TxtBairro.TabIndex = 151;
            this.TxtBairro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBairro_KeyDown);
            // 
            // DtpDataDoCadastro
            // 
            this.DtpDataDoCadastro.CustomFormat = "##/##/####";
            this.DtpDataDoCadastro.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DtpDataDoCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataDoCadastro.Location = new System.Drawing.Point(323, 144);
            this.DtpDataDoCadastro.Name = "DtpDataDoCadastro";
            this.DtpDataDoCadastro.Size = new System.Drawing.Size(85, 20);
            this.DtpDataDoCadastro.TabIndex = 130;
            this.DtpDataDoCadastro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DtpDataDoCadastro_KeyDown);
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.BackColor = System.Drawing.SystemColors.Control;
            this.LblEstado.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.ForeColor = System.Drawing.Color.Blue;
            this.LblEstado.Location = new System.Drawing.Point(9, 125);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblEstado.Size = new System.Drawing.Size(48, 15);
            this.LblEstado.TabIndex = 150;
            this.LblEstado.Text = "Estado:";
            // 
            // LblDataDoCadastro
            // 
            this.LblDataDoCadastro.AutoSize = true;
            this.LblDataDoCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.LblDataDoCadastro.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblDataDoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataDoCadastro.ForeColor = System.Drawing.Color.Blue;
            this.LblDataDoCadastro.Location = new System.Drawing.Point(320, 126);
            this.LblDataDoCadastro.Name = "LblDataDoCadastro";
            this.LblDataDoCadastro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblDataDoCadastro.Size = new System.Drawing.Size(88, 15);
            this.LblDataDoCadastro.TabIndex = 141;
            this.LblDataDoCadastro.Text = "Data Cadastro:";
            // 
            // MkbInscricaoEstadual
            // 
            this.MkbInscricaoEstadual.AllowPromptAsInput = false;
            this.MkbInscricaoEstadual.Location = new System.Drawing.Point(200, 144);
            this.MkbInscricaoEstadual.Mask = "000,000,000,000";
            this.MkbInscricaoEstadual.Name = "MkbInscricaoEstadual";
            this.MkbInscricaoEstadual.Size = new System.Drawing.Size(91, 20);
            this.MkbInscricaoEstadual.TabIndex = 129;
            this.MkbInscricaoEstadual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MkbInscricaoEstadual_KeyDown);
            // 
            // LblCnpj
            // 
            this.LblCnpj.AutoSize = true;
            this.LblCnpj.BackColor = System.Drawing.SystemColors.Control;
            this.LblCnpj.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCnpj.ForeColor = System.Drawing.Color.Blue;
            this.LblCnpj.Location = new System.Drawing.Point(80, 125);
            this.LblCnpj.Name = "LblCnpj";
            this.LblCnpj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblCnpj.Size = new System.Drawing.Size(41, 15);
            this.LblCnpj.TabIndex = 143;
            this.LblCnpj.Text = "CNPJ:";
            // 
            // LblCidade
            // 
            this.LblCidade.AutoSize = true;
            this.LblCidade.BackColor = System.Drawing.SystemColors.Control;
            this.LblCidade.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCidade.ForeColor = System.Drawing.Color.Blue;
            this.LblCidade.Location = new System.Drawing.Point(80, 69);
            this.LblCidade.Name = "LblCidade";
            this.LblCidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblCidade.Size = new System.Drawing.Size(49, 15);
            this.LblCidade.TabIndex = 149;
            this.LblCidade.Text = "Cidade:";
            // 
            // TxtCidade
            // 
            this.TxtCidade.AcceptsReturn = true;
            this.TxtCidade.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtCidade.Location = new System.Drawing.Point(83, 87);
            this.TxtCidade.MaxLength = 35;
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtCidade.Size = new System.Drawing.Size(162, 20);
            this.TxtCidade.TabIndex = 148;
            this.TxtCidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCidade_KeyDown);
            // 
            // LblCep
            // 
            this.LblCep.AutoSize = true;
            this.LblCep.BackColor = System.Drawing.SystemColors.Control;
            this.LblCep.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCep.ForeColor = System.Drawing.Color.Blue;
            this.LblCep.Location = new System.Drawing.Point(9, 69);
            this.LblCep.Name = "LblCep";
            this.LblCep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblCep.Size = new System.Drawing.Size(40, 15);
            this.LblCep.TabIndex = 146;
            this.LblCep.Text = "C.E.P:";
            // 
            // MkbCNPJ
            // 
            this.MkbCNPJ.Location = new System.Drawing.Point(83, 143);
            this.MkbCNPJ.Mask = "##.###.###/####-##";
            this.MkbCNPJ.Name = "MkbCNPJ";
            this.MkbCNPJ.Size = new System.Drawing.Size(101, 20);
            this.MkbCNPJ.TabIndex = 128;
            this.MkbCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.MkbCNPJ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MkbCNPJ_KeyDown);
            // 
            // MkbCep
            // 
            this.MkbCep.Location = new System.Drawing.Point(12, 87);
            this.MkbCep.Mask = "#####-###";
            this.MkbCep.Name = "MkbCep";
            this.MkbCep.Size = new System.Drawing.Size(55, 20);
            this.MkbCep.TabIndex = 147;
            this.MkbCep.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.MkbCep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MkbCep_KeyDown);
            // 
            // LblEndereco
            // 
            this.LblEndereco.AutoSize = true;
            this.LblEndereco.BackColor = System.Drawing.SystemColors.Control;
            this.LblEndereco.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEndereco.ForeColor = System.Drawing.Color.Blue;
            this.LblEndereco.Location = new System.Drawing.Point(269, 8);
            this.LblEndereco.Name = "LblEndereco";
            this.LblEndereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblEndereco.Size = new System.Drawing.Size(63, 15);
            this.LblEndereco.TabIndex = 140;
            this.LblEndereco.Text = "Endereco:";
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.AcceptsReturn = true;
            this.TxtEndereco.BackColor = System.Drawing.SystemColors.Window;
            this.TxtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEndereco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtEndereco.Location = new System.Drawing.Point(272, 26);
            this.TxtEndereco.MaxLength = 35;
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtEndereco.Size = new System.Drawing.Size(136, 20);
            this.TxtEndereco.TabIndex = 139;
            this.TxtEndereco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEndereco_KeyDown);
            // 
            // LbltxtCodigoDoFornecedor
            // 
            this.LbltxtCodigoDoFornecedor.AutoSize = true;
            this.LbltxtCodigoDoFornecedor.Location = new System.Drawing.Point(9, 10);
            this.LbltxtCodigoDoFornecedor.Name = "LbltxtCodigoDoFornecedor";
            this.LbltxtCodigoDoFornecedor.Size = new System.Drawing.Size(43, 13);
            this.LbltxtCodigoDoFornecedor.TabIndex = 138;
            this.LbltxtCodigoDoFornecedor.Text = "Código:";
            // 
            // BtnFechar
            // 
            this.BtnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnFechar.Location = new System.Drawing.Point(347, 307);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(61, 46);
            this.BtnFechar.TabIndex = 137;
            this.BtnFechar.Text = "&Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnGravar.Location = new System.Drawing.Point(12, 307);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(65, 46);
            this.BtnGravar.TabIndex = 134;
            this.BtnGravar.Text = "&Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // TxtCodigoDoFornecedor
            // 
            this.TxtCodigoDoFornecedor.AcceptsReturn = true;
            this.TxtCodigoDoFornecedor.BackColor = System.Drawing.Color.White;
            this.TxtCodigoDoFornecedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCodigoDoFornecedor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtCodigoDoFornecedor.Location = new System.Drawing.Point(12, 26);
            this.TxtCodigoDoFornecedor.MaxLength = 0;
            this.TxtCodigoDoFornecedor.Name = "TxtCodigoDoFornecedor";
            this.TxtCodigoDoFornecedor.ReadOnly = true;
            this.TxtCodigoDoFornecedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtCodigoDoFornecedor.Size = new System.Drawing.Size(55, 20);
            this.TxtCodigoDoFornecedor.TabIndex = 132;
            // 
            // LblRazaoSocial
            // 
            this.LblRazaoSocial.AutoSize = true;
            this.LblRazaoSocial.BackColor = System.Drawing.SystemColors.Control;
            this.LblRazaoSocial.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRazaoSocial.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LblRazaoSocial.Location = new System.Drawing.Point(80, 8);
            this.LblRazaoSocial.Name = "LblRazaoSocial";
            this.LblRazaoSocial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblRazaoSocial.Size = new System.Drawing.Size(83, 15);
            this.LblRazaoSocial.TabIndex = 133;
            this.LblRazaoSocial.Text = "Razao Social:";
            // 
            // TxtRazaoSocial
            // 
            this.TxtRazaoSocial.AcceptsReturn = true;
            this.TxtRazaoSocial.BackColor = System.Drawing.SystemColors.Window;
            this.TxtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtRazaoSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRazaoSocial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtRazaoSocial.Location = new System.Drawing.Point(83, 26);
            this.TxtRazaoSocial.MaxLength = 35;
            this.TxtRazaoSocial.Name = "TxtRazaoSocial";
            this.TxtRazaoSocial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtRazaoSocial.Size = new System.Drawing.Size(162, 20);
            this.TxtRazaoSocial.TabIndex = 126;
            this.TxtRazaoSocial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtRazaoSocial_KeyDown);
            // 
            // FrmCadFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 365);
            this.Controls.Add(this.CbEstado);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblCelular);
            this.Controls.Add(this.LblTelefone);
            this.Controls.Add(this.MkbCelular);
            this.Controls.Add(this.MkbTelefone);
            this.Controls.Add(this.TxtSite);
            this.Controls.Add(this.LblSite);
            this.Controls.Add(this.LblInscricaoEstadual);
            this.Controls.Add(this.LblBairro);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.DtpDataDoCadastro);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.LblDataDoCadastro);
            this.Controls.Add(this.MkbInscricaoEstadual);
            this.Controls.Add(this.LblCnpj);
            this.Controls.Add(this.LblCidade);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.LblCep);
            this.Controls.Add(this.MkbCNPJ);
            this.Controls.Add(this.MkbCep);
            this.Controls.Add(this.LblEndereco);
            this.Controls.Add(this.TxtEndereco);
            this.Controls.Add(this.LbltxtCodigoDoFornecedor);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.TxtCodigoDoFornecedor);
            this.Controls.Add(this.LblRazaoSocial);
            this.Controls.Add(this.TxtRazaoSocial);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadFornecedores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFornecedores";
            this.Load += new System.EventHandler(this.FrmCadastrarFornecedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox CbEstado;
        internal System.Windows.Forms.TextBox TxtEmail;
        public System.Windows.Forms.Label LblEmail;
        public System.Windows.Forms.Label LblCelular;
        public System.Windows.Forms.Label LblTelefone;
        internal System.Windows.Forms.MaskedTextBox MkbCelular;
        internal System.Windows.Forms.MaskedTextBox MkbTelefone;
        internal System.Windows.Forms.TextBox TxtSite;
        public System.Windows.Forms.Label LblSite;
        public System.Windows.Forms.Label LblInscricaoEstadual;
        public System.Windows.Forms.Label LblBairro;
        public System.Windows.Forms.TextBox TxtBairro;
        internal System.Windows.Forms.DateTimePicker DtpDataDoCadastro;
        public System.Windows.Forms.Label LblEstado;
        public System.Windows.Forms.Label LblDataDoCadastro;
        public System.Windows.Forms.MaskedTextBox MkbInscricaoEstadual;
        public System.Windows.Forms.Label LblCnpj;
        public System.Windows.Forms.Label LblCidade;
        public System.Windows.Forms.TextBox TxtCidade;
        public System.Windows.Forms.Label LblCep;
        internal System.Windows.Forms.MaskedTextBox MkbCNPJ;
        internal System.Windows.Forms.MaskedTextBox MkbCep;
        public System.Windows.Forms.Label LblEndereco;
        public System.Windows.Forms.TextBox TxtEndereco;
        internal System.Windows.Forms.Label LbltxtCodigoDoFornecedor;
        internal System.Windows.Forms.Button BtnFechar;
        internal System.Windows.Forms.Button BtnGravar;
        public System.Windows.Forms.TextBox TxtCodigoDoFornecedor;
        public System.Windows.Forms.Label LblRazaoSocial;
        public System.Windows.Forms.TextBox TxtRazaoSocial;
    }
}