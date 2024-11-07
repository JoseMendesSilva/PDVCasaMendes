
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
            this.PreviousPage = new System.Windows.Forms.Button();
            this.NextPage = new System.Windows.Forms.Button();
            this.CbTipoDeVenda = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DtpDataCadastroFim = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpDataCadastroInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtVendas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVendas)).BeginInit();
            this.gbBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Location = new System.Drawing.Point(1182, 504);
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
            this.DgvVendas.Size = new System.Drawing.Size(1245, 406);
            this.DgvVendas.TabIndex = 307;
            // 
            // gbBusca
            // 
            this.gbBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBusca.Controls.Add(this.PreviousPage);
            this.gbBusca.Controls.Add(this.NextPage);
            this.gbBusca.Controls.Add(this.CbTipoDeVenda);
            this.gbBusca.Controls.Add(this.label6);
            this.gbBusca.Controls.Add(this.DtpDataCadastroFim);
            this.gbBusca.Controls.Add(this.label5);
            this.gbBusca.Controls.Add(this.label4);
            this.gbBusca.Controls.Add(this.DtpDataCadastroInicio);
            this.gbBusca.Controls.Add(this.label1);
            this.gbBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusca.Location = new System.Drawing.Point(12, -2);
            this.gbBusca.Name = "gbBusca";
            this.gbBusca.Size = new System.Drawing.Size(1245, 53);
            this.gbBusca.TabIndex = 312;
            this.gbBusca.TabStop = false;
            // 
            // PreviousPage
            // 
            this.PreviousPage.Location = new System.Drawing.Point(693, 13);
            this.PreviousPage.Name = "PreviousPage";
            this.PreviousPage.Size = new System.Drawing.Size(75, 28);
            this.PreviousPage.TabIndex = 317;
            this.PreviousPage.Text = "PreviousPage";
            this.PreviousPage.UseVisualStyleBackColor = true;
            this.PreviousPage.Click += new System.EventHandler(this.PreviousPage_Click);
            // 
            // NextPage
            // 
            this.NextPage.Location = new System.Drawing.Point(799, 13);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(75, 28);
            this.NextPage.TabIndex = 318;
            this.NextPage.Text = "NextPage";
            this.NextPage.UseVisualStyleBackColor = true;
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // CbTipoDeVenda
            // 
            this.CbTipoDeVenda.FormattingEnabled = true;
            this.CbTipoDeVenda.Items.AddRange(new object[] {
            "",
            "DINHEIRO",
            "A VISTA",
            "DÉBITO",
            "CRÉDITO",
            "PIX",
            "PENDURA",
            "TODOS"});
            this.CbTipoDeVenda.Location = new System.Drawing.Point(517, 13);
            this.CbTipoDeVenda.Name = "CbTipoDeVenda";
            this.CbTipoDeVenda.Size = new System.Drawing.Size(132, 28);
            this.CbTipoDeVenda.TabIndex = 10;
            this.CbTipoDeVenda.SelectedIndexChanged += new System.EventHandler(this.CbTipoDeVenda_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Vendas:";
            // 
            // DtpDataCadastroFim
            // 
            this.DtpDataCadastroFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataCadastroFim.Location = new System.Drawing.Point(313, 14);
            this.DtpDataCadastroFim.Name = "DtpDataCadastroFim";
            this.DtpDataCadastroFim.Size = new System.Drawing.Size(119, 26);
            this.DtpDataCadastroFim.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "<==>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Até:";
            // 
            // DtpDataCadastroInicio
            // 
            this.DtpDataCadastroInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataCadastroInicio.Location = new System.Drawing.Point(93, 14);
            this.DtpDataCadastroInicio.Name = "DtpDataCadastroInicio";
            this.DtpDataCadastroInicio.Size = new System.Drawing.Size(119, 26);
            this.DtpDataCadastroInicio.TabIndex = 4;
            this.DtpDataCadastroInicio.ValueChanged += new System.EventHandler(this.DtpDataCadastroInicio_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Inicio:";
            // 
            // LblCliente
            // 
            this.LblCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCliente.ForeColor = System.Drawing.Color.Red;
            this.LblCliente.Location = new System.Drawing.Point(12, 469);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(1142, 82);
            this.LblCliente.TabIndex = 7;
            this.LblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(1037, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 313;
            this.label3.Text = "TOTAL:";
            this.label3.Visible = false;
            // 
            // TxtVendas
            // 
            this.TxtVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVendas.Location = new System.Drawing.Point(1103, 469);
            this.TxtVendas.Name = "TxtVendas";
            this.TxtVendas.Size = new System.Drawing.Size(154, 29);
            this.TxtVendas.TabIndex = 316;
            this.TxtVendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtVendas.Visible = false;
            // 
            // FrmCarregarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1271, 560);
            this.Controls.Add(this.TxtVendas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbBusca);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.DgvVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCarregarVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vendas.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCarregarVendas_Load);
            this.Shown += new System.EventHandler(this.FrmCarregarVendas_Shown);
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
        private System.Windows.Forms.DateTimePicker DtpDataCadastroInicio;
        private System.Windows.Forms.Label LblCliente;
        public System.Windows.Forms.GroupBox gbBusca;
        public System.Windows.Forms.DataGridView DgvVendas;
        private System.Windows.Forms.ComboBox CbTipoDeVenda;
        private System.Windows.Forms.DateTimePicker DtpDataCadastroFim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button NextPage;
        private System.Windows.Forms.Button PreviousPage;
    }
}