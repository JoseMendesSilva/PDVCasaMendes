namespace CasaMendes
{
    partial class FrmTabelaDeMargen
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
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnRetornar = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.TxtNumeroDeItensNaLoja = new System.Windows.Forms.TextBox();
            this.TxtSubCategoriaId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.TxtTabelaDeMargenId = new System.Windows.Forms.TextBox();
            this.TxtPorcentagemPessoPorItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDespesa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMargemDeLucro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEncargo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCusto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DgvSubcategorias = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSubcategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscar.Location = new System.Drawing.Point(51, 8);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(634, 20);
            this.TxtBuscar.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Busca:";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExcluir.Location = new System.Drawing.Point(610, 108);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 29);
            this.BtnExcluir.TabIndex = 46;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnRetornar
            // 
            this.BtnRetornar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRetornar.Location = new System.Drawing.Point(610, 160);
            this.BtnRetornar.Name = "BtnRetornar";
            this.BtnRetornar.Size = new System.Drawing.Size(75, 38);
            this.BtnRetornar.TabIndex = 45;
            this.BtnRetornar.Text = "Retornar";
            this.BtnRetornar.UseVisualStyleBackColor = true;
            // 
            // BtnGravar
            // 
            this.BtnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGravar.Location = new System.Drawing.Point(610, 73);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(75, 29);
            this.BtnGravar.TabIndex = 44;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNovo.Location = new System.Drawing.Point(610, 38);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 29);
            this.BtnNovo.TabIndex = 43;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // TxtNumeroDeItensNaLoja
            // 
            this.TxtNumeroDeItensNaLoja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtNumeroDeItensNaLoja.Location = new System.Drawing.Point(332, 73);
            this.TxtNumeroDeItensNaLoja.MaxLength = 40;
            this.TxtNumeroDeItensNaLoja.Name = "TxtNumeroDeItensNaLoja";
            this.TxtNumeroDeItensNaLoja.Size = new System.Drawing.Size(118, 20);
            this.TxtNumeroDeItensNaLoja.TabIndex = 41;
            // 
            // TxtSubCategoriaId
            // 
            this.TxtSubCategoriaId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtSubCategoriaId.Location = new System.Drawing.Point(257, 269);
            this.TxtSubCategoriaId.Name = "TxtSubCategoriaId";
            this.TxtSubCategoriaId.ReadOnly = true;
            this.TxtSubCategoriaId.Size = new System.Drawing.Size(75, 20);
            this.TxtSubCategoriaId.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Subcategoria:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Número de itens na loja:";
            // 
            // Dgv
            // 
            this.Dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(10, 241);
            this.Dgv.Name = "Dgv";
            this.Dgv.Size = new System.Drawing.Size(675, 299);
            this.Dgv.TabIndex = 33;
            // 
            // TxtTabelaDeMargenId
            // 
            this.TxtTabelaDeMargenId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtTabelaDeMargenId.Location = new System.Drawing.Point(217, 282);
            this.TxtTabelaDeMargenId.Name = "TxtTabelaDeMargenId";
            this.TxtTabelaDeMargenId.ReadOnly = true;
            this.TxtTabelaDeMargenId.Size = new System.Drawing.Size(166, 20);
            this.TxtTabelaDeMargenId.TabIndex = 47;
            this.TxtTabelaDeMargenId.Visible = false;
            // 
            // TxtPorcentagemPessoPorItem
            // 
            this.TxtPorcentagemPessoPorItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtPorcentagemPessoPorItem.Location = new System.Drawing.Point(332, 123);
            this.TxtPorcentagemPessoPorItem.MaxLength = 40;
            this.TxtPorcentagemPessoPorItem.Name = "TxtPorcentagemPessoPorItem";
            this.TxtPorcentagemPessoPorItem.Size = new System.Drawing.Size(118, 20);
            this.TxtPorcentagemPessoPorItem.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Porcent de peso:";
            // 
            // TxtDespesa
            // 
            this.TxtDespesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtDespesa.Location = new System.Drawing.Point(332, 170);
            this.TxtDespesa.MaxLength = 40;
            this.TxtDespesa.Name = "TxtDespesa";
            this.TxtDespesa.Size = new System.Drawing.Size(118, 20);
            this.TxtDespesa.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Despesa:";
            // 
            // TxtMargemDeLucro
            // 
            this.TxtMargemDeLucro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtMargemDeLucro.Location = new System.Drawing.Point(476, 170);
            this.TxtMargemDeLucro.MaxLength = 40;
            this.TxtMargemDeLucro.Name = "TxtMargemDeLucro";
            this.TxtMargemDeLucro.Size = new System.Drawing.Size(118, 20);
            this.TxtMargemDeLucro.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Margem de lucro:";
            // 
            // TxtEncargo
            // 
            this.TxtEncargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtEncargo.Location = new System.Drawing.Point(476, 123);
            this.TxtEncargo.MaxLength = 40;
            this.TxtEncargo.Name = "TxtEncargo";
            this.TxtEncargo.Size = new System.Drawing.Size(118, 20);
            this.TxtEncargo.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Encargo:";
            // 
            // TxtCusto
            // 
            this.TxtCusto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtCusto.Location = new System.Drawing.Point(476, 73);
            this.TxtCusto.MaxLength = 40;
            this.TxtCusto.Name = "TxtCusto";
            this.TxtCusto.Size = new System.Drawing.Size(118, 20);
            this.TxtCusto.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Custo:";
            // 
            // DgvSubcategorias
            // 
            this.DgvSubcategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvSubcategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSubcategorias.Location = new System.Drawing.Point(10, 62);
            this.DgvSubcategorias.Name = "DgvSubcategorias";
            this.DgvSubcategorias.Size = new System.Drawing.Size(299, 148);
            this.DgvSubcategorias.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "Gestão:";
            // 
            // FrmTabelaDeMargen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 552);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DgvSubcategorias);
            this.Controls.Add(this.TxtMargemDeLucro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtEncargo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtCusto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtDespesa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPorcentagemPessoPorItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnRetornar);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.TxtNumeroDeItensNaLoja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.TxtTabelaDeMargenId);
            this.Controls.Add(this.TxtSubCategoriaId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTabelaDeMargen";
            this.Text = "FrmTabelaDeMargen";
            this.Load += new System.EventHandler(this.FrmTabelaDeMargen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSubcategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnRetornar;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.TextBox TxtNumeroDeItensNaLoja;
        private System.Windows.Forms.TextBox TxtSubCategoriaId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.TextBox TxtTabelaDeMargenId;
        private System.Windows.Forms.TextBox TxtPorcentagemPessoPorItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDespesa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMargemDeLucro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtEncargo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCusto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DgvSubcategorias;
        private System.Windows.Forms.Label label9;
    }
}