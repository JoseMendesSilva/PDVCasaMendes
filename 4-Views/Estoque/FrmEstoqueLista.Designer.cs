
namespace CasaMendes
{
    partial class FrmEstoqueLista
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbBusca = new System.Windows.Forms.GroupBox();
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.LblEstoqueItens = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvProdutos = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceitar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbBusca.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbBusca);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 65);
            this.panel1.TabIndex = 171;
            // 
            // gbBusca
            // 
            this.gbBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBusca.Controls.Add(this.TxtBusca);
            this.gbBusca.Controls.Add(this.LblEstoqueItens);
            this.gbBusca.Controls.Add(this.label2);
            this.gbBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusca.Location = new System.Drawing.Point(12, 3);
            this.gbBusca.Name = "gbBusca";
            this.gbBusca.Size = new System.Drawing.Size(704, 58);
            this.gbBusca.TabIndex = 159;
            this.gbBusca.TabStop = false;
            this.gbBusca.Text = "Buscar";
            // 
            // TxtBusca
            // 
            this.TxtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBusca.Location = new System.Drawing.Point(71, 25);
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.Size = new System.Drawing.Size(250, 26);
            this.TxtBusca.TabIndex = 2;
            this.TxtBusca.TextChanged += new System.EventHandler(this.TxtBusca_TextChanged);
            this.TxtBusca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBusca_KeyDown);
            // 
            // LblEstoqueItens
            // 
            this.LblEstoqueItens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEstoqueItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstoqueItens.Location = new System.Drawing.Point(349, 22);
            this.LblEstoqueItens.Name = "LblEstoqueItens";
            this.LblEstoqueItens.Size = new System.Drawing.Size(349, 33);
            this.LblEstoqueItens.TabIndex = 4;
            this.LblEstoqueItens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produto:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.DgvProdutos);
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 493);
            this.panel2.TabIndex = 172;
            // 
            // DgvProdutos
            // 
            this.DgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdutos.Location = new System.Drawing.Point(12, 6);
            this.DgvProdutos.Name = "DgvProdutos";
            this.DgvProdutos.Size = new System.Drawing.Size(704, 484);
            this.DgvProdutos.TabIndex = 171;
            this.DgvProdutos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutos_CellEnter);
            this.DgvProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvProdutos_KeyDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnAceitar);
            this.panel3.Controls.Add(this.BtnCancelar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 552);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(729, 74);
            this.panel3.TabIndex = 173;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Location = new System.Drawing.Point(641, 13);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 53);
            this.BtnCancelar.TabIndex = 170;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceitar
            // 
            this.BtnAceitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAceitar.Location = new System.Drawing.Point(12, 13);
            this.BtnAceitar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAceitar.Name = "BtnAceitar";
            this.BtnAceitar.Size = new System.Drawing.Size(69, 54);
            this.BtnAceitar.TabIndex = 171;
            this.BtnAceitar.Text = "Aceitar";
            this.BtnAceitar.UseVisualStyleBackColor = true;
            this.BtnAceitar.Click += new System.EventHandler(this.BtnAceitar_Click);
            // 
            // FrmEstoqueLista
            // 
            this.AcceptButton = this.BtnAceitar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(729, 626);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FrmEstoqueLista";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.FrmEstoque_Load);
            this.panel1.ResumeLayout(false);
            this.gbBusca.ResumeLayout(false);
            this.gbBusca.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbBusca;
        private System.Windows.Forms.Label LblEstoqueItens;
        private System.Windows.Forms.TextBox TxtBusca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvProdutos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.Button BtnAceitar;
    }
}