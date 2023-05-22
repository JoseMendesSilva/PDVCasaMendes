
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
            this.label2 = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.RbAVista = new System.Windows.Forms.RadioButton();
            this.RbPendura = new System.Windows.Forms.RadioButton();
            this.DtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtVendas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVendas)).BeginInit();
            this.gbBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFechar.Location = new System.Drawing.Point(12, 544);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 45);
            this.btnFechar.TabIndex = 308;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // DgvVendas
            // 
            this.DgvVendas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVendas.Location = new System.Drawing.Point(12, 57);
            this.DgvVendas.Name = "DgvVendas";
            this.DgvVendas.Size = new System.Drawing.Size(897, 422);
            this.DgvVendas.TabIndex = 307;
            // 
            // gbBusca
            // 
            this.gbBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBusca.Controls.Add(this.LblCliente);
            this.gbBusca.Controls.Add(this.label2);
            this.gbBusca.Controls.Add(this.RbAVista);
            this.gbBusca.Controls.Add(this.RbPendura);
            this.gbBusca.Controls.Add(this.DtpDataCadastro);
            this.gbBusca.Controls.Add(this.label1);
            this.gbBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusca.Location = new System.Drawing.Point(12, -2);
            this.gbBusca.Name = "gbBusca";
            this.gbBusca.Size = new System.Drawing.Size(897, 53);
            this.gbBusca.TabIndex = 312;
            this.gbBusca.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(728, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "VENDAS:";
            // 
            // LblCliente
            // 
            this.LblCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(803, 18);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(88, 20);
            this.LblCliente.TabIndex = 7;
            this.LblCliente.Text = "PENDURA";
            this.LblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RbAVista
            // 
            this.RbAVista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RbAVista.AutoSize = true;
            this.RbAVista.Location = new System.Drawing.Point(314, 16);
            this.RbAVista.Name = "RbAVista";
            this.RbAVista.Size = new System.Drawing.Size(89, 24);
            this.RbAVista.TabIndex = 6;
            this.RbAVista.TabStop = true;
            this.RbAVista.Text = "A VISTA";
            this.RbAVista.UseVisualStyleBackColor = true;
            this.RbAVista.Click += new System.EventHandler(this.RbAVista_Click);
            // 
            // RbPendura
            // 
            this.RbPendura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RbPendura.AutoSize = true;
            this.RbPendura.Location = new System.Drawing.Point(187, 16);
            this.RbPendura.Name = "RbPendura";
            this.RbPendura.Size = new System.Drawing.Size(106, 24);
            this.RbPendura.TabIndex = 5;
            this.RbPendura.TabStop = true;
            this.RbPendura.Text = "PENDURA";
            this.RbPendura.UseVisualStyleBackColor = true;
            this.RbPendura.Click += new System.EventHandler(this.RbPendura_Click);
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
            this.label3.Location = new System.Drawing.Point(695, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 313;
            this.label3.Text = "Vendas:";
            // 
            // TxtVendas
            // 
            this.TxtVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVendas.Location = new System.Drawing.Point(755, 557);
            this.TxtVendas.Name = "TxtVendas";
            this.TxtVendas.Size = new System.Drawing.Size(154, 29);
            this.TxtVendas.TabIndex = 316;
            this.TxtVendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmCarregarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 598);
            this.Controls.Add(this.TxtVendas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbBusca);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.DgvVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCarregarVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas a vista";
            this.Load += new System.EventHandler(this.FrmCarregarVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVendas)).EndInit();
            this.gbBusca.ResumeLayout(false);
            this.gbBusca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView DgvVendas;
        private System.Windows.Forms.GroupBox gbBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtVendas;
        private System.Windows.Forms.DateTimePicker DtpDataCadastro;
        private System.Windows.Forms.RadioButton RbAVista;
        private System.Windows.Forms.RadioButton RbPendura;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.Label label2;
    }
}