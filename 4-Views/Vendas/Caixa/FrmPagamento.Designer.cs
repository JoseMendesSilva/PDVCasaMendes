namespace CasaMendes
{
    partial class FrmPagamento
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
            this.TxtValorPagamento = new System.Windows.Forms.TextBox();
            this.DgvPagamentos = new System.Windows.Forms.DataGridView();
            this.BtnAdicionarPagamento = new System.Windows.Forms.Button();
            this.BtnFinalizarVenda = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LstFormaPagamento = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDesconto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTroco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblClienteId = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtValorPagamento
            // 
            this.TxtValorPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtValorPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorPagamento.Location = new System.Drawing.Point(29, 343);
            this.TxtValorPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.TxtValorPagamento.Name = "TxtValorPagamento";
            this.TxtValorPagamento.Size = new System.Drawing.Size(167, 32);
            this.TxtValorPagamento.TabIndex = 1;
            this.TxtValorPagamento.TextChanged += new System.EventHandler(this.TxtValorPagamento_TextChanged);
            this.TxtValorPagamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtValorPagamento_KeyDown);
            this.TxtValorPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorPagamento_KeyPress);
            // 
            // DgvPagamentos
            // 
            this.DgvPagamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPagamentos.Location = new System.Drawing.Point(351, 65);
            this.DgvPagamentos.Margin = new System.Windows.Forms.Padding(4);
            this.DgvPagamentos.Name = "DgvPagamentos";
            this.DgvPagamentos.Size = new System.Drawing.Size(418, 242);
            this.DgvPagamentos.TabIndex = 2;
            // 
            // BtnAdicionarPagamento
            // 
            this.BtnAdicionarPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAdicionarPagamento.Location = new System.Drawing.Point(25, 399);
            this.BtnAdicionarPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdicionarPagamento.Name = "BtnAdicionarPagamento";
            this.BtnAdicionarPagamento.Size = new System.Drawing.Size(172, 54);
            this.BtnAdicionarPagamento.TabIndex = 3;
            this.BtnAdicionarPagamento.Text = "Adicionar Pagamento";
            this.BtnAdicionarPagamento.UseVisualStyleBackColor = true;
            this.BtnAdicionarPagamento.Click += new System.EventHandler(this.BtnAdicionarPagamento_Click);
            // 
            // BtnFinalizarVenda
            // 
            this.BtnFinalizarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFinalizarVenda.Location = new System.Drawing.Point(597, 399);
            this.BtnFinalizarVenda.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFinalizarVenda.Name = "BtnFinalizarVenda";
            this.BtnFinalizarVenda.Size = new System.Drawing.Size(172, 54);
            this.BtnFinalizarVenda.TabIndex = 4;
            this.BtnFinalizarVenda.Text = "Finalizar Venda";
            this.BtnFinalizarVenda.UseVisualStyleBackColor = true;
            this.BtnFinalizarVenda.Click += new System.EventHandler(this.BtnFinalizarVenda_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 313);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor";
            // 
            // LstFormaPagamento
            // 
            this.LstFormaPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstFormaPagamento.FormattingEnabled = true;
            this.LstFormaPagamento.ItemHeight = 25;
            this.LstFormaPagamento.Location = new System.Drawing.Point(25, 28);
            this.LstFormaPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.LstFormaPagamento.Name = "LstFormaPagamento";
            this.LstFormaPagamento.Size = new System.Drawing.Size(309, 279);
            this.LstFormaPagamento.TabIndex = 7;
            this.LstFormaPagamento.SelectedIndexChanged += new System.EventHandler(this.LstFormaPagamento_SelectedIndexChanged);
            this.LstFormaPagamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstFormaPagamento_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Desconto";
            // 
            // TxtDesconto
            // 
            this.TxtDesconto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TxtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDesconto.Location = new System.Drawing.Point(310, 343);
            this.TxtDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDesconto.Name = "TxtDesconto";
            this.TxtDesconto.Size = new System.Drawing.Size(167, 32);
            this.TxtDesconto.TabIndex = 8;
            this.TxtDesconto.TextChanged += new System.EventHandler(this.TxtDesconto_TextChanged);
            this.TxtDesconto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDesconto_KeyDown);
            this.TxtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDesconto_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(592, 313);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Troco";
            // 
            // TxtTroco
            // 
            this.TxtTroco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTroco.Location = new System.Drawing.Point(597, 343);
            this.TxtTroco.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTroco.Name = "TxtTroco";
            this.TxtTroco.ReadOnly = true;
            this.TxtTroco.Size = new System.Drawing.Size(172, 32);
            this.TxtTroco.TabIndex = 10;
            this.TxtTroco.TextChanged += new System.EventHandler(this.TxtTroco_TextChanged);
            this.TxtTroco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTroco_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "|Formas de pagamentos";
            // 
            // LblClienteId
            // 
            this.LblClienteId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblClienteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClienteId.Location = new System.Drawing.Point(347, 4);
            this.LblClienteId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblClienteId.Name = "LblClienteId";
            this.LblClienteId.Size = new System.Drawing.Size(130, 20);
            this.LblClienteId.TabIndex = 12;
            this.LblClienteId.Text = "Cliente Id:";
            this.LblClienteId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCliente
            // 
            this.LblCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCliente.Location = new System.Drawing.Point(491, 4);
            this.LblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(278, 20);
            this.LblCliente.TabIndex = 13;
            this.LblCliente.Text = "Cliente";
            this.LblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 468);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.LblClienteId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtTroco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDesconto);
            this.Controls.Add(this.LstFormaPagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFinalizarVenda);
            this.Controls.Add(this.BtnAdicionarPagamento);
            this.Controls.Add(this.DgvPagamentos);
            this.Controls.Add(this.TxtValorPagamento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPagamento";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPagamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtValorPagamento;
        private System.Windows.Forms.DataGridView DgvPagamentos;
        private System.Windows.Forms.Button BtnAdicionarPagamento;
        private System.Windows.Forms.Button BtnFinalizarVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LstFormaPagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDesconto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTroco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblClienteId;
        private System.Windows.Forms.Label LblCliente;
    }
}