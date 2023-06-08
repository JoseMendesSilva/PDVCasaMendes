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
            this.DgvTabelaDeMargem = new System.Windows.Forms.DataGridView();
            this.TxtTabelaDeMargenId = new System.Windows.Forms.TextBox();
            this.TxtPorcentagemPesoPorItem = new System.Windows.Forms.TextBox();
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
            this.TxtValorDeBase = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtSubCategoria = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabelaDeMargem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSubcategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBuscar.Location = new System.Drawing.Point(12, 25);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtBuscar.MaxLength = 50;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(250, 21);
            this.TxtBuscar.TabIndex = 49;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 48;
            this.label5.Text = "Busca:";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExcluir.Location = new System.Drawing.Point(712, 164);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(88, 33);
            this.BtnExcluir.TabIndex = 9;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnRetornar
            // 
            this.BtnRetornar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRetornar.Location = new System.Drawing.Point(712, 213);
            this.BtnRetornar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnRetornar.Name = "BtnRetornar";
            this.BtnRetornar.Size = new System.Drawing.Size(88, 44);
            this.BtnRetornar.TabIndex = 10;
            this.BtnRetornar.Text = "Retornar";
            this.BtnRetornar.UseVisualStyleBackColor = true;
            this.BtnRetornar.Click += new System.EventHandler(this.BtnRetornar_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGravar.Location = new System.Drawing.Point(712, 115);
            this.BtnGravar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(88, 33);
            this.BtnGravar.TabIndex = 7;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNovo.Location = new System.Drawing.Point(712, 66);
            this.BtnNovo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(88, 33);
            this.BtnNovo.TabIndex = 8;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // TxtNumeroDeItensNaLoja
            // 
            this.TxtNumeroDeItensNaLoja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNumeroDeItensNaLoja.Location = new System.Drawing.Point(387, 78);
            this.TxtNumeroDeItensNaLoja.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNumeroDeItensNaLoja.MaxLength = 40;
            this.TxtNumeroDeItensNaLoja.Name = "TxtNumeroDeItensNaLoja";
            this.TxtNumeroDeItensNaLoja.Size = new System.Drawing.Size(137, 21);
            this.TxtNumeroDeItensNaLoja.TabIndex = 0;
            this.TxtNumeroDeItensNaLoja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNumeroDeItensNaLoja.TextChanged += new System.EventHandler(this.TxtNumeroDeItensNaLoja_TextChanged);
            // 
            // TxtSubCategoriaId
            // 
            this.TxtSubCategoriaId.Location = new System.Drawing.Point(677, 25);
            this.TxtSubCategoriaId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSubCategoriaId.Name = "TxtSubCategoriaId";
            this.TxtSubCategoriaId.ReadOnly = true;
            this.TxtSubCategoriaId.Size = new System.Drawing.Size(119, 21);
            this.TxtSubCategoriaId.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Subcategoria:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Número de itens:";
            // 
            // DgvTabelaDeMargem
            // 
            this.DgvTabelaDeMargem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvTabelaDeMargem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTabelaDeMargem.Location = new System.Drawing.Point(11, 297);
            this.DgvTabelaDeMargem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgvTabelaDeMargem.Name = "DgvTabelaDeMargem";
            this.DgvTabelaDeMargem.Size = new System.Drawing.Size(789, 313);
            this.DgvTabelaDeMargem.TabIndex = 33;
            this.DgvTabelaDeMargem.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTabelaDeMargem_CellEnter);
            // 
            // TxtTabelaDeMargenId
            // 
            this.TxtTabelaDeMargenId.Location = new System.Drawing.Point(270, 25);
            this.TxtTabelaDeMargenId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtTabelaDeMargenId.Name = "TxtTabelaDeMargenId";
            this.TxtTabelaDeMargenId.ReadOnly = true;
            this.TxtTabelaDeMargenId.Size = new System.Drawing.Size(90, 21);
            this.TxtTabelaDeMargenId.TabIndex = 47;
            // 
            // TxtPorcentagemPesoPorItem
            // 
            this.TxtPorcentagemPesoPorItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPorcentagemPesoPorItem.Location = new System.Drawing.Point(552, 78);
            this.TxtPorcentagemPesoPorItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtPorcentagemPesoPorItem.MaxLength = 40;
            this.TxtPorcentagemPesoPorItem.Name = "TxtPorcentagemPesoPorItem";
            this.TxtPorcentagemPesoPorItem.ReadOnly = true;
            this.TxtPorcentagemPesoPorItem.Size = new System.Drawing.Size(137, 21);
            this.TxtPorcentagemPesoPorItem.TabIndex = 3;
            this.TxtPorcentagemPesoPorItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPorcentagemPesoPorItem.TextChanged += new System.EventHandler(this.TxtPorcentagemPesoPorItem_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Porcentagem peso:";
            // 
            // TxtDespesa
            // 
            this.TxtDespesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDespesa.Location = new System.Drawing.Point(552, 130);
            this.TxtDespesa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtDespesa.MaxLength = 40;
            this.TxtDespesa.Name = "TxtDespesa";
            this.TxtDespesa.Size = new System.Drawing.Size(137, 21);
            this.TxtDespesa.TabIndex = 4;
            this.TxtDespesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDespesa.TextChanged += new System.EventHandler(this.TxtDespesa_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "Despesa:";
            // 
            // TxtMargemDeLucro
            // 
            this.TxtMargemDeLucro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMargemDeLucro.Location = new System.Drawing.Point(387, 234);
            this.TxtMargemDeLucro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtMargemDeLucro.MaxLength = 40;
            this.TxtMargemDeLucro.Name = "TxtMargemDeLucro";
            this.TxtMargemDeLucro.Size = new System.Drawing.Size(137, 21);
            this.TxtMargemDeLucro.TabIndex = 6;
            this.TxtMargemDeLucro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtMargemDeLucro.TextChanged += new System.EventHandler(this.TxtMargemDeLucro_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 58;
            this.label6.Text = "Lucro desejado:";
            // 
            // TxtEncargo
            // 
            this.TxtEncargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEncargo.Location = new System.Drawing.Point(552, 182);
            this.TxtEncargo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtEncargo.MaxLength = 40;
            this.TxtEncargo.Name = "TxtEncargo";
            this.TxtEncargo.Size = new System.Drawing.Size(137, 21);
            this.TxtEncargo.TabIndex = 5;
            this.TxtEncargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtEncargo.TextChanged += new System.EventHandler(this.TxtEncargo_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(548, 167);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 56;
            this.label7.Text = "Encargo:";
            // 
            // TxtCusto
            // 
            this.TxtCusto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCusto.Location = new System.Drawing.Point(387, 182);
            this.TxtCusto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCusto.MaxLength = 40;
            this.TxtCusto.Name = "TxtCusto";
            this.TxtCusto.Size = new System.Drawing.Size(137, 21);
            this.TxtCusto.TabIndex = 2;
            this.TxtCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCusto.TextChanged += new System.EventHandler(this.TxtCusto_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 54;
            this.label8.Text = "Custo:";
            // 
            // DgvSubcategorias
            // 
            this.DgvSubcategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSubcategorias.Location = new System.Drawing.Point(12, 78);
            this.DgvSubcategorias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgvSubcategorias.Name = "DgvSubcategorias";
            this.DgvSubcategorias.Size = new System.Drawing.Size(349, 180);
            this.DgvSubcategorias.TabIndex = 60;
            //this.DgvSubcategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSubcategorias_CellContentClick);
            this.DgvSubcategorias.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSubcategorias_CellEnter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 279);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 61;
            this.label9.Text = "Gestão:";
            // 
            // TxtValorDeBase
            // 
            this.TxtValorDeBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtValorDeBase.Location = new System.Drawing.Point(387, 130);
            this.TxtValorDeBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtValorDeBase.MaxLength = 40;
            this.TxtValorDeBase.Name = "TxtValorDeBase";
            this.TxtValorDeBase.Size = new System.Drawing.Size(137, 21);
            this.TxtValorDeBase.TabIndex = 1;
            this.TxtValorDeBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtValorDeBase.TextChanged += new System.EventHandler(this.TxtValorDeBase_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(384, 113);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 62;
            this.label10.Text = "Valor base:";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTotal.Location = new System.Drawing.Point(552, 234);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtTotal.MaxLength = 40;
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(137, 21);
            this.TxtTotal.TabIndex = 63;
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(548, 218);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 64;
            this.label11.Text = "Total:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(384, 10);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 15);
            this.label12.TabIndex = 65;
            this.label12.Text = "SubCategoria:";
            // 
            // TxtSubCategoria
            // 
            this.TxtSubCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSubCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtSubCategoria.Location = new System.Drawing.Point(387, 25);
            this.TxtSubCategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSubCategoria.MaxLength = 50;
            this.TxtSubCategoria.Name = "TxtSubCategoria";
            this.TxtSubCategoria.Size = new System.Drawing.Size(269, 21);
            this.TxtSubCategoria.TabIndex = 66;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(270, 10);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 15);
            this.label13.TabIndex = 67;
            this.label13.Text = "Categoria ID:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(673, 10);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 15);
            this.label14.TabIndex = 68;
            this.label14.Text = "Sub Categoria ID:";
            // 
            // FrmTabelaDeMargen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 620);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtSubCategoria);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtValorDeBase);
            this.Controls.Add(this.label10);
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
            this.Controls.Add(this.TxtPorcentagemPesoPorItem);
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
            this.Controls.Add(this.DgvTabelaDeMargem);
            this.Controls.Add(this.TxtTabelaDeMargenId);
            this.Controls.Add(this.TxtSubCategoriaId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTabelaDeMargen";
            this.Text = "FrmTabelaDeMargen";
            this.Load += new System.EventHandler(this.FrmTabelaDeMargen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabelaDeMargem)).EndInit();
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
        private System.Windows.Forms.DataGridView DgvTabelaDeMargem;
        private System.Windows.Forms.TextBox TxtTabelaDeMargenId;
        private System.Windows.Forms.TextBox TxtPorcentagemPesoPorItem;
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
        private System.Windows.Forms.TextBox TxtValorDeBase;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtSubCategoria;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}