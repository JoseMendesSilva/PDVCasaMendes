
namespace CasaMendes
{
    partial class FrmEstoqueLista
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbBusca = new System.Windows.Forms.GroupBox();
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.LblEstoqueItens = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvProdutos = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnListaDeCompra = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbBusca.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbBusca);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 65);
            this.panel1.TabIndex = 171;
            // 
            // gbBusca
            // 
            this.gbBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBusca.Controls.Add(this.TxtBusca);
            this.gbBusca.Controls.Add(this.LblEstoqueItens);
            this.gbBusca.Controls.Add(this.label2);
            this.gbBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusca.Location = new System.Drawing.Point(12, 3);
            this.gbBusca.Name = "gbBusca";
            this.gbBusca.Size = new System.Drawing.Size(1074, 58);
            this.gbBusca.TabIndex = 159;
            this.gbBusca.TabStop = false;
            this.gbBusca.Text = "Buscar";
            // 
            // TxtBusca
            // 
            this.TxtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBusca.Location = new System.Drawing.Point(71, 25);
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.Size = new System.Drawing.Size(893, 26);
            this.TxtBusca.TabIndex = 2;
            this.TxtBusca.TextChanged += new System.EventHandler(this.TxtBusca_TextChanged);
            // 
            // LblEstoqueItens
            // 
            this.LblEstoqueItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEstoqueItens.AutoSize = true;
            this.LblEstoqueItens.Location = new System.Drawing.Point(1017, 28);
            this.LblEstoqueItens.Name = "LblEstoqueItens";
            this.LblEstoqueItens.Size = new System.Drawing.Size(51, 20);
            this.LblEstoqueItens.TabIndex = 4;
            this.LblEstoqueItens.Text = "label1";
            this.LblEstoqueItens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produto:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvProdutos);
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 388);
            this.panel2.TabIndex = 172;
            // 
            // DgvProdutos
            // 
            this.DgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdutos.Location = new System.Drawing.Point(12, 6);
            this.DgvProdutos.Name = "DgvProdutos";
            this.DgvProdutos.Size = new System.Drawing.Size(1074, 379);
            this.DgvProdutos.TabIndex = 171;
            this.DgvProdutos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutos_CellEnter);
            this.DgvProdutos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvProdutos_CellFormatting);
            this.DgvProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvProdutos_KeyDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnListaDeCompra);
            this.panel3.Controls.Add(this.BtnExcluir);
            this.panel3.Controls.Add(this.BtnCancelar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 448);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1099, 74);
            this.panel3.TabIndex = 173;
            // 
            // BtnListaDeCompra
            // 
            this.BtnListaDeCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnListaDeCompra.Location = new System.Drawing.Point(190, 12);
            this.BtnListaDeCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnListaDeCompra.Name = "BtnListaDeCompra";
            this.BtnListaDeCompra.Size = new System.Drawing.Size(142, 54);
            this.BtnListaDeCompra.TabIndex = 172;
            this.BtnListaDeCompra.Text = "Lista de compras";
            this.BtnListaDeCompra.UseVisualStyleBackColor = true;
            this.BtnListaDeCompra.Visible = false;
            this.BtnListaDeCompra.Click += new System.EventHandler(this.BtnListaDeCompra_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnExcluir.Location = new System.Drawing.Point(12, 13);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(69, 54);
            this.BtnExcluir.TabIndex = 171;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Location = new System.Drawing.Point(1011, 13);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 53);
            this.BtnCancelar.TabIndex = 170;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmEstoqueLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1099, 522);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FrmEstoqueLista";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.FrmEstoque_Load);
            this.panel1.ResumeLayout(false);
            this.gbBusca.ResumeLayout(false);
            this.gbBusca.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbBusca;
        private System.Windows.Forms.Label LblEstoqueItens;
        private System.Windows.Forms.TextBox TxtBusca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvProdutos;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button BtnListaDeCompra;
        public System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnCancelar;
    }
}