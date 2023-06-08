namespace CasaMendes
{
    partial class FrmCadProduto
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
            this.TxtValorDesconto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PicFoto = new System.Windows.Forms.PictureBox();
            this.DtpDataDeValidade = new System.Windows.Forms.DateTimePicker();
            this.LblPrecoDeVenda = new System.Windows.Forms.Label();
            this.TxtPrecoDeVenda = new System.Windows.Forms.TextBox();
            this.LblDesconto = new System.Windows.Forms.Label();
            this.LblPicFoto = new System.Windows.Forms.Label();
            this.TxtQuantidadeItemDesconto = new System.Windows.Forms.TextBox();
            this.TxtValorCompra = new System.Windows.Forms.TextBox();
            this.LblValorCompra = new System.Windows.Forms.Label();
            this.CbFornecedores = new System.Windows.Forms.ComboBox();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.LblQuantidade = new System.Windows.Forms.Label();
            this.LblPrecoUnitario = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.LblCodigoDeBarras = new System.Windows.Forms.Label();
            this.LblFornecedor = new System.Windows.Forms.Label();
            this.LblDataDeValidade = new System.Windows.Forms.Label();
            this.LblProduto = new System.Windows.Forms.Label();
            this.TxtCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.TxtProdutoId = new System.Windows.Forms.TextBox();
            this.CbSubcategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSubCategoriaId = new System.Windows.Forms.TextBox();
            this.TxtCodigoDoFornecedor = new System.Windows.Forms.TextBox();
            this.BtnGravar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtValorDesconto
            // 
            this.TxtValorDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtValorDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorDesconto.Location = new System.Drawing.Point(250, 343);
            this.TxtValorDesconto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtValorDesconto.Name = "TxtValorDesconto";
            this.TxtValorDesconto.Size = new System.Drawing.Size(71, 26);
            this.TxtValorDesconto.TabIndex = 10;
            this.TxtValorDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 348);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 171;
            this.label1.Text = "V. desconto:";
            // 
            // PicFoto
            // 
            this.PicFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicFoto.Location = new System.Drawing.Point(381, 26);
            this.PicFoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PicFoto.Name = "PicFoto";
            this.PicFoto.Size = new System.Drawing.Size(117, 148);
            this.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicFoto.TabIndex = 159;
            this.PicFoto.TabStop = false;
            this.PicFoto.Click += new System.EventHandler(this.PicFoto_Click);
            // 
            // DtpDataDeValidade
            // 
            this.DtpDataDeValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDataDeValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataDeValidade.Location = new System.Drawing.Point(118, 206);
            this.DtpDataDeValidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpDataDeValidade.Name = "DtpDataDeValidade";
            this.DtpDataDeValidade.Size = new System.Drawing.Size(119, 26);
            this.DtpDataDeValidade.TabIndex = 4;
            // 
            // LblPrecoDeVenda
            // 
            this.LblPrecoDeVenda.AutoSize = true;
            this.LblPrecoDeVenda.Location = new System.Drawing.Point(330, 274);
            this.LblPrecoDeVenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecoDeVenda.Name = "LblPrecoDeVenda";
            this.LblPrecoDeVenda.Size = new System.Drawing.Size(74, 15);
            this.LblPrecoDeVenda.TabIndex = 169;
            this.LblPrecoDeVenda.Text = "Valor venda:";
            // 
            // TxtPrecoDeVenda
            // 
            this.TxtPrecoDeVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrecoDeVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecoDeVenda.Location = new System.Drawing.Point(400, 270);
            this.TxtPrecoDeVenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPrecoDeVenda.Name = "TxtPrecoDeVenda";
            this.TxtPrecoDeVenda.Size = new System.Drawing.Size(97, 26);
            this.TxtPrecoDeVenda.TabIndex = 8;
            this.TxtPrecoDeVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPrecoDeVenda.Leave += new System.EventHandler(this.TxtPrecoDeVenda_Leave);
            // 
            // LblDesconto
            // 
            this.LblDesconto.AutoSize = true;
            this.LblDesconto.Location = new System.Drawing.Point(8, 348);
            this.LblDesconto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDesconto.Name = "LblDesconto";
            this.LblDesconto.Size = new System.Drawing.Size(62, 15);
            this.LblDesconto.TabIndex = 168;
            this.LblDesconto.Text = "Desconto:";
            // 
            // LblPicFoto
            // 
            this.LblPicFoto.AutoSize = true;
            this.LblPicFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPicFoto.Location = new System.Drawing.Point(412, 7);
            this.LblPicFoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPicFoto.Name = "LblPicFoto";
            this.LblPicFoto.Size = new System.Drawing.Size(46, 20);
            this.LblPicFoto.TabIndex = 11;
            this.LblPicFoto.Text = "Foto:";
            // 
            // TxtQuantidadeItemDesconto
            // 
            this.TxtQuantidadeItemDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQuantidadeItemDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuantidadeItemDesconto.Location = new System.Drawing.Point(87, 343);
            this.TxtQuantidadeItemDesconto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtQuantidadeItemDesconto.Name = "TxtQuantidadeItemDesconto";
            this.TxtQuantidadeItemDesconto.Size = new System.Drawing.Size(71, 26);
            this.TxtQuantidadeItemDesconto.TabIndex = 9;
            this.TxtQuantidadeItemDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtValorCompra
            // 
            this.TxtValorCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorCompra.Location = new System.Drawing.Point(86, 269);
            this.TxtValorCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtValorCompra.Name = "TxtValorCompra";
            this.TxtValorCompra.Size = new System.Drawing.Size(71, 26);
            this.TxtValorCompra.TabIndex = 6;
            this.TxtValorCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblValorCompra
            // 
            this.LblValorCompra.AutoSize = true;
            this.LblValorCompra.Location = new System.Drawing.Point(7, 274);
            this.LblValorCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblValorCompra.Name = "LblValorCompra";
            this.LblValorCompra.Size = new System.Drawing.Size(83, 15);
            this.LblValorCompra.TabIndex = 167;
            this.LblValorCompra.Text = "Valor compra:";
            // 
            // CbFornecedores
            // 
            this.CbFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbFornecedores.FormattingEnabled = true;
            this.CbFornecedores.Location = new System.Drawing.Point(118, 98);
            this.CbFornecedores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbFornecedores.Name = "CbFornecedores";
            this.CbFornecedores.Size = new System.Drawing.Size(250, 28);
            this.CbFornecedores.TabIndex = 2;
            this.CbFornecedores.SelectedIndexChanged += new System.EventHandler(this.cbFornecedores_SelectedIndexChanged);
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuantidade.Location = new System.Drawing.Point(319, 209);
            this.TxtQuantidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(179, 26);
            this.TxtQuantidade.TabIndex = 5;
            this.TxtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // LblQuantidade
            // 
            this.LblQuantidade.AutoSize = true;
            this.LblQuantidade.Location = new System.Drawing.Point(247, 214);
            this.LblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblQuantidade.Name = "LblQuantidade";
            this.LblQuantidade.Size = new System.Drawing.Size(74, 15);
            this.LblQuantidade.TabIndex = 164;
            this.LblQuantidade.Text = "Quantidade:";
            // 
            // LblPrecoUnitario
            // 
            this.LblPrecoUnitario.AutoSize = true;
            this.LblPrecoUnitario.Location = new System.Drawing.Point(171, 274);
            this.LblPrecoUnitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecoUnitario.Name = "LblPrecoUnitario";
            this.LblPrecoUnitario.Size = new System.Drawing.Size(82, 15);
            this.LblPrecoUnitario.TabIndex = 161;
            this.LblPrecoUnitario.Text = "Valor unitário:";
            // 
            // TxtNome
            // 
            this.TxtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(118, 52);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(250, 26);
            this.TxtNome.TabIndex = 1;
            // 
            // TxtPrecoUnitario
            // 
            this.TxtPrecoUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrecoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecoUnitario.Location = new System.Drawing.Point(249, 269);
            this.TxtPrecoUnitario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPrecoUnitario.Name = "TxtPrecoUnitario";
            this.TxtPrecoUnitario.ReadOnly = true;
            this.TxtPrecoUnitario.Size = new System.Drawing.Size(71, 26);
            this.TxtPrecoUnitario.TabIndex = 7;
            this.TxtPrecoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPrecoUnitario.TextChanged += new System.EventHandler(this.txtPrecoUnitario_TextChanged);
            // 
            // BtnFechar
            // 
            this.BtnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnFechar.Location = new System.Drawing.Point(427, 327);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(71, 42);
            this.BtnFechar.TabIndex = 13;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            // 
            // LblCodigoDeBarras
            // 
            this.LblCodigoDeBarras.AutoSize = true;
            this.LblCodigoDeBarras.BackColor = System.Drawing.SystemColors.Control;
            this.LblCodigoDeBarras.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblCodigoDeBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoDeBarras.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblCodigoDeBarras.Location = new System.Drawing.Point(6, 11);
            this.LblCodigoDeBarras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCodigoDeBarras.Name = "LblCodigoDeBarras";
            this.LblCodigoDeBarras.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblCodigoDeBarras.Size = new System.Drawing.Size(104, 15);
            this.LblCodigoDeBarras.TabIndex = 157;
            this.LblCodigoDeBarras.Text = "Codigo de barras:";
            // 
            // LblFornecedor
            // 
            this.LblFornecedor.AutoSize = true;
            this.LblFornecedor.Location = new System.Drawing.Point(9, 104);
            this.LblFornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFornecedor.Name = "LblFornecedor";
            this.LblFornecedor.Size = new System.Drawing.Size(73, 15);
            this.LblFornecedor.TabIndex = 163;
            this.LblFornecedor.Text = "Fornecedor:";
            // 
            // LblDataDeValidade
            // 
            this.LblDataDeValidade.AutoSize = true;
            this.LblDataDeValidade.Location = new System.Drawing.Point(9, 209);
            this.LblDataDeValidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDataDeValidade.Name = "LblDataDeValidade";
            this.LblDataDeValidade.Size = new System.Drawing.Size(102, 15);
            this.LblDataDeValidade.TabIndex = 162;
            this.LblDataDeValidade.Text = "Data de validade:";
            // 
            // LblProduto
            // 
            this.LblProduto.AutoSize = true;
            this.LblProduto.Location = new System.Drawing.Point(6, 57);
            this.LblProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProduto.Name = "LblProduto";
            this.LblProduto.Size = new System.Drawing.Size(53, 15);
            this.LblProduto.TabIndex = 160;
            this.LblProduto.Text = "Produto:";
            // 
            // TxtCodigoDeBarras
            // 
            this.TxtCodigoDeBarras.AcceptsReturn = true;
            this.TxtCodigoDeBarras.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCodigoDeBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodigoDeBarras.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCodigoDeBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoDeBarras.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtCodigoDeBarras.Location = new System.Drawing.Point(118, 6);
            this.TxtCodigoDeBarras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCodigoDeBarras.MaxLength = 50;
            this.TxtCodigoDeBarras.Name = "TxtCodigoDeBarras";
            this.TxtCodigoDeBarras.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtCodigoDeBarras.Size = new System.Drawing.Size(150, 26);
            this.TxtCodigoDeBarras.TabIndex = 0;
            this.TxtCodigoDeBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtProdutoId
            // 
            this.TxtProdutoId.Location = new System.Drawing.Point(211, 8);
            this.TxtProdutoId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtProdutoId.Name = "TxtProdutoId";
            this.TxtProdutoId.Size = new System.Drawing.Size(110, 21);
            this.TxtProdutoId.TabIndex = 170;
            this.TxtProdutoId.Visible = false;
            // 
            // CbSubcategoria
            // 
            this.CbSubcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbSubcategoria.FormattingEnabled = true;
            this.CbSubcategoria.Location = new System.Drawing.Point(118, 146);
            this.CbSubcategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbSubcategoria.Name = "CbSubcategoria";
            this.CbSubcategoria.Size = new System.Drawing.Size(250, 28);
            this.CbSubcategoria.TabIndex = 3;
            this.CbSubcategoria.SelectedIndexChanged += new System.EventHandler(this.CbSubcategoria_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 174;
            this.label3.Text = "SubCategoria:";
            // 
            // TxtSubCategoriaId
            // 
            this.TxtSubCategoriaId.Location = new System.Drawing.Point(249, 8);
            this.TxtSubCategoriaId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSubCategoriaId.Name = "TxtSubCategoriaId";
            this.TxtSubCategoriaId.Size = new System.Drawing.Size(110, 21);
            this.TxtSubCategoriaId.TabIndex = 175;
            this.TxtSubCategoriaId.Visible = false;
            // 
            // TxtCodigoDoFornecedor
            // 
            this.TxtCodigoDoFornecedor.Location = new System.Drawing.Point(249, 8);
            this.TxtCodigoDoFornecedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCodigoDoFornecedor.Name = "TxtCodigoDoFornecedor";
            this.TxtCodigoDoFornecedor.Size = new System.Drawing.Size(110, 21);
            this.TxtCodigoDoFornecedor.TabIndex = 158;
            this.TxtCodigoDoFornecedor.Visible = false;
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(350, 327);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(70, 42);
            this.BtnGravar.TabIndex = 176;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // FrmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnFechar;
            this.ClientSize = new System.Drawing.Size(510, 380);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.TxtPrecoUnitario);
            this.Controls.Add(this.TxtPrecoDeVenda);
            this.Controls.Add(this.TxtSubCategoriaId);
            this.Controls.Add(this.CbSubcategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCodigoDoFornecedor);
            this.Controls.Add(this.TxtValorDesconto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicFoto);
            this.Controls.Add(this.DtpDataDeValidade);
            this.Controls.Add(this.LblPrecoDeVenda);
            this.Controls.Add(this.LblDesconto);
            this.Controls.Add(this.LblPicFoto);
            this.Controls.Add(this.TxtQuantidadeItemDesconto);
            this.Controls.Add(this.TxtValorCompra);
            this.Controls.Add(this.LblValorCompra);
            this.Controls.Add(this.CbFornecedores);
            this.Controls.Add(this.TxtQuantidade);
            this.Controls.Add(this.LblQuantidade);
            this.Controls.Add(this.LblPrecoUnitario);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.LblCodigoDeBarras);
            this.Controls.Add(this.LblFornecedor);
            this.Controls.Add(this.LblDataDeValidade);
            this.Controls.Add(this.LblProduto);
            this.Controls.Add(this.TxtCodigoDeBarras);
            this.Controls.Add(this.TxtProdutoId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmCadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadProduto";
            this.Load += new System.EventHandler(this.FrmCadProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox TxtValorDesconto;
        internal System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox PicFoto;
        public System.Windows.Forms.DateTimePicker DtpDataDeValidade;
        internal System.Windows.Forms.Label LblPrecoDeVenda;
        public System.Windows.Forms.TextBox TxtPrecoDeVenda;
        internal System.Windows.Forms.Label LblDesconto;
        internal System.Windows.Forms.Label LblPicFoto;
        public System.Windows.Forms.TextBox TxtQuantidadeItemDesconto;
        public System.Windows.Forms.TextBox TxtValorCompra;
        internal System.Windows.Forms.Label LblValorCompra;
        public System.Windows.Forms.ComboBox CbFornecedores;
        public System.Windows.Forms.TextBox TxtQuantidade;
        internal System.Windows.Forms.Label LblQuantidade;
        internal System.Windows.Forms.Label LblPrecoUnitario;
        internal System.Windows.Forms.TextBox TxtNome;
        public System.Windows.Forms.TextBox TxtPrecoUnitario;
        internal System.Windows.Forms.Button BtnFechar;
        public System.Windows.Forms.Label LblCodigoDeBarras;
        internal System.Windows.Forms.Label LblFornecedor;
        internal System.Windows.Forms.Label LblDataDeValidade;
        internal System.Windows.Forms.Label LblProduto;
        protected internal System.Windows.Forms.TextBox TxtCodigoDeBarras;
        public System.Windows.Forms.TextBox TxtProdutoId;
        public System.Windows.Forms.ComboBox CbSubcategoria;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox TxtSubCategoriaId;
        internal System.Windows.Forms.TextBox TxtCodigoDoFornecedor;
        private System.Windows.Forms.Button BtnGravar;
    }
}