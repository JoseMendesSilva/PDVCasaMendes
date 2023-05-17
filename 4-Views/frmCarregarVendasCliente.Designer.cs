namespace CasaMendes
{
    partial class frmCarregarVendasCliente
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
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.Rbt_Diaria = new System.Windows.Forms.RadioButton();
            this.Rbt_Fixa = new System.Windows.Forms.RadioButton();
            this.gbDadosDaConta = new System.Windows.Forms.GroupBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.lblLiquido = new System.Windows.Forms.Label();
            this.txtParcela = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalReceber = new System.Windows.Forms.TextBox();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.txtTotalGeral = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnReceber = new System.Windows.Forms.Button();
            this.btnGravarParcela = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal_A_Receber = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.lblResumoDaConta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.gbDadosDaConta.SuspendLayout();
            this.gb.SuspendLayout();
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
            this.dgvClientes.Size = new System.Drawing.Size(339, 349);
            this.dgvClientes.TabIndex = 3;
            this.dgvClientes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellEnter);
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Location = new System.Drawing.Point(363, 119);
            this.dgvVendas.MultiSelect = false;
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.RowHeadersVisible = false;
            this.dgvVendas.Size = new System.Drawing.Size(456, 253);
            this.dgvVendas.TabIndex = 5;
            // 
            // Rbt_Diaria
            // 
            this.Rbt_Diaria.AutoSize = true;
            this.Rbt_Diaria.Location = new System.Drawing.Point(17, 47);
            this.Rbt_Diaria.Name = "Rbt_Diaria";
            this.Rbt_Diaria.Size = new System.Drawing.Size(100, 22);
            this.Rbt_Diaria.TabIndex = 6;
            this.Rbt_Diaria.Text = "Taxa Diária";
            this.Rbt_Diaria.UseVisualStyleBackColor = true;
            // 
            // Rbt_Fixa
            // 
            this.Rbt_Fixa.AutoSize = true;
            this.Rbt_Fixa.Checked = true;
            this.Rbt_Fixa.Location = new System.Drawing.Point(17, 19);
            this.Rbt_Fixa.Name = "Rbt_Fixa";
            this.Rbt_Fixa.Size = new System.Drawing.Size(89, 22);
            this.Rbt_Fixa.TabIndex = 5;
            this.Rbt_Fixa.TabStop = true;
            this.Rbt_Fixa.Text = "Taxa Fixa";
            this.Rbt_Fixa.UseVisualStyleBackColor = true;
            this.Rbt_Fixa.CheckedChanged += new System.EventHandler(this.Rbt_Fixa_CheckedChanged);
            // 
            // gbDadosDaConta
            // 
            this.gbDadosDaConta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDadosDaConta.Controls.Add(this.txtTroco);
            this.gbDadosDaConta.Controls.Add(this.lblLiquido);
            this.gbDadosDaConta.Controls.Add(this.txtParcela);
            this.gbDadosDaConta.Controls.Add(this.label1);
            this.gbDadosDaConta.Controls.Add(this.txtTotalReceber);
            this.gbDadosDaConta.Controls.Add(this.txtDinheiro);
            this.gbDadosDaConta.Controls.Add(this.txtTotalGeral);
            this.gbDadosDaConta.Controls.Add(this.Rbt_Fixa);
            this.gbDadosDaConta.Controls.Add(this.Rbt_Diaria);
            this.gbDadosDaConta.Controls.Add(this.label6);
            this.gbDadosDaConta.Controls.Add(this.label3);
            this.gbDadosDaConta.Controls.Add(this.btnFechar);
            this.gbDadosDaConta.Controls.Add(this.btnReceber);
            this.gbDadosDaConta.Controls.Add(this.btnGravarParcela);
            this.gbDadosDaConta.Controls.Add(this.label4);
            this.gbDadosDaConta.Controls.Add(this.lblTotal_A_Receber);
            this.gbDadosDaConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosDaConta.Location = new System.Drawing.Point(12, 367);
            this.gbDadosDaConta.Name = "gbDadosDaConta";
            this.gbDadosDaConta.Size = new System.Drawing.Size(807, 80);
            this.gbDadosDaConta.TabIndex = 7;
            this.gbDadosDaConta.TabStop = false;
            this.gbDadosDaConta.Text = "Dados da conta:";
            // 
            // txtTroco
            // 
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(365, 50);
            this.txtTroco.MaxLength = 10;
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(96, 24);
            this.txtTroco.TabIndex = 11;
            this.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLiquido
            // 
            this.lblLiquido.AutoSize = true;
            this.lblLiquido.Location = new System.Drawing.Point(488, 27);
            this.lblLiquido.Name = "lblLiquido";
            this.lblLiquido.Size = new System.Drawing.Size(0, 18);
            this.lblLiquido.TabIndex = 15;
            this.lblLiquido.Visible = false;
            // 
            // txtParcela
            // 
            this.txtParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParcela.Location = new System.Drawing.Point(365, 50);
            this.txtParcela.MaxLength = 10;
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Size = new System.Drawing.Size(79, 24);
            this.txtParcela.TabIndex = 14;
            this.txtParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtParcela.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Parcela:";
            this.label1.Visible = false;
            // 
            // txtTotalReceber
            // 
            this.txtTotalReceber.Location = new System.Drawing.Point(365, 15);
            this.txtTotalReceber.Name = "txtTotalReceber";
            this.txtTotalReceber.Size = new System.Drawing.Size(96, 24);
            this.txtTotalReceber.TabIndex = 0;
            this.txtTotalReceber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Location = new System.Drawing.Point(199, 15);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(99, 24);
            this.txtDinheiro.TabIndex = 9;
            this.txtDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDinheiro.TextChanged += new System.EventHandler(this.txtDinheiro_TextChanged);
            this.txtDinheiro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDinheiro_KeyDown);
            // 
            // txtTotalGeral
            // 
            this.txtTotalGeral.Location = new System.Drawing.Point(199, 50);
            this.txtTotalGeral.Name = "txtTotalGeral";
            this.txtTotalGeral.Size = new System.Drawing.Size(99, 24);
            this.txtTotalGeral.TabIndex = 2;
            this.txtTotalGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalGeral.TextChanged += new System.EventHandler(this.txtTotalGeral_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Troco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dinheiro:";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(717, 15);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(81, 59);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnReceber
            // 
            this.btnReceber.Location = new System.Drawing.Point(582, 15);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(73, 59);
            this.btnReceber.TabIndex = 7;
            this.btnReceber.Text = "Receber";
            this.btnReceber.UseVisualStyleBackColor = true;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // btnGravarParcela
            // 
            this.btnGravarParcela.Location = new System.Drawing.Point(491, 15);
            this.btnGravarParcela.Name = "btnGravarParcela";
            this.btnGravarParcela.Size = new System.Drawing.Size(71, 59);
            this.btnGravarParcela.TabIndex = 6;
            this.btnGravarParcela.Text = "Parcela";
            this.btnGravarParcela.UseVisualStyleBackColor = true;
            this.btnGravarParcela.Click += new System.EventHandler(this.btnGravarParcela_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total geral:";
            // 
            // lblTotal_A_Receber
            // 
            this.lblTotal_A_Receber.AutoSize = true;
            this.lblTotal_A_Receber.Location = new System.Drawing.Point(311, 18);
            this.lblTotal_A_Receber.Name = "lblTotal_A_Receber";
            this.lblTotal_A_Receber.Size = new System.Drawing.Size(55, 18);
            this.lblTotal_A_Receber.TabIndex = 1;
            this.lblTotal_A_Receber.Text = "Aberto:";
            // 
            // gb
            // 
            this.gb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb.Controls.Add(this.lblResumoDaConta);
            this.gb.Location = new System.Drawing.Point(357, 0);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(462, 113);
            this.gb.TabIndex = 9;
            this.gb.TabStop = false;
            this.gb.Text = "Status:";
            // 
            // lblResumoDaConta
            // 
            this.lblResumoDaConta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResumoDaConta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResumoDaConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumoDaConta.Location = new System.Drawing.Point(6, 16);
            this.lblResumoDaConta.Name = "lblResumoDaConta";
            this.lblResumoDaConta.Size = new System.Drawing.Size(450, 94);
            this.lblResumoDaConta.TabIndex = 0;
            // 
            // frmCarregarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 459);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.dgvVendas);
            this.Controls.Add(this.gbDadosDaConta);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCarregarVenda";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas em aberto";
            this.Load += new System.EventHandler(this.frmCarregarVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.gbDadosDaConta.ResumeLayout(false);
            this.gbDadosDaConta.PerformLayout();
            this.gb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvClientes;
        internal System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.GroupBox gbDadosDaConta;
        private System.Windows.Forms.TextBox txtTotalReceber;
        private System.Windows.Forms.Label lblTotal_A_Receber;
        private System.Windows.Forms.RadioButton Rbt_Diaria;
        private System.Windows.Forms.RadioButton Rbt_Fixa;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label lblResumoDaConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalGeral;
        private System.Windows.Forms.Button btnReceber;
        private System.Windows.Forms.Button btnGravarParcela;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.Label lblLiquido;
        private System.Windows.Forms.TextBox txtParcela;
        private System.Windows.Forms.Label label1;
    }
}