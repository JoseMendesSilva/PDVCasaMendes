namespace CasaMendes
{
    partial class FrmProdutos
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
            this.GbBusca = new System.Windows.Forms.GroupBox();
            this.TxtCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnAbrirListaDeesconto = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.DgvProdutos = new System.Windows.Forms.DataGridView();
            this.GbBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // GbBusca
            // 
            this.GbBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbBusca.Controls.Add(this.TxtCodigoDeBarras);
            this.GbBusca.Controls.Add(this.label2);
            this.GbBusca.Controls.Add(this.label1);
            this.GbBusca.Controls.Add(this.TxtBusca);
            this.GbBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbBusca.Location = new System.Drawing.Point(12, 12);
            this.GbBusca.Name = "GbBusca";
            this.GbBusca.Size = new System.Drawing.Size(1252, 58);
            this.GbBusca.TabIndex = 162;
            this.GbBusca.TabStop = false;
            this.GbBusca.Text = "Buscar:";
            // 
            // TxtCodigoDeBarras
            // 
            this.TxtCodigoDeBarras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCodigoDeBarras.Location = new System.Drawing.Point(1048, 19);
            this.TxtCodigoDeBarras.Name = "TxtCodigoDeBarras";
            this.TxtCodigoDeBarras.Size = new System.Drawing.Size(199, 26);
            this.TxtCodigoDeBarras.TabIndex = 2;
            this.TxtCodigoDeBarras.TextChanged += new System.EventHandler(this.TxtCodigoDeBarras_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(916, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código de barras:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto:";
            // 
            // TxtBusca
            // 
            this.TxtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBusca.Location = new System.Drawing.Point(82, 19);
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.Size = new System.Drawing.Size(828, 26);
            this.TxtBusca.TabIndex = 0;
            this.TxtBusca.TextChanged += new System.EventHandler(this.TxtBusca_TextChanged);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFechar.Location = new System.Drawing.Point(1200, 416);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 57);
            this.BtnFechar.TabIndex = 161;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnAbrirListaDeesconto
            // 
            this.BtnAbrirListaDeesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAbrirListaDeesconto.Location = new System.Drawing.Point(301, 416);
            this.BtnAbrirListaDeesconto.Name = "BtnAbrirListaDeesconto";
            this.BtnAbrirListaDeesconto.Size = new System.Drawing.Size(69, 54);
            this.BtnAbrirListaDeesconto.TabIndex = 166;
            this.BtnAbrirListaDeesconto.Text = "Abrir lista de desconto";
            this.BtnAbrirListaDeesconto.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnExcluir.Location = new System.Drawing.Point(202, 416);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(69, 54);
            this.BtnExcluir.TabIndex = 165;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEditar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnEditar.Location = new System.Drawing.Point(108, 416);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(69, 54);
            this.BtnEditar.TabIndex = 164;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNovo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnNovo.Location = new System.Drawing.Point(12, 416);
            this.BtnNovo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(69, 54);
            this.BtnNovo.TabIndex = 163;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // DgvProdutos
            // 
            this.DgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdutos.Location = new System.Drawing.Point(12, 76);
            this.DgvProdutos.Name = "DgvProdutos";
            this.DgvProdutos.Size = new System.Drawing.Size(1263, 320);
            this.DgvProdutos.TabIndex = 170;
            this.DgvProdutos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellEnter);
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 481);
            this.Controls.Add(this.DgvProdutos);
            this.Controls.Add(this.GbBusca);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnAbrirListaDeesconto);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNovo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProdutos";
            this.Text = "FormProdutos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            this.GbBusca.ResumeLayout(false);
            this.GbBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbBusca;
        private System.Windows.Forms.TextBox TxtCodigoDeBarras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBusca;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnAbrirListaDeesconto;
        public System.Windows.Forms.Button BtnExcluir;
        public System.Windows.Forms.Button BtnEditar;
        public System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.DataGridView DgvProdutos;
    }
}