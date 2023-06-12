
namespace CasaMendes
{
    partial class FrmAtualizarQuantValorEstoque
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
            this.gbBusca = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.DgvProdutos = new System.Windows.Forms.DataGridView();
            this.ProdutoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoDeBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDeValidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoDeVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategoriaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCarregarDoEstoque = new System.Windows.Forms.Button();
            this.gbBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBusca
            // 
            this.gbBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBusca.Controls.Add(this.label4);
            this.gbBusca.Controls.Add(this.TxtValor);
            this.gbBusca.Controls.Add(this.label3);
            this.gbBusca.Controls.Add(this.TxtQuantidade);
            this.gbBusca.Controls.Add(this.label1);
            this.gbBusca.Controls.Add(this.TxtBusca);
            this.gbBusca.Controls.Add(this.label2);
            this.gbBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusca.Location = new System.Drawing.Point(12, 7);
            this.gbBusca.Name = "gbBusca";
            this.gbBusca.Size = new System.Drawing.Size(668, 89);
            this.gbBusca.TabIndex = 158;
            this.gbBusca.TabStop = false;
            this.gbBusca.Text = "Buscar";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(611, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(326, 51);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(73, 26);
            this.TxtValor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor:";
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.Location = new System.Drawing.Point(166, 51);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(130, 26);
            this.TxtQuantidade.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quantidade:";
            // 
            // TxtBusca
            // 
            this.TxtBusca.Location = new System.Drawing.Point(6, 51);
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.Size = new System.Drawing.Size(130, 26);
            this.TxtBusca.TabIndex = 0;
            this.TxtBusca.TextChanged += new System.EventHandler(this.TxtBusca_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código de barras:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Location = new System.Drawing.Point(605, 447);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 53);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSalvar.Location = new System.Drawing.Point(12, 447);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(69, 54);
            this.BtnSalvar.TabIndex = 0;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // DgvProdutos
            // 
            this.DgvProdutos.AllowUserToAddRows = false;
            this.DgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdutoId,
            this.FornecedorId,
            this.CodigoDeBarras,
            this.Nome,
            this.DataDeValidade,
            this.Quantidade,
            this.ValorCompra,
            this.PrecoUnitario,
            this.PrecoDeVenda,
            this.SubCategoriaId});
            this.DgvProdutos.Location = new System.Drawing.Point(12, 102);
            this.DgvProdutos.Name = "DgvProdutos";
            this.DgvProdutos.Size = new System.Drawing.Size(668, 318);
            this.DgvProdutos.TabIndex = 170;
            // 
            // ProdutoId
            // 
            this.ProdutoId.HeaderText = "ProdutoId";
            this.ProdutoId.Name = "ProdutoId";
            this.ProdutoId.Visible = false;
            // 
            // FornecedorId
            // 
            this.FornecedorId.HeaderText = "FornecedorId";
            this.FornecedorId.Name = "FornecedorId";
            this.FornecedorId.Visible = false;
            // 
            // CodigoDeBarras
            // 
            this.CodigoDeBarras.HeaderText = "CodigoDeBarras";
            this.CodigoDeBarras.Name = "CodigoDeBarras";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // DataDeValidade
            // 
            this.DataDeValidade.HeaderText = "DataDeValidade";
            this.DataDeValidade.Name = "DataDeValidade";
            this.DataDeValidade.Visible = false;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // ValorCompra
            // 
            this.ValorCompra.HeaderText = "ValorCompra";
            this.ValorCompra.Name = "ValorCompra";
            this.ValorCompra.Visible = false;
            // 
            // PrecoUnitario
            // 
            this.PrecoUnitario.HeaderText = "PrecoUnitario";
            this.PrecoUnitario.Name = "PrecoUnitario";
            this.PrecoUnitario.Visible = false;
            // 
            // PrecoDeVenda
            // 
            this.PrecoDeVenda.HeaderText = "PrecoDeVenda";
            this.PrecoDeVenda.Name = "PrecoDeVenda";
            // 
            // SubCategoriaId
            // 
            this.SubCategoriaId.HeaderText = "SubCategoriaId";
            this.SubCategoriaId.Name = "SubCategoriaId";
            this.SubCategoriaId.Visible = false;
            // 
            // BtnCarregarDoEstoque
            // 
            this.BtnCarregarDoEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCarregarDoEstoque.Location = new System.Drawing.Point(100, 447);
            this.BtnCarregarDoEstoque.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCarregarDoEstoque.Name = "BtnCarregarDoEstoque";
            this.BtnCarregarDoEstoque.Size = new System.Drawing.Size(170, 54);
            this.BtnCarregarDoEstoque.TabIndex = 8;
            this.BtnCarregarDoEstoque.Text = "Carregar do Estoque";
            this.BtnCarregarDoEstoque.UseVisualStyleBackColor = true;
            this.BtnCarregarDoEstoque.Visible = false;
            // 
            // FrmAtualizarQuantValorEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(693, 522);
            this.Controls.Add(this.BtnCarregarDoEstoque);
            this.Controls.Add(this.DgvProdutos);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.gbBusca);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FrmAtualizarQuantValorEstoque";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.FrmAtualizarQuantValorEstoque_Load);
            this.gbBusca.ResumeLayout(false);
            this.gbBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBusca;
        private System.Windows.Forms.TextBox TxtBusca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.DataGridView DgvProdutos;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDeBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDeValidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoDeVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategoriaId;
        public System.Windows.Forms.Button BtnCarregarDoEstoque;
        private System.Windows.Forms.Label label4;
    }
}