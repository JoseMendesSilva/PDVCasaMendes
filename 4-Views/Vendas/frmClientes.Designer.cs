namespace CasaMendes
{
    partial class FrmClientes
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
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.painelRedondo1 = new CasaMendes.PainelRedondo();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.BtnNovo = new CasaMendes.Botao2();
            this.BtnEditar = new CasaMendes.Botao2();
            this.BtnExcluir = new CasaMendes.Botao2();
            this.BtnFechar = new CasaMendes.Botao2();
            this.GbBusca.SuspendLayout();
            this.painelRedondo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // GbBusca
            // 
            this.GbBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbBusca.Controls.Add(this.TxtBusca);
            this.GbBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbBusca.Location = new System.Drawing.Point(12, 3);
            this.GbBusca.Name = "GbBusca";
            this.GbBusca.Size = new System.Drawing.Size(815, 71);
            this.GbBusca.TabIndex = 163;
            this.GbBusca.TabStop = false;
            this.GbBusca.Text = "Busca:";
            // 
            // TxtBusca
            // 
            this.TxtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBusca.Location = new System.Drawing.Point(0, 25);
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.Size = new System.Drawing.Size(815, 26);
            this.TxtBusca.TabIndex = 0;
            this.TxtBusca.TextChanged += new System.EventHandler(this.TxtBusca_TextChanged);
            // 
            // painelRedondo1
            // 
            this.painelRedondo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelRedondo1.Controls.Add(this.DgvClientes);
            this.painelRedondo1.Location = new System.Drawing.Point(12, 60);
            this.painelRedondo1.Name = "painelRedondo1";
            this.painelRedondo1.Size = new System.Drawing.Size(815, 397);
            this.painelRedondo1.TabIndex = 1;
            // 
            // DgvClientes
            // 
            this.DgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(3, 3);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.Size = new System.Drawing.Size(809, 391);
            this.DgvClientes.TabIndex = 157;
            this.DgvClientes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellEnter);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNovo.Location = new System.Drawing.Point(12, 463);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(70, 53);
            this.BtnNovo.TabIndex = 165;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEditar.Location = new System.Drawing.Point(101, 463);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(70, 53);
            this.BtnEditar.TabIndex = 166;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnExcluir.Location = new System.Drawing.Point(194, 463);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(70, 53);
            this.BtnExcluir.TabIndex = 167;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFechar.Location = new System.Drawing.Point(757, 463);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(70, 53);
            this.BtnFechar.TabIndex = 168;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(839, 528);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.painelRedondo1);
            this.Controls.Add(this.GbBusca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.GbBusca.ResumeLayout(false);
            this.GbBusca.PerformLayout();
            this.painelRedondo1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GbBusca;
        private System.Windows.Forms.TextBox TxtBusca;
        private PainelRedondo painelRedondo1;
        private System.Windows.Forms.DataGridView DgvClientes;
        private Botao2 BtnNovo;
        private Botao2 BtnEditar;
        private Botao2 BtnExcluir;
        private Botao2 BtnFechar;
    }
}