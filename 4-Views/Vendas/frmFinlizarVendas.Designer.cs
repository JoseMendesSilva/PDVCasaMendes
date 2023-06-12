namespace CasaMendes
{
    partial class frmFinlizarVendas
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
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbFormaDePagamento = new System.Windows.Forms.ComboBox();
            this.LblCliente = new System.Windows.Forms.Label();
            this.LblClienteId = new System.Windows.Forms.Label();
            this.TxtDesconto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtJuros = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTributos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTroco
            // 
            this.txtTroco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTroco.BackColor = System.Drawing.Color.White;
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.ForeColor = System.Drawing.Color.Blue;
            this.txtTroco.Location = new System.Drawing.Point(455, 503);
            this.txtTroco.Margin = new System.Windows.Forms.Padding(4);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(328, 62);
            this.txtTroco.TabIndex = 4;
            this.txtTroco.Text = "0,00";
            this.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(450, 474);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "Troco:";
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.BackColor = System.Drawing.Color.White;
            this.txtDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinheiro.ForeColor = System.Drawing.Color.Blue;
            this.txtDinheiro.Location = new System.Drawing.Point(23, 337);
            this.txtDinheiro.Margin = new System.Windows.Forms.Padding(4);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(369, 62);
            this.txtDinheiro.TabIndex = 0;
            this.txtDinheiro.Text = "0,00";
            this.txtDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDinheiro.TextChanged += new System.EventHandler(this.txtDinheiro_TextChanged);
            this.txtDinheiro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDinheiro_KeyDown);
            this.txtDinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinheiro_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(20, 308);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Dinheiro:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Blue;
            this.txtTotal.Location = new System.Drawing.Point(25, 66);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(369, 62);
            this.txtTotal.TabIndex = 3;
            this.txtTotal.Text = "0,00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(13, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Total:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(810, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pagamento.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(0, 596);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(820, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "Precione a tecla (enter) para finalizar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(18, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Venda á:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(452, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Forma de pagamento:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CbFormaDePagamento
            // 
            this.CbFormaDePagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbFormaDePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbFormaDePagamento.ForeColor = System.Drawing.Color.Blue;
            this.CbFormaDePagamento.FormattingEnabled = true;
            this.CbFormaDePagamento.Items.AddRange(new object[] {
            "A VISTA",
            "PIX",
            "DEBITO",
            "CRÉDITO",
            "PENDURA"});
            this.CbFormaDePagamento.Location = new System.Drawing.Point(457, 66);
            this.CbFormaDePagamento.Name = "CbFormaDePagamento";
            this.CbFormaDePagamento.Size = new System.Drawing.Size(328, 63);
            this.CbFormaDePagamento.TabIndex = 2;
            this.CbFormaDePagamento.SelectedIndexChanged += new System.EventHandler(this.CbFormaDePagamento_SelectedIndexChanged);
            this.CbFormaDePagamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CbFormaDePagamento_KeyDown);
            // 
            // LblCliente
            // 
            this.LblCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCliente.ForeColor = System.Drawing.Color.Blue;
            this.LblCliente.Location = new System.Drawing.Point(25, 192);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(369, 55);
            this.LblCliente.TabIndex = 11;
            this.LblCliente.Text = "A VISTA";
            this.LblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblClienteId
            // 
            this.LblClienteId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblClienteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClienteId.Location = new System.Drawing.Point(258, 73);
            this.LblClienteId.Name = "LblClienteId";
            this.LblClienteId.Size = new System.Drawing.Size(136, 55);
            this.LblClienteId.TabIndex = 22;
            this.LblClienteId.Text = "0000";
            this.LblClienteId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblClienteId.Visible = false;
            // 
            // TxtDesconto
            // 
            this.TxtDesconto.BackColor = System.Drawing.Color.White;
            this.TxtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDesconto.ForeColor = System.Drawing.Color.Blue;
            this.TxtDesconto.Location = new System.Drawing.Point(23, 503);
            this.TxtDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDesconto.Name = "TxtDesconto";
            this.TxtDesconto.Size = new System.Drawing.Size(371, 62);
            this.TxtDesconto.TabIndex = 1;
            this.TxtDesconto.Text = "0,00";
            this.TxtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDesconto.TextChanged += new System.EventHandler(this.TxtDesconto_TextChanged);
            this.TxtDesconto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDesconto_KeyDown);
            this.TxtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDesconto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(18, 474);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Desconto:";
            // 
            // TxtJuros
            // 
            this.TxtJuros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtJuros.BackColor = System.Drawing.Color.White;
            this.TxtJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtJuros.ForeColor = System.Drawing.Color.Blue;
            this.TxtJuros.Location = new System.Drawing.Point(457, 337);
            this.TxtJuros.Margin = new System.Windows.Forms.Padding(4);
            this.TxtJuros.Name = "TxtJuros";
            this.TxtJuros.Size = new System.Drawing.Size(326, 62);
            this.TxtJuros.TabIndex = 28;
            this.TxtJuros.Text = "0,00";
            this.TxtJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(450, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Juros:";
            // 
            // TxtTributos
            // 
            this.TxtTributos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTributos.BackColor = System.Drawing.Color.White;
            this.TxtTributos.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTributos.ForeColor = System.Drawing.Color.Blue;
            this.TxtTributos.Location = new System.Drawing.Point(457, 204);
            this.TxtTributos.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTributos.Name = "TxtTributos";
            this.TxtTributos.Size = new System.Drawing.Size(328, 62);
            this.TxtTributos.TabIndex = 27;
            this.TxtTributos.Text = "0,00";
            this.TxtTributos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(452, 175);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 25);
            this.label10.TabIndex = 29;
            this.label10.Text = "Tributos:";
            // 
            // frmFinlizarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 636);
            this.ControlBox = false;
            this.Controls.Add(this.TxtJuros);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtTributos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtDesconto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.CbFormaDePagamento);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.txtDinheiro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblClienteId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFinlizarVendas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmFinlizarVendas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtTroco;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txtDinheiro;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblCliente;
        public System.Windows.Forms.ComboBox CbFormaDePagamento;
        public System.Windows.Forms.Label LblClienteId;
        internal System.Windows.Forms.TextBox TxtDesconto;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox TxtJuros;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox TxtTributos;
        internal System.Windows.Forms.Label label10;
    }
}