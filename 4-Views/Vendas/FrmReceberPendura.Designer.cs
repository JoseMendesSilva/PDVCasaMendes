namespace CasaMendes
{
    partial class FrmReceberPendura
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.DgvVendas = new System.Windows.Forms.DataGridView();
            this.gbDadosDaConta = new System.Windows.Forms.GroupBox();
            this.txtParcela = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalReceber = new System.Windows.Forms.TextBox();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.txtTotalGeral = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnReceber = new System.Windows.Forms.Button();
            this.btnGravarParcela = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal_A_Receber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVendas)).BeginInit();
            this.gbDadosDaConta.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 12);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.Size = new System.Drawing.Size(339, 330);
            this.dgvClientes.TabIndex = 3;
            this.dgvClientes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellEnter);
            // 
            // DgvVendas
            // 
            this.DgvVendas.AllowUserToAddRows = false;
            this.DgvVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVendas.Location = new System.Drawing.Point(363, 12);
            this.DgvVendas.MultiSelect = false;
            this.DgvVendas.Name = "DgvVendas";
            this.DgvVendas.ReadOnly = true;
            this.DgvVendas.RowHeadersVisible = false;
            this.DgvVendas.Size = new System.Drawing.Size(456, 330);
            this.DgvVendas.TabIndex = 5;
            this.DgvVendas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVendas_CellEnter);
            // 
            // gbDadosDaConta
            // 
            this.gbDadosDaConta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDadosDaConta.Controls.Add(this.txtParcela);
            this.gbDadosDaConta.Controls.Add(this.label1);
            this.gbDadosDaConta.Controls.Add(this.txtTotalReceber);
            this.gbDadosDaConta.Controls.Add(this.txtDinheiro);
            this.gbDadosDaConta.Controls.Add(this.txtTotalGeral);
            this.gbDadosDaConta.Controls.Add(this.label3);
            this.gbDadosDaConta.Controls.Add(this.btnFechar);
            this.gbDadosDaConta.Controls.Add(this.btnReceber);
            this.gbDadosDaConta.Controls.Add(this.btnGravarParcela);
            this.gbDadosDaConta.Controls.Add(this.label4);
            this.gbDadosDaConta.Controls.Add(this.lblTotal_A_Receber);
            this.gbDadosDaConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosDaConta.Location = new System.Drawing.Point(12, 369);
            this.gbDadosDaConta.Name = "gbDadosDaConta";
            this.gbDadosDaConta.Size = new System.Drawing.Size(807, 143);
            this.gbDadosDaConta.TabIndex = 7;
            this.gbDadosDaConta.TabStop = false;
            this.gbDadosDaConta.Text = "Dados da conta:";
            // 
            // txtParcela
            // 
            this.txtParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParcela.Location = new System.Drawing.Point(562, 34);
            this.txtParcela.MaxLength = 10;
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Size = new System.Drawing.Size(79, 24);
            this.txtParcela.TabIndex = 14;
            this.txtParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Parcela:";
            // 
            // txtTotalReceber
            // 
            this.txtTotalReceber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalReceber.Location = new System.Drawing.Point(227, 34);
            this.txtTotalReceber.Name = "txtTotalReceber";
            this.txtTotalReceber.Size = new System.Drawing.Size(73, 24);
            this.txtTotalReceber.TabIndex = 0;
            this.txtTotalReceber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDinheiro.Location = new System.Drawing.Point(68, 34);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(80, 24);
            this.txtDinheiro.TabIndex = 9;
            this.txtDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDinheiro.TextChanged += new System.EventHandler(this.TxtDinheiro_TextChanged);
            this.txtDinheiro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDinheiro_KeyDown);
            // 
            // txtTotalGeral
            // 
            this.txtTotalGeral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalGeral.Location = new System.Drawing.Point(409, 34);
            this.txtTotalGeral.Name = "txtTotalGeral";
            this.txtTotalGeral.Size = new System.Drawing.Size(74, 24);
            this.txtTotalGeral.TabIndex = 2;
            this.txtTotalGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dinheiro:";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Location = new System.Drawing.Point(726, 78);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(81, 59);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // btnReceber
            // 
            this.btnReceber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReceber.Location = new System.Drawing.Point(119, 76);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(73, 59);
            this.btnReceber.TabIndex = 7;
            this.btnReceber.Text = "Receber";
            this.btnReceber.UseVisualStyleBackColor = true;
            this.btnReceber.Click += new System.EventHandler(this.BtnReceber_Click);
            // 
            // btnGravarParcela
            // 
            this.btnGravarParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGravarParcela.Location = new System.Drawing.Point(4, 76);
            this.btnGravarParcela.Name = "btnGravarParcela";
            this.btnGravarParcela.Size = new System.Drawing.Size(71, 59);
            this.btnGravarParcela.TabIndex = 6;
            this.btnGravarParcela.Text = "Parcela";
            this.btnGravarParcela.UseVisualStyleBackColor = true;
            this.btnGravarParcela.Click += new System.EventHandler(this.BtnGravarParcela_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total geral:";
            // 
            // lblTotal_A_Receber
            // 
            this.lblTotal_A_Receber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal_A_Receber.AutoSize = true;
            this.lblTotal_A_Receber.Location = new System.Drawing.Point(173, 37);
            this.lblTotal_A_Receber.Name = "lblTotal_A_Receber";
            this.lblTotal_A_Receber.Size = new System.Drawing.Size(55, 18);
            this.lblTotal_A_Receber.TabIndex = 1;
            this.lblTotal_A_Receber.Text = "Aberto:";
            // 
            // FrmReceberPendura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 524);
            this.Controls.Add(this.DgvVendas);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.gbDadosDaConta);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReceberPendura";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas em aberto";
            this.Load += new System.EventHandler(this.frmCarregarVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVendas)).EndInit();
            this.gbDadosDaConta.ResumeLayout(false);
            this.gbDadosDaConta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvClientes;
        internal System.Windows.Forms.DataGridView DgvVendas;
        private System.Windows.Forms.GroupBox gbDadosDaConta;
        private System.Windows.Forms.TextBox txtTotalReceber;
        private System.Windows.Forms.Label lblTotal_A_Receber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalGeral;
        private System.Windows.Forms.Button btnReceber;
        private System.Windows.Forms.Button btnGravarParcela;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.TextBox txtParcela;
        private System.Windows.Forms.Label label1;
    }
}