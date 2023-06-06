
namespace CasaMendes
{
    partial class FrmEstoque
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
            this.LblEstoqueItens = new System.Windows.Forms.Label();
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnListaDeCompra = new System.Windows.Forms.Button();
            this.DgvProdutos = new System.Windows.Forms.DataGridView();
            this.gbBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBusca
            // 
            this.gbBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBusca.Controls.Add(this.LblEstoqueItens);
            this.gbBusca.Controls.Add(this.TxtBusca);
            this.gbBusca.Controls.Add(this.label2);
            this.gbBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusca.Location = new System.Drawing.Point(12, 7);
            this.gbBusca.Name = "gbBusca";
            this.gbBusca.Size = new System.Drawing.Size(1082, 58);
            this.gbBusca.TabIndex = 158;
            this.gbBusca.TabStop = false;
            this.gbBusca.Text = "Buscar";
            // 
            // LblEstoqueItens
            // 
            this.LblEstoqueItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEstoqueItens.AutoSize = true;
            this.LblEstoqueItens.Location = new System.Drawing.Point(1025, 28);
            this.LblEstoqueItens.Name = "LblEstoqueItens";
            this.LblEstoqueItens.Size = new System.Drawing.Size(51, 20);
            this.LblEstoqueItens.TabIndex = 4;
            this.LblEstoqueItens.Text = "label1";
            this.LblEstoqueItens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtBusca
            // 
            this.TxtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBusca.Location = new System.Drawing.Point(136, 25);
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.Size = new System.Drawing.Size(836, 26);
            this.TxtBusca.TabIndex = 2;
            this.TxtBusca.TextChanged += new System.EventHandler(this.TxtCodigoDeBarras_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código de barras:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Location = new System.Drawing.Point(1019, 461);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 53);
            this.BtnCancelar.TabIndex = 157;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnExcluir.Location = new System.Drawing.Point(12, 461);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(69, 54);
            this.BtnExcluir.TabIndex = 166;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnListaDeCompra
            // 
            this.BtnListaDeCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnListaDeCompra.Location = new System.Drawing.Point(190, 460);
            this.BtnListaDeCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnListaDeCompra.Name = "BtnListaDeCompra";
            this.BtnListaDeCompra.Size = new System.Drawing.Size(69, 54);
            this.BtnListaDeCompra.TabIndex = 169;
            this.BtnListaDeCompra.Text = "Lista de compras";
            this.BtnListaDeCompra.UseVisualStyleBackColor = true;
            this.BtnListaDeCompra.Click += new System.EventHandler(this.BtnListaDeCompra_Click);
            // 
            // DgvProdutos
            // 
            this.DgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdutos.Location = new System.Drawing.Point(12, 71);
            this.DgvProdutos.Name = "DgvProdutos";
            this.DgvProdutos.Size = new System.Drawing.Size(1082, 366);
            this.DgvProdutos.TabIndex = 170;
            // 
            // FrmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1107, 522);
            this.Controls.Add(this.DgvProdutos);
            this.Controls.Add(this.BtnListaDeCompra);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.gbBusca);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FrmEstoque";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.FrmEstoque_Load);
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
        public System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Label LblEstoqueItens;
        public System.Windows.Forms.Button BtnListaDeCompra;
        private System.Windows.Forms.DataGridView DgvProdutos;
    }
}