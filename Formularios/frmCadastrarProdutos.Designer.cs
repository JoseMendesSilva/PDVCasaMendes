namespace CasaMendes.Formularios
{
    partial class frmCadastrarProdutos
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
            this.dtpDataDeValidade = new System.Windows.Forms.DateTimePicker();
            this.txtCodigoDoFornecedor = new System.Windows.Forms.TextBox();
            this.lblPrecoDeVenda = new System.Windows.Forms.Label();
            this.txtPrecoDeVendaVista = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblPicFoto = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.cbFornecedores = new System.Windows.Forms.ComboBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblCodigoDeBarras = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblDataDeValidade = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.PicFoto = new System.Windows.Forms.PictureBox();
            this.txtID_Produto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtValorDesconto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigoDaNotaFiscal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDataDeValidade
            // 
            this.dtpDataDeValidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataDeValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDeValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDeValidade.Location = new System.Drawing.Point(237, 148);
            this.dtpDataDeValidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDataDeValidade.Name = "dtpDataDeValidade";
            this.dtpDataDeValidade.Size = new System.Drawing.Size(101, 26);
            this.dtpDataDeValidade.TabIndex = 4;
            this.dtpDataDeValidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDataDeValidade_KeyDown);
            this.dtpDataDeValidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpDataDeValidade_KeyPress);
            // 
            // txtCodigoDoFornecedor
            // 
            this.txtCodigoDoFornecedor.Location = new System.Drawing.Point(109, 78);
            this.txtCodigoDoFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoDoFornecedor.Name = "txtCodigoDoFornecedor";
            this.txtCodigoDoFornecedor.Size = new System.Drawing.Size(54, 21);
            this.txtCodigoDoFornecedor.TabIndex = 120;
            this.txtCodigoDoFornecedor.Visible = false;
            // 
            // lblPrecoDeVenda
            // 
            this.lblPrecoDeVenda.AutoSize = true;
            this.lblPrecoDeVenda.Location = new System.Drawing.Point(1, 257);
            this.lblPrecoDeVenda.Name = "lblPrecoDeVenda";
            this.lblPrecoDeVenda.Size = new System.Drawing.Size(88, 15);
            this.lblPrecoDeVenda.TabIndex = 132;
            this.lblPrecoDeVenda.Text = "Vendas a vista:";
            // 
            // txtPrecoDeVendaVista
            // 
            this.txtPrecoDeVendaVista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoDeVendaVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoDeVendaVista.Location = new System.Drawing.Point(3, 273);
            this.txtPrecoDeVendaVista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecoDeVendaVista.Name = "txtPrecoDeVendaVista";
            this.txtPrecoDeVendaVista.Size = new System.Drawing.Size(102, 26);
            this.txtPrecoDeVendaVista.TabIndex = 9;
            this.txtPrecoDeVendaVista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecoDeVendaVista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecoDeVendaVista_KeyDown);
            this.txtPrecoDeVendaVista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoDeVendaVista_KeyPress);
            this.txtPrecoDeVendaVista.Leave += new System.EventHandler(this.txtPrecoDeVendaVista_Leave);
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(126, 255);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(62, 15);
            this.lblDesconto.TabIndex = 131;
            this.lblDesconto.Text = "Desconto:";
            // 
            // lblPicFoto
            // 
            this.lblPicFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPicFoto.AutoSize = true;
            this.lblPicFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPicFoto.Location = new System.Drawing.Point(302, 13);
            this.lblPicFoto.Name = "lblPicFoto";
            this.lblPicFoto.Size = new System.Drawing.Size(46, 20);
            this.lblPicFoto.TabIndex = 129;
            this.lblPicFoto.Text = "Foto:";
            this.lblPicFoto.Click += new System.EventHandler(this.lblPicFoto_Click);
            // 
            // txtDesconto
            // 
            this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(129, 273);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(102, 26);
            this.txtDesconto.TabIndex = 10;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDesconto_KeyDown);
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesconto_KeyPress);
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCompra.Location = new System.Drawing.Point(3, 205);
            this.txtValorCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(101, 26);
            this.txtValorCompra.TabIndex = 5;
            this.txtValorCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorCompra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorCompra_KeyDown);
            this.txtValorCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorCompra_KeyPress);
            this.txtValorCompra.Leave += new System.EventHandler(this.txtValorCompra_Leave);
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.Location = new System.Drawing.Point(-1, 186);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(82, 15);
            this.lblValorCompra.TabIndex = 130;
            this.lblValorCompra.Text = "Valor da nota:";
            // 
            // cbFornecedores
            // 
            this.cbFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFornecedores.FormattingEnabled = true;
            this.cbFornecedores.Location = new System.Drawing.Point(2, 146);
            this.cbFornecedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbFornecedores.Name = "cbFornecedores";
            this.cbFornecedores.Size = new System.Drawing.Size(228, 28);
            this.cbFornecedores.TabIndex = 3;
            this.cbFornecedores.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbFornecedores_KeyDown);
            this.cbFornecedores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbFornecedores_KeyPress);
            this.cbFornecedores.Leave += new System.EventHandler(this.cbFornecedores_Leave);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(128, 205);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(102, 26);
            this.txtQuantidade.TabIndex = 6;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantidade_KeyDown);
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            this.txtQuantidade.Leave += new System.EventHandler(this.TxtQuantidade_Leave);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(124, 189);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(74, 15);
            this.lblQuantidade.TabIndex = 127;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.Location = new System.Drawing.Point(246, 186);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(86, 15);
            this.lblPrecoUnitario.TabIndex = 123;
            this.lblPrecoUnitario.Text = "Preço unitário:";
            // 
            // txtProduto
            // 
            this.txtProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(3, 76);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(335, 26);
            this.txtProduto.TabIndex = 2;
            this.txtProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduto_KeyDown);
            this.txtProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduto_KeyPress);
            this.txtProduto.Leave += new System.EventHandler(this.txtProduto_Leave);
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoUnitario.Location = new System.Drawing.Point(250, 205);
            this.txtPrecoUnitario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(101, 26);
            this.txtPrecoUnitario.TabIndex = 7;
            this.txtPrecoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecoUnitario.TextChanged += new System.EventHandler(this.txtPrecoUnitario_TextChanged);
            this.txtPrecoUnitario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecoUnitario_KeyDown);
            this.txtPrecoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoUnitario_KeyPress);
            this.txtPrecoUnitario.Leave += new System.EventHandler(this.txtPrecoUnitario_Leave);
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(371, 189);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(55, 15);
            this.lblEstoque.TabIndex = 128;
            this.lblEstoque.Text = "Estoque:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoque.Location = new System.Drawing.Point(374, 205);
            this.txtEstoque.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(102, 26);
            this.txtEstoque.TabIndex = 8;
            this.txtEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEstoque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEstoque_KeyDown);
            this.txtEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoque_KeyPress);
            this.txtEstoque.Leave += new System.EventHandler(this.txtEstoque_Leave);
            // 
            // txtCodigoDeBarras
            // 
            this.txtCodigoDeBarras.AcceptsReturn = true;
            this.txtCodigoDeBarras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoDeBarras.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigoDeBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoDeBarras.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoDeBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDeBarras.ForeColor = System.Drawing.Color.Red;
            this.txtCodigoDeBarras.Location = new System.Drawing.Point(129, 15);
            this.txtCodigoDeBarras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoDeBarras.MaxLength = 50;
            this.txtCodigoDeBarras.Name = "txtCodigoDeBarras";
            this.txtCodigoDeBarras.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodigoDeBarras.Size = new System.Drawing.Size(167, 26);
            this.txtCodigoDeBarras.TabIndex = 1;
            this.txtCodigoDeBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigoDeBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoDeBarras_KeyDown);
            this.txtCodigoDeBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoDeBarras_KeyPress);
            this.txtCodigoDeBarras.Leave += new System.EventHandler(this.txtCodigoDeBarras_Leave);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Location = new System.Drawing.Point(375, 315);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(101, 53);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblCodigoDeBarras
            // 
            this.lblCodigoDeBarras.AutoSize = true;
            this.lblCodigoDeBarras.BackColor = System.Drawing.SystemColors.Control;
            this.lblCodigoDeBarras.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCodigoDeBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDeBarras.ForeColor = System.Drawing.Color.Red;
            this.lblCodigoDeBarras.Location = new System.Drawing.Point(125, 0);
            this.lblCodigoDeBarras.Name = "lblCodigoDeBarras";
            this.lblCodigoDeBarras.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCodigoDeBarras.Size = new System.Drawing.Size(104, 15);
            this.lblCodigoDeBarras.TabIndex = 115;
            this.lblCodigoDeBarras.Text = "Codigo de barras:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.Location = new System.Drawing.Point(127, 315);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 53);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(-1, 127);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(73, 15);
            this.lblFornecedor.TabIndex = 126;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // lblDataDeValidade
            // 
            this.lblDataDeValidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataDeValidade.AutoSize = true;
            this.lblDataDeValidade.Location = new System.Drawing.Point(236, 129);
            this.lblDataDeValidade.Name = "lblDataDeValidade";
            this.lblDataDeValidade.Size = new System.Drawing.Size(102, 15);
            this.lblDataDeValidade.TabIndex = 124;
            this.lblDataDeValidade.Text = "Data de validade:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(0, 57);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(53, 15);
            this.lblProduto.TabIndex = 122;
            this.lblProduto.Text = "Produto:";
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGravar.Location = new System.Drawing.Point(2, 315);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(102, 53);
            this.btnGravar.TabIndex = 12;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // PicFoto
            // 
            this.PicFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicFoto.Location = new System.Drawing.Point(344, 13);
            this.PicFoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PicFoto.Name = "PicFoto";
            this.PicFoto.Size = new System.Drawing.Size(132, 161);
            this.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicFoto.TabIndex = 121;
            this.PicFoto.TabStop = false;
            // 
            // txtID_Produto
            // 
            this.txtID_Produto.Location = new System.Drawing.Point(12, 76);
            this.txtID_Produto.Name = "txtID_Produto";
            this.txtID_Produto.Size = new System.Drawing.Size(100, 21);
            this.txtID_Produto.TabIndex = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 139;
            this.label1.Text = "V. desconto:";
            // 
            // TxtValorDesconto
            // 
            this.TxtValorDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtValorDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorDesconto.Location = new System.Drawing.Point(250, 273);
            this.TxtValorDesconto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtValorDesconto.Name = "TxtValorDesconto";
            this.TxtValorDesconto.Size = new System.Drawing.Size(101, 26);
            this.TxtValorDesconto.TabIndex = 11;
            this.TxtValorDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtValorDesconto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtValorDesconto_KeyDown);
            this.TxtValorDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorDesconto_KeyPress);
            this.TxtValorDesconto.Leave += new System.EventHandler(this.TxtValorDesconto_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 141;
            this.label2.Text = "Codigo da nota fiscal:";
            // 
            // TxtCodigoDaNotaFiscal
            // 
            this.TxtCodigoDaNotaFiscal.AcceptsReturn = true;
            this.TxtCodigoDaNotaFiscal.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCodigoDaNotaFiscal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodigoDaNotaFiscal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCodigoDaNotaFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoDaNotaFiscal.ForeColor = System.Drawing.Color.Red;
            this.TxtCodigoDaNotaFiscal.Location = new System.Drawing.Point(3, 15);
            this.TxtCodigoDaNotaFiscal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCodigoDaNotaFiscal.MaxLength = 50;
            this.TxtCodigoDaNotaFiscal.Name = "TxtCodigoDaNotaFiscal";
            this.TxtCodigoDaNotaFiscal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtCodigoDaNotaFiscal.Size = new System.Drawing.Size(120, 26);
            this.TxtCodigoDaNotaFiscal.TabIndex = 0;
            this.TxtCodigoDaNotaFiscal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCodigoDaNotaFiscal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigoDaNotaFiscal_KeyDown);
            this.TxtCodigoDaNotaFiscal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoDaNotaFiscal_KeyPress);
            // 
            // frmCadastrarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 381);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodigoDaNotaFiscal);
            this.Controls.Add(this.TxtValorDesconto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicFoto);
            this.Controls.Add(this.dtpDataDeValidade);
            this.Controls.Add(this.lblPrecoDeVenda);
            this.Controls.Add(this.txtPrecoDeVendaVista);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblPicFoto);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.lblValorCompra);
            this.Controls.Add(this.cbFornecedores);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblPrecoUnitario);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtPrecoUnitario);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblCodigoDeBarras);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblDataDeValidade);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtCodigoDoFornecedor);
            this.Controls.Add(this.txtCodigoDeBarras);
            this.Controls.Add(this.txtID_Produto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar produtos";
            this.Load += new System.EventHandler(this.frmCadastrarProdutos_Load);
            this.Shown += new System.EventHandler(this.frmCadastrarProdutos_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox txtCodigoDoFornecedor;
        internal System.Windows.Forms.Label lblPrecoDeVenda;
        internal System.Windows.Forms.Label lblDesconto;
        internal System.Windows.Forms.Label lblPicFoto;
        internal System.Windows.Forms.Label lblValorCompra;
        internal System.Windows.Forms.Label lblQuantidade;
        internal System.Windows.Forms.Label lblPrecoUnitario;
        internal System.Windows.Forms.TextBox txtProduto;
        internal System.Windows.Forms.Label lblEstoque;
        protected internal System.Windows.Forms.TextBox txtCodigoDeBarras;
        internal System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.Label lblCodigoDeBarras;
        internal System.Windows.Forms.Button btnExcluir;
        internal System.Windows.Forms.Label lblFornecedor;
        internal System.Windows.Forms.Label lblDataDeValidade;
        internal System.Windows.Forms.Label lblProduto;
        internal System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.DateTimePicker dtpDataDeValidade;
        public System.Windows.Forms.TextBox txtPrecoDeVendaVista;
        public System.Windows.Forms.TextBox txtDesconto;
        public System.Windows.Forms.TextBox txtValorCompra;
        public System.Windows.Forms.ComboBox cbFornecedores;
        public System.Windows.Forms.TextBox txtQuantidade;
        public System.Windows.Forms.TextBox txtPrecoUnitario;
        public System.Windows.Forms.TextBox txtEstoque;
        public System.Windows.Forms.PictureBox PicFoto;
        public System.Windows.Forms.TextBox txtID_Produto;
        internal System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtValorDesconto;
        public System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.TextBox TxtCodigoDaNotaFiscal;
    }
}