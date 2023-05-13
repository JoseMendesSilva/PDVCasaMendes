namespace CasaMendes.Formularios
{
    partial class FrmPromocao
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.BtnGerarDescontos = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtJuros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDesconto = new System.Windows.Forms.TextBox();
            this.TxtValorDesconto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(662, 398);
            this.dgv.TabIndex = 157;
            this.dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            this.dgv.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellLeave);
            this.dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_KeyDown);
            this.dgv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_KeyPress);
            // 
            // BtnGerarDescontos
            // 
            this.BtnGerarDescontos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnGerarDescontos.Location = new System.Drawing.Point(12, 404);
            this.BtnGerarDescontos.Name = "BtnGerarDescontos";
            this.BtnGerarDescontos.Size = new System.Drawing.Size(93, 66);
            this.BtnGerarDescontos.TabIndex = 158;
            this.BtnGerarDescontos.Text = "Gerar descontos";
            this.BtnGerarDescontos.UseVisualStyleBackColor = true;
            this.BtnGerarDescontos.Click += new System.EventHandler(this.BtnGerarDescontos_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetornar.Location = new System.Drawing.Point(581, 404);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(93, 66);
            this.btnRetornar.TabIndex = 159;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 160;
            this.label1.Text = "J. sobre vendas F. %";
            // 
            // TxtJuros
            // 
            this.TxtJuros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtJuros.Location = new System.Drawing.Point(111, 426);
            this.TxtJuros.Name = "TxtJuros";
            this.TxtJuros.Size = new System.Drawing.Size(153, 44);
            this.TxtJuros.TabIndex = 161;
            this.TxtJuros.Text = "18";
            this.TxtJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 162;
            this.label2.Text = "Desconto:";
            // 
            // TxtDesconto
            // 
            this.TxtDesconto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TxtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDesconto.Location = new System.Drawing.Point(287, 426);
            this.TxtDesconto.Name = "TxtDesconto";
            this.TxtDesconto.Size = new System.Drawing.Size(134, 44);
            this.TxtDesconto.TabIndex = 163;
            this.TxtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtValorDesconto
            // 
            this.TxtValorDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtValorDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorDesconto.Location = new System.Drawing.Point(439, 426);
            this.TxtValorDesconto.Name = "TxtValorDesconto";
            this.TxtValorDesconto.Size = new System.Drawing.Size(136, 44);
            this.TxtValorDesconto.TabIndex = 165;
            this.TxtValorDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtValorDesconto.TextChanged += new System.EventHandler(this.TxtValorDesconto_TextChanged);
            this.TxtValorDesconto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtValorDesconto_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 164;
            this.label3.Text = "V. Desconto:";
            // 
            // FrmPromocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 476);
            this.Controls.Add(this.TxtValorDesconto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDesconto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtJuros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.BtnGerarDescontos);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPromocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPromocao";
            this.Load += new System.EventHandler(this.FrmPromocao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtJuros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDesconto;
        private System.Windows.Forms.TextBox TxtValorDesconto;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button BtnGerarDescontos;
    }
}