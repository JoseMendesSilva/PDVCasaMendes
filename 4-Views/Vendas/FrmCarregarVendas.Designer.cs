
namespace CasaMendes
{
    partial class FrmCarregarVendas
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.DgvVendas = new System.Windows.Forms.DataGridView();
            this.gbBusca = new System.Windows.Forms.GroupBox();
            this.LblCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtVendas = new System.Windows.Forms.TextBox();
            this.CbTipoDeVenda = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVendas)).BeginInit();
            this.gbBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Location = new System.Drawing.Point(750, 504);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 45);
            this.btnFechar.TabIndex = 308;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // DgvVendas
            // 
            this.DgvVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVendas.Location = new System.Drawing.Point(12, 57);
            this.DgvVendas.Name = "DgvVendas";
            this.DgvVendas.Size = new System.Drawing.Size(813, 406);
            this.DgvVendas.TabIndex = 307;
            // 
            // gbBusca
            // 
            this.gbBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBusca.Controls.Add(this.CbTipoDeVenda);
            this.gbBusca.Controls.Add(this.LblCliente);
            this.gbBusca.Controls.Add(this.label2);
            this.gbBusca.Controls.Add(this.DtpDataCadastro);
            this.gbBusca.Controls.Add(this.label1);
            this.gbBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusca.Location = new System.Drawing.Point(12, -2);
            this.gbBusca.Name = "gbBusca";
            this.gbBusca.Size = new System.Drawing.Size(813, 53);
            this.gbBusca.TabIndex = 312;
            this.gbBusca.TabStop = false;
            // 
            // LblCliente
            // 
            this.LblCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCliente.Location = new System.Drawing.Point(659, 18);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(148, 20);
            this.LblCliente.TabIndex = 7;
            this.LblCliente.Text = "PENDURA";
            this.LblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "VENDAS:";
            // 
            // DtpDataCadastro
            // 
            this.DtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataCadastro.Location = new System.Drawing.Point(62, 16);
            this.DtpDataCadastro.Name = "DtpDataCadastro";
            this.DtpDataCadastro.Size = new System.Drawing.Size(119, 26);
            this.DtpDataCadastro.TabIndex = 4;
            this.DtpDataCadastro.ValueChanged += new System.EventHandler(this.DtpDataCadastro_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(611, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 313;
            this.label3.Text = "Vendas:";
            // 
            // TxtVendas
            // 
            this.TxtVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVendas.Location = new System.Drawing.Point(671, 469);
            this.TxtVendas.Name = "TxtVendas";
            this.TxtVendas.Size = new System.Drawing.Size(154, 29);
            this.TxtVendas.TabIndex = 316;
            this.TxtVendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CbTipoDeVenda
            // 
            this.CbTipoDeVenda.FormattingEnabled = true;
            this.CbTipoDeVenda.Items.AddRange(new object[] {
            "A VISTA",
            "DÉBITO",
            "CRÉDITO",
            "PIX",
            "PENDURA",
            "TODOS"});
            this.CbTipoDeVenda.Location = new System.Drawing.Point(187, 15);
            this.CbTipoDeVenda.Name = "CbTipoDeVenda";
            this.CbTipoDeVenda.Size = new System.Drawing.Size(173, 28);
            this.CbTipoDeVenda.TabIndex = 10;
            this.CbTipoDeVenda.SelectedIndexChanged += new System.EventHandler(this.CbTipoDeVenda_SelectedIndexChanged);
            // 
            // FrmCarregarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(839, 560);
            this.Controls.Add(this.TxtVendas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbBusca);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.DgvVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCarregarVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vendas.";
            this.Load += new System.EventHandler(this.FrmCarregarVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVendas)).EndInit();
            this.gbBusca.ResumeLayout(false);
            this.gbBusca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtVendas;
        private System.Windows.Forms.DateTimePicker DtpDataCadastro;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.GroupBox gbBusca;
        public System.Windows.Forms.DataGridView DgvVendas;
        private System.Windows.Forms.ComboBox CbTipoDeVenda;
    }
}