namespace CasaMendes
{
    partial class FrmCadFuncionario
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
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.mkbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblPicFoto = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mkbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.PicFoto = new System.Windows.Forms.PictureBox();
            this.mkbCelular = new System.Windows.Forms.MaskedTextBox();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.mkbRg = new System.Windows.Forms.MaskedTextBox();
            this.mkbCep = new System.Windows.Forms.MaskedTextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnGravar = new System.Windows.Forms.Button();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNomes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomes)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPais
            // 
            this.cbPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(546, 155);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(224, 26);
            this.cbPais.TabIndex = 6;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.BackColor = System.Drawing.Color.Transparent;
            this.lblPais.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.ForeColor = System.Drawing.Color.Blue;
            this.lblPais.Location = new System.Drawing.Point(506, 160);
            this.lblPais.Name = "lblPais";
            this.lblPais.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPais.Size = new System.Drawing.Size(34, 15);
            this.lblPais.TabIndex = 27;
            this.lblPais.Text = "País:";
            this.lblPais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mkbCpf
            // 
            this.mkbCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbCpf.Location = new System.Drawing.Point(319, 199);
            this.mkbCpf.Mask = "###.###.###-##";
            this.mkbCpf.Name = "mkbCpf";
            this.mkbCpf.Size = new System.Drawing.Size(132, 26);
            this.mkbCpf.TabIndex = 8;
            this.mkbCpf.TextChanged += new System.EventHandler(this.mkbCpf_TextChanged);
            // 
            // lblPicFoto
            // 
            this.lblPicFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPicFoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPicFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPicFoto.ForeColor = System.Drawing.Color.Blue;
            this.lblPicFoto.Location = new System.Drawing.Point(776, 8);
            this.lblPicFoto.Name = "lblPicFoto";
            this.lblPicFoto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPicFoto.Size = new System.Drawing.Size(133, 20);
            this.lblPicFoto.TabIndex = 23;
            this.lblPicFoto.Text = "Foto:";
            this.lblPicFoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPicFoto.Click += new System.EventHandler(this.lblPicFoto_Click);
            // 
            // txtBairro
            // 
            this.txtBairro.AcceptsReturn = true;
            this.txtBairro.BackColor = System.Drawing.SystemColors.Window;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBairro.Location = new System.Drawing.Point(655, 106);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBairro.Size = new System.Drawing.Size(115, 27);
            this.txtBairro.TabIndex = 4;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.BackColor = System.Drawing.Color.Transparent;
            this.lblCelular.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.ForeColor = System.Drawing.Color.Blue;
            this.lblCelular.Location = new System.Drawing.Point(506, 251);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCelular.Size = new System.Drawing.Size(49, 15);
            this.lblCelular.TabIndex = 37;
            this.lblCelular.Text = "Celular:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.Blue;
            this.lblTelefone.Location = new System.Drawing.Point(712, 252);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTelefone.Size = new System.Drawing.Size(58, 15);
            this.lblTelefone.TabIndex = 38;
            this.lblTelefone.Text = "Telefpne:";
            // 
            // mkbTelefone
            // 
            this.mkbTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbTelefone.Location = new System.Drawing.Point(776, 247);
            this.mkbTelefone.Mask = "(##)####-####";
            this.mkbTelefone.Name = "mkbTelefone";
            this.mkbTelefone.Size = new System.Drawing.Size(133, 27);
            this.mkbTelefone.TabIndex = 18;
            // 
            // PicFoto
            // 
            this.PicFoto.BackColor = System.Drawing.Color.Transparent;
            this.PicFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicFoto.Location = new System.Drawing.Point(776, 29);
            this.PicFoto.Name = "PicFoto";
            this.PicFoto.Size = new System.Drawing.Size(133, 152);
            this.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicFoto.TabIndex = 235;
            this.PicFoto.TabStop = false;
            // 
            // mkbCelular
            // 
            this.mkbCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbCelular.Location = new System.Drawing.Point(561, 246);
            this.mkbCelular.Mask = "(##)#####-####";
            this.mkbCelular.Name = "mkbCelular";
            this.mkbCelular.Size = new System.Drawing.Size(129, 27);
            this.mkbCelular.TabIndex = 16;
            this.mkbCelular.TextChanged += new System.EventHandler(this.mkbCelular_TextChanged);
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbEstadoCivil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEstadoCivil.BackColor = System.Drawing.SystemColors.Window;
            this.cbEstadoCivil.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoCivil.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbEstadoCivil.Items.AddRange(new object[] {
            "Casado",
            "Solteiro",
            "Amaziado",
            "Amigado",
            "Mora junto",
            "Namora"});
            this.cbEstadoCivil.Location = new System.Drawing.Point(752, 200);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbEstadoCivil.Size = new System.Drawing.Size(157, 28);
            this.cbEstadoCivil.TabIndex = 9;
            // 
            // mkbRg
            // 
            this.mkbRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkbRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbRg.Location = new System.Drawing.Point(509, 200);
            this.mkbRg.Mask = "##.###.###-#";
            this.mkbRg.Name = "mkbRg";
            this.mkbRg.Size = new System.Drawing.Size(115, 26);
            this.mkbRg.TabIndex = 7;
            this.mkbRg.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mkbRg.TextChanged += new System.EventHandler(this.mkbRg_TextChanged);
            // 
            // mkbCep
            // 
            this.mkbCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbCep.Location = new System.Drawing.Point(320, 106);
            this.mkbCep.Mask = "#####-###";
            this.mkbCep.Name = "mkbCep";
            this.mkbCep.Size = new System.Drawing.Size(83, 27);
            this.mkbCep.TabIndex = 2;
            this.mkbCep.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mkbCep.TextChanged += new System.EventHandler(this.mkbCep_TextChanged);
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.SystemColors.Window;
            this.cbEstado.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbEstado.Location = new System.Drawing.Point(319, 155);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbEstado.Size = new System.Drawing.Size(132, 26);
            this.cbEstado.TabIndex = 5;
            // 
            // txtCidade
            // 
            this.txtCidade.AcceptsReturn = true;
            this.txtCidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCidade.Location = new System.Drawing.Point(460, 106);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCidade.Size = new System.Drawing.Size(143, 27);
            this.txtCidade.TabIndex = 3;
            // 
            // txtEndereco
            // 
            this.txtEndereco.AcceptsReturn = true;
            this.txtEndereco.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEndereco.Location = new System.Drawing.Point(319, 54);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndereco.Size = new System.Drawing.Size(451, 27);
            this.txtEndereco.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.AcceptsReturn = true;
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNome.Location = new System.Drawing.Point(440, 6);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.Size = new System.Drawing.Size(330, 26);
            this.txtNome.TabIndex = 0;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.Transparent;
            this.lblCidade.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.Color.Blue;
            this.lblCidade.Location = new System.Drawing.Point(415, 111);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCidade.Size = new System.Drawing.Size(49, 15);
            this.lblCidade.TabIndex = 24;
            this.lblCidade.Text = "Cidade:";
            this.lblCidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.BackColor = System.Drawing.Color.Transparent;
            this.lblCep.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.ForeColor = System.Drawing.Color.Blue;
            this.lblCep.Location = new System.Drawing.Point(286, 110);
            this.lblCep.Name = "lblCep";
            this.lblCep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCep.Size = new System.Drawing.Size(32, 15);
            this.lblCep.TabIndex = 23;
            this.lblCep.Text = "Cep:";
            this.lblCep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.BackColor = System.Drawing.Color.Transparent;
            this.lblRg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.ForeColor = System.Drawing.Color.Blue;
            this.lblRg.Location = new System.Drawing.Point(480, 205);
            this.lblRg.Name = "lblRg";
            this.lblRg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRg.Size = new System.Drawing.Size(28, 15);
            this.lblRg.TabIndex = 28;
            this.lblRg.Text = "RG:";
            this.lblRg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCpf.ForeColor = System.Drawing.Color.Blue;
            this.lblCpf.Location = new System.Drawing.Point(291, 206);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 29;
            this.lblCpf.Text = "CPF:";
            this.lblCpf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.Transparent;
            this.lblBairro.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.Blue;
            this.lblBairro.Location = new System.Drawing.Point(615, 111);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBairro.Size = new System.Drawing.Size(43, 15);
            this.lblBairro.TabIndex = 25;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Blue;
            this.lblEstado.Location = new System.Drawing.Point(270, 160);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEstado.Size = new System.Drawing.Size(48, 15);
            this.lblEstado.TabIndex = 26;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.BackColor = System.Drawing.Color.Transparent;
            this.lblObservacao.ForeColor = System.Drawing.Color.Blue;
            this.lblObservacao.Location = new System.Drawing.Point(250, 287);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(68, 13);
            this.lblObservacao.TabIndex = 40;
            this.lblObservacao.Text = "Observação:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Location = new System.Drawing.Point(319, 285);
            this.txtObservacao.MaxLength = 480;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(590, 82);
            this.txtObservacao.TabIndex = 19;
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.ForeColor = System.Drawing.Color.Blue;
            this.btnFechar.Location = new System.Drawing.Point(833, 383);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(76, 43);
            this.btnFechar.TabIndex = 45;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.ForeColor = System.Drawing.Color.Blue;
            this.btnNovo.Location = new System.Drawing.Point(255, 383);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(76, 43);
            this.btnNovo.TabIndex = 20;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.ForeColor = System.Drawing.Color.Blue;
            this.btnExcluir.Location = new System.Drawing.Point(500, 383);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(76, 43);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.ForeColor = System.Drawing.Color.Blue;
            this.btnCancelar.Location = new System.Drawing.Point(418, 383);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 43);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpDataDeNascimento
            // 
            this.dtpDataDeNascimento.CustomFormat = "##/##/####";
            this.dtpDataDeNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDeNascimento.Location = new System.Drawing.Point(372, 244);
            this.dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            this.dtpDataDeNascimento.Size = new System.Drawing.Size(120, 27);
            this.dtpDataDeNascimento.TabIndex = 12;
            // 
            // btnGravar
            // 
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.ForeColor = System.Drawing.Color.Blue;
            this.btnGravar.Location = new System.Drawing.Point(334, 383);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(76, 43);
            this.btnGravar.TabIndex = 203;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.BackColor = System.Drawing.Color.Transparent;
            this.lblDataNascimento.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.ForeColor = System.Drawing.Color.Blue;
            this.lblDataNascimento.Location = new System.Drawing.Point(252, 251);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDataNascimento.Size = new System.Drawing.Size(120, 15);
            this.lblDataNascimento.TabIndex = 33;
            this.lblDataNascimento.Text = "Data de nascimento:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Blue;
            this.lblNome.Location = new System.Drawing.Point(398, 11);
            this.lblNome.Name = "lblNome";
            this.lblNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNome.Size = new System.Drawing.Size(44, 15);
            this.lblNome.TabIndex = 226;
            this.lblNome.Text = "Nome:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereco.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.Color.Blue;
            this.lblEndereco.Location = new System.Drawing.Point(255, 59);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEndereco.Size = new System.Drawing.Size(63, 15);
            this.lblEndereco.TabIndex = 22;
            this.lblEndereco.Text = "Endereço:";
            this.lblEndereco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AcceptsReturn = true;
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCodigo.Location = new System.Drawing.Point(319, 7);
            this.txtCodigo.MaxLength = 0;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodigo.Size = new System.Drawing.Size(68, 26);
            this.txtCodigo.TabIndex = 41;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoCivil.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.ForeColor = System.Drawing.Color.Blue;
            this.lblEstadoCivil.Location = new System.Drawing.Point(679, 206);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEstadoCivil.Size = new System.Drawing.Size(71, 15);
            this.lblEstadoCivil.TabIndex = 30;
            this.lblEstadoCivil.Text = "Estado civíl:";
            this.lblEstadoCivil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(269, 11);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 238;
            this.label1.Text = "Código:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 240;
            this.label2.Text = "Funcionários:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvNomes
            // 
            this.dgvNomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNomes.ColumnHeadersVisible = false;
            this.dgvNomes.Location = new System.Drawing.Point(7, 22);
            this.dgvNomes.Name = "dgvNomes";
            this.dgvNomes.RowHeadersVisible = false;
            this.dgvNomes.Size = new System.Drawing.Size(232, 404);
            this.dgvNomes.TabIndex = 241;
            this.dgvNomes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNomes_CellEnter);
            // 
            // frmCadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 440);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.dgvNomes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mkbCpf);
            this.Controls.Add(this.mkbTelefone);
            this.Controls.Add(this.cbEstadoCivil);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblPicFoto);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.mkbCelular);
            this.Controls.Add(this.mkbRg);
            this.Controls.Add(this.mkbCep);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtpDataDeNascimento);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.PicFoto);
            this.MinimizeBox = false;
            this.Name = "frmCadastrarFuncionario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de funcionários";
            this.Load += new System.EventHandler(this.frmCadastroDeFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cbPais;
        public System.Windows.Forms.Label lblPais;
        public System.Windows.Forms.Label lblPicFoto;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.Label lblCelular;
        public System.Windows.Forms.Label lblTelefone;
        internal System.Windows.Forms.PictureBox PicFoto;
        public System.Windows.Forms.ComboBox cbEstadoCivil;
        public System.Windows.Forms.ComboBox cbEstado;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.TextBox txtEndereco;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.Label lblCidade;
        public System.Windows.Forms.Label lblCep;
        public System.Windows.Forms.Label lblRg;
        public System.Windows.Forms.Label lblCpf;
        public System.Windows.Forms.Label lblBairro;
        public System.Windows.Forms.Label lblEstado;
        internal System.Windows.Forms.Label lblObservacao;
        internal System.Windows.Forms.TextBox txtObservacao;
        internal System.Windows.Forms.Button btnFechar;
        internal System.Windows.Forms.Button btnNovo;
        internal System.Windows.Forms.Button btnExcluir;
        internal System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.DateTimePicker dtpDataDeNascimento;
        internal System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Label lblDataNascimento;
        public System.Windows.Forms.Label lblNome;
        public System.Windows.Forms.Label lblEndereco;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.Label lblEstadoCivil;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNomes;
        private System.Windows.Forms.MaskedTextBox mkbCpf;
        private System.Windows.Forms.MaskedTextBox mkbTelefone;
        private System.Windows.Forms.MaskedTextBox mkbCelular;
        private System.Windows.Forms.MaskedTextBox mkbRg;
        private System.Windows.Forms.MaskedTextBox mkbCep;
    }
}