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
            this.CbPais = new System.Windows.Forms.ComboBox();
            this.LblPais = new System.Windows.Forms.Label();
            this.MkbCpf = new System.Windows.Forms.MaskedTextBox();
            this.LblPicFoto = new System.Windows.Forms.Label();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.LblCelular = new System.Windows.Forms.Label();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.MkbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.PicFoto = new System.Windows.Forms.PictureBox();
            this.MkbCelular = new System.Windows.Forms.MaskedTextBox();
            this.CbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.MkbRg = new System.Windows.Forms.MaskedTextBox();
            this.MkbCep = new System.Windows.Forms.MaskedTextBox();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblCidade = new System.Windows.Forms.Label();
            this.LblCep = new System.Windows.Forms.Label();
            this.LblRg = new System.Windows.Forms.Label();
            this.LblCpf = new System.Windows.Forms.Label();
            this.LblBairro = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblObservacao = new System.Windows.Forms.Label();
            this.TxtObservacao = new System.Windows.Forms.TextBox();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.DtpDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.LblDataNascimento = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblEndereco = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.LblEstadoCivil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvFuncionarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // CbPais
            // 
            this.CbPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbPais.FormattingEnabled = true;
            this.CbPais.Location = new System.Drawing.Point(546, 155);
            this.CbPais.Name = "CbPais";
            this.CbPais.Size = new System.Drawing.Size(204, 26);
            this.CbPais.TabIndex = 6;
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.BackColor = System.Drawing.Color.Transparent;
            this.LblPais.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPais.ForeColor = System.Drawing.Color.Blue;
            this.LblPais.Location = new System.Drawing.Point(506, 160);
            this.LblPais.Name = "LblPais";
            this.LblPais.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblPais.Size = new System.Drawing.Size(34, 15);
            this.LblPais.TabIndex = 27;
            this.LblPais.Text = "País:";
            this.LblPais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MkbCpf
            // 
            this.MkbCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MkbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MkbCpf.Location = new System.Drawing.Point(319, 199);
            this.MkbCpf.Mask = "###.###.###-##";
            this.MkbCpf.Name = "MkbCpf";
            this.MkbCpf.Size = new System.Drawing.Size(132, 26);
            this.MkbCpf.TabIndex = 8;
            this.MkbCpf.TextChanged += new System.EventHandler(this.MkbCpf_TextChanged);
            // 
            // LblPicFoto
            // 
            this.LblPicFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblPicFoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblPicFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPicFoto.ForeColor = System.Drawing.Color.Blue;
            this.LblPicFoto.Location = new System.Drawing.Point(756, 4);
            this.LblPicFoto.Name = "LblPicFoto";
            this.LblPicFoto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblPicFoto.Size = new System.Drawing.Size(153, 24);
            this.LblPicFoto.TabIndex = 23;
            this.LblPicFoto.Text = "Foto:";
            this.LblPicFoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblPicFoto.Click += new System.EventHandler(this.LblPicFoto_Click);
            // 
            // TxtBairro
            // 
            this.TxtBairro.AcceptsReturn = true;
            this.TxtBairro.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBairro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtBairro.Location = new System.Drawing.Point(626, 106);
            this.TxtBairro.MaxLength = 50;
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtBairro.Size = new System.Drawing.Size(124, 27);
            this.TxtBairro.TabIndex = 4;
            // 
            // LblCelular
            // 
            this.LblCelular.AutoSize = true;
            this.LblCelular.BackColor = System.Drawing.Color.Transparent;
            this.LblCelular.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCelular.ForeColor = System.Drawing.Color.Blue;
            this.LblCelular.Location = new System.Drawing.Point(506, 251);
            this.LblCelular.Name = "LblCelular";
            this.LblCelular.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblCelular.Size = new System.Drawing.Size(49, 15);
            this.LblCelular.TabIndex = 37;
            this.LblCelular.Text = "Celular:";
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.LblTelefone.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefone.ForeColor = System.Drawing.Color.Blue;
            this.LblTelefone.Location = new System.Drawing.Point(731, 251);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblTelefone.Size = new System.Drawing.Size(58, 15);
            this.LblTelefone.TabIndex = 38;
            this.LblTelefone.Text = "Telefpne:";
            // 
            // MkbTelefone
            // 
            this.MkbTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MkbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MkbTelefone.Location = new System.Drawing.Point(795, 246);
            this.MkbTelefone.Mask = "(##)####-####";
            this.MkbTelefone.Name = "MkbTelefone";
            this.MkbTelefone.Size = new System.Drawing.Size(114, 27);
            this.MkbTelefone.TabIndex = 18;
            // 
            // PicFoto
            // 
            this.PicFoto.BackColor = System.Drawing.Color.Transparent;
            this.PicFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicFoto.Location = new System.Drawing.Point(756, 29);
            this.PicFoto.Name = "PicFoto";
            this.PicFoto.Size = new System.Drawing.Size(153, 152);
            this.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicFoto.TabIndex = 235;
            this.PicFoto.TabStop = false;
            // 
            // MkbCelular
            // 
            this.MkbCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MkbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MkbCelular.Location = new System.Drawing.Point(561, 246);
            this.MkbCelular.Mask = "(##)#####-####";
            this.MkbCelular.Name = "MkbCelular";
            this.MkbCelular.Size = new System.Drawing.Size(126, 27);
            this.MkbCelular.TabIndex = 16;
            this.MkbCelular.TextChanged += new System.EventHandler(this.MkbCelular_TextChanged);
            // 
            // CbEstadoCivil
            // 
            this.CbEstadoCivil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CbEstadoCivil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbEstadoCivil.BackColor = System.Drawing.SystemColors.Window;
            this.CbEstadoCivil.Cursor = System.Windows.Forms.Cursors.Default;
            this.CbEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEstadoCivil.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CbEstadoCivil.Items.AddRange(new object[] {
            "Casado",
            "Solteiro",
            "Amaziado",
            "Amigado",
            "Mora junto",
            "Namora"});
            this.CbEstadoCivil.Location = new System.Drawing.Point(756, 200);
            this.CbEstadoCivil.Name = "CbEstadoCivil";
            this.CbEstadoCivil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CbEstadoCivil.Size = new System.Drawing.Size(153, 28);
            this.CbEstadoCivil.TabIndex = 9;
            // 
            // MkbRg
            // 
            this.MkbRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MkbRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MkbRg.Location = new System.Drawing.Point(509, 200);
            this.MkbRg.Mask = "##.###.###-#";
            this.MkbRg.Name = "MkbRg";
            this.MkbRg.Size = new System.Drawing.Size(115, 26);
            this.MkbRg.TabIndex = 7;
            this.MkbRg.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.MkbRg.TextChanged += new System.EventHandler(this.MkbRg_TextChanged);
            // 
            // MkbCep
            // 
            this.MkbCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MkbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MkbCep.Location = new System.Drawing.Point(320, 106);
            this.MkbCep.Mask = "#####-###";
            this.MkbCep.Name = "MkbCep";
            this.MkbCep.Size = new System.Drawing.Size(83, 27);
            this.MkbCep.TabIndex = 2;
            this.MkbCep.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.MkbCep.TextChanged += new System.EventHandler(this.MkbCep_TextChanged);
            // 
            // CbEstado
            // 
            this.CbEstado.BackColor = System.Drawing.SystemColors.Window;
            this.CbEstado.Cursor = System.Windows.Forms.Cursors.Default;
            this.CbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEstado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CbEstado.Location = new System.Drawing.Point(319, 155);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CbEstado.Size = new System.Drawing.Size(132, 26);
            this.CbEstado.TabIndex = 5;
            // 
            // TxtCidade
            // 
            this.TxtCidade.AcceptsReturn = true;
            this.TxtCidade.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtCidade.Location = new System.Drawing.Point(460, 106);
            this.TxtCidade.MaxLength = 50;
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtCidade.Size = new System.Drawing.Size(116, 27);
            this.TxtCidade.TabIndex = 3;
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.AcceptsReturn = true;
            this.TxtEndereco.BackColor = System.Drawing.SystemColors.Window;
            this.TxtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEndereco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtEndereco.Location = new System.Drawing.Point(319, 54);
            this.TxtEndereco.MaxLength = 50;
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtEndereco.Size = new System.Drawing.Size(431, 27);
            this.TxtEndereco.TabIndex = 1;
            // 
            // TxtNome
            // 
            this.TxtNome.AcceptsReturn = true;
            this.TxtNome.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNome.Location = new System.Drawing.Point(440, 6);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtNome.Size = new System.Drawing.Size(310, 26);
            this.TxtNome.TabIndex = 0;
            // 
            // LblCidade
            // 
            this.LblCidade.AutoSize = true;
            this.LblCidade.BackColor = System.Drawing.Color.Transparent;
            this.LblCidade.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCidade.ForeColor = System.Drawing.Color.Blue;
            this.LblCidade.Location = new System.Drawing.Point(415, 111);
            this.LblCidade.Name = "LblCidade";
            this.LblCidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblCidade.Size = new System.Drawing.Size(49, 15);
            this.LblCidade.TabIndex = 24;
            this.LblCidade.Text = "Cidade:";
            this.LblCidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCep
            // 
            this.LblCep.AutoSize = true;
            this.LblCep.BackColor = System.Drawing.Color.Transparent;
            this.LblCep.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCep.ForeColor = System.Drawing.Color.Blue;
            this.LblCep.Location = new System.Drawing.Point(286, 110);
            this.LblCep.Name = "LblCep";
            this.LblCep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblCep.Size = new System.Drawing.Size(32, 15);
            this.LblCep.TabIndex = 23;
            this.LblCep.Text = "Cep:";
            this.LblCep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblRg
            // 
            this.LblRg.AutoSize = true;
            this.LblRg.BackColor = System.Drawing.Color.Transparent;
            this.LblRg.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRg.ForeColor = System.Drawing.Color.Blue;
            this.LblRg.Location = new System.Drawing.Point(480, 205);
            this.LblRg.Name = "LblRg";
            this.LblRg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblRg.Size = new System.Drawing.Size(28, 15);
            this.LblRg.TabIndex = 28;
            this.LblRg.Text = "RG:";
            this.LblRg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.BackColor = System.Drawing.Color.Transparent;
            this.LblCpf.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblCpf.ForeColor = System.Drawing.Color.Blue;
            this.LblCpf.Location = new System.Drawing.Point(291, 206);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblCpf.Size = new System.Drawing.Size(30, 13);
            this.LblCpf.TabIndex = 29;
            this.LblCpf.Text = "CPF:";
            this.LblCpf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblBairro
            // 
            this.LblBairro.AutoSize = true;
            this.LblBairro.BackColor = System.Drawing.Color.Transparent;
            this.LblBairro.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBairro.ForeColor = System.Drawing.Color.Blue;
            this.LblBairro.Location = new System.Drawing.Point(586, 111);
            this.LblBairro.Name = "LblBairro";
            this.LblBairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblBairro.Size = new System.Drawing.Size(43, 15);
            this.LblBairro.TabIndex = 25;
            this.LblBairro.Text = "Bairro:";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.BackColor = System.Drawing.Color.Transparent;
            this.LblEstado.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.ForeColor = System.Drawing.Color.Blue;
            this.LblEstado.Location = new System.Drawing.Point(270, 160);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblEstado.Size = new System.Drawing.Size(48, 15);
            this.LblEstado.TabIndex = 26;
            this.LblEstado.Text = "Estado:";
            this.LblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblObservacao
            // 
            this.LblObservacao.AutoSize = true;
            this.LblObservacao.BackColor = System.Drawing.Color.Transparent;
            this.LblObservacao.ForeColor = System.Drawing.Color.Blue;
            this.LblObservacao.Location = new System.Drawing.Point(255, 287);
            this.LblObservacao.Name = "LblObservacao";
            this.LblObservacao.Size = new System.Drawing.Size(68, 13);
            this.LblObservacao.TabIndex = 40;
            this.LblObservacao.Text = "Observação:";
            // 
            // TxtObservacao
            // 
            this.TxtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtObservacao.Location = new System.Drawing.Point(319, 285);
            this.TxtObservacao.MaxLength = 480;
            this.TxtObservacao.Multiline = true;
            this.TxtObservacao.Name = "TxtObservacao";
            this.TxtObservacao.Size = new System.Drawing.Size(590, 82);
            this.TxtObservacao.TabIndex = 19;
            // 
            // BtnFechar
            // 
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.ForeColor = System.Drawing.Color.Blue;
            this.BtnFechar.Location = new System.Drawing.Point(833, 383);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(76, 43);
            this.BtnFechar.TabIndex = 45;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnNovo.FlatAppearance.BorderSize = 0;
            this.BtnNovo.ForeColor = System.Drawing.Color.Blue;
            this.BtnNovo.Location = new System.Drawing.Point(319, 383);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(76, 43);
            this.BtnNovo.TabIndex = 20;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.FlatAppearance.BorderSize = 0;
            this.BtnExcluir.ForeColor = System.Drawing.Color.Blue;
            this.BtnExcluir.Location = new System.Drawing.Point(564, 383);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(76, 43);
            this.BtnExcluir.TabIndex = 22;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.ForeColor = System.Drawing.Color.Blue;
            this.BtnCancelar.Location = new System.Drawing.Point(482, 383);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(76, 43);
            this.BtnCancelar.TabIndex = 21;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // DtpDataDeNascimento
            // 
            this.DtpDataDeNascimento.CustomFormat = "##/##/####";
            this.DtpDataDeNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataDeNascimento.Location = new System.Drawing.Point(372, 244);
            this.DtpDataDeNascimento.Name = "DtpDataDeNascimento";
            this.DtpDataDeNascimento.Size = new System.Drawing.Size(113, 27);
            this.DtpDataDeNascimento.TabIndex = 12;
            // 
            // BtnGravar
            // 
            this.BtnGravar.FlatAppearance.BorderSize = 0;
            this.BtnGravar.ForeColor = System.Drawing.Color.Blue;
            this.BtnGravar.Location = new System.Drawing.Point(398, 383);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(76, 43);
            this.BtnGravar.TabIndex = 203;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // LblDataNascimento
            // 
            this.LblDataNascimento.AutoSize = true;
            this.LblDataNascimento.BackColor = System.Drawing.Color.Transparent;
            this.LblDataNascimento.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataNascimento.ForeColor = System.Drawing.Color.Blue;
            this.LblDataNascimento.Location = new System.Drawing.Point(252, 251);
            this.LblDataNascimento.Name = "LblDataNascimento";
            this.LblDataNascimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblDataNascimento.Size = new System.Drawing.Size(120, 15);
            this.LblDataNascimento.TabIndex = 33;
            this.LblDataNascimento.Text = "Data de nascimento:";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.BackColor = System.Drawing.Color.Transparent;
            this.LblNome.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.ForeColor = System.Drawing.Color.Blue;
            this.LblNome.Location = new System.Drawing.Point(398, 11);
            this.LblNome.Name = "LblNome";
            this.LblNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblNome.Size = new System.Drawing.Size(44, 15);
            this.LblNome.TabIndex = 226;
            this.LblNome.Text = "Nome:";
            this.LblNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblEndereco
            // 
            this.LblEndereco.AutoSize = true;
            this.LblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.LblEndereco.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEndereco.ForeColor = System.Drawing.Color.Blue;
            this.LblEndereco.Location = new System.Drawing.Point(255, 59);
            this.LblEndereco.Name = "LblEndereco";
            this.LblEndereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblEndereco.Size = new System.Drawing.Size(63, 15);
            this.LblEndereco.TabIndex = 22;
            this.LblEndereco.Text = "Endereço:";
            this.LblEndereco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.AcceptsReturn = true;
            this.TxtCodigo.BackColor = System.Drawing.Color.White;
            this.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtCodigo.Location = new System.Drawing.Point(319, 7);
            this.TxtCodigo.MaxLength = 0;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtCodigo.Size = new System.Drawing.Size(68, 26);
            this.TxtCodigo.TabIndex = 41;
            // 
            // LblEstadoCivil
            // 
            this.LblEstadoCivil.AutoSize = true;
            this.LblEstadoCivil.BackColor = System.Drawing.Color.Transparent;
            this.LblEstadoCivil.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstadoCivil.ForeColor = System.Drawing.Color.Blue;
            this.LblEstadoCivil.Location = new System.Drawing.Point(688, 206);
            this.LblEstadoCivil.Name = "LblEstadoCivil";
            this.LblEstadoCivil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblEstadoCivil.Size = new System.Drawing.Size(71, 15);
            this.LblEstadoCivil.TabIndex = 30;
            this.LblEstadoCivil.Text = "Estado civíl:";
            this.LblEstadoCivil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // DgvFuncionarios
            // 
            this.DgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFuncionarios.ColumnHeadersVisible = false;
            this.DgvFuncionarios.Location = new System.Drawing.Point(7, 22);
            this.DgvFuncionarios.Name = "DgvFuncionarios";
            this.DgvFuncionarios.RowHeadersVisible = false;
            this.DgvFuncionarios.Size = new System.Drawing.Size(242, 404);
            this.DgvFuncionarios.TabIndex = 241;
            this.DgvFuncionarios.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFuncionarios_CellEnter);
            // 
            // FrmCadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 440);
            this.Controls.Add(this.TxtObservacao);
            this.Controls.Add(this.CbPais);
            this.Controls.Add(this.DgvFuncionarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MkbCpf);
            this.Controls.Add(this.MkbTelefone);
            this.Controls.Add(this.CbEstadoCivil);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblEstadoCivil);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.LblPais);
            this.Controls.Add(this.LblPicFoto);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.LblCelular);
            this.Controls.Add(this.LblTelefone);
            this.Controls.Add(this.MkbCelular);
            this.Controls.Add(this.MkbRg);
            this.Controls.Add(this.MkbCep);
            this.Controls.Add(this.CbEstado);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.TxtEndereco);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblCidade);
            this.Controls.Add(this.LblCep);
            this.Controls.Add(this.LblRg);
            this.Controls.Add(this.LblBairro);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.LblObservacao);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.DtpDataDeNascimento);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.LblDataNascimento);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.LblEndereco);
            this.Controls.Add(this.PicFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadFuncionario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de funcionários";
            this.Load += new System.EventHandler(this.FrmCadastroDeFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox CbPais;
        public System.Windows.Forms.Label LblPais;
        public System.Windows.Forms.Label LblPicFoto;
        public System.Windows.Forms.TextBox TxtBairro;
        public System.Windows.Forms.Label LblCelular;
        public System.Windows.Forms.Label LblTelefone;
        internal System.Windows.Forms.PictureBox PicFoto;
        public System.Windows.Forms.ComboBox CbEstadoCivil;
        public System.Windows.Forms.ComboBox CbEstado;
        public System.Windows.Forms.TextBox TxtCidade;
        public System.Windows.Forms.TextBox TxtEndereco;
        public System.Windows.Forms.TextBox TxtNome;
        public System.Windows.Forms.Label LblCidade;
        public System.Windows.Forms.Label LblCep;
        public System.Windows.Forms.Label LblRg;
        public System.Windows.Forms.Label LblCpf;
        public System.Windows.Forms.Label LblBairro;
        public System.Windows.Forms.Label LblEstado;
        internal System.Windows.Forms.Label LblObservacao;
        internal System.Windows.Forms.TextBox TxtObservacao;
        internal System.Windows.Forms.Button BtnFechar;
        internal System.Windows.Forms.Button BtnNovo;
        internal System.Windows.Forms.Button BtnExcluir;
        internal System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.DateTimePicker DtpDataDeNascimento;
        internal System.Windows.Forms.Button BtnGravar;
        public System.Windows.Forms.Label LblDataNascimento;
        public System.Windows.Forms.Label LblNome;
        public System.Windows.Forms.Label LblEndereco;
        public System.Windows.Forms.TextBox TxtCodigo;
        public System.Windows.Forms.Label LblEstadoCivil;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvFuncionarios;
        private System.Windows.Forms.MaskedTextBox MkbCpf;
        private System.Windows.Forms.MaskedTextBox MkbTelefone;
        private System.Windows.Forms.MaskedTextBox MkbCelular;
        private System.Windows.Forms.MaskedTextBox MkbRg;
        private System.Windows.Forms.MaskedTextBox MkbCep;
    }
}