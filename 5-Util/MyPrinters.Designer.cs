namespace CasaMendes
{
    partial class MyPrinters
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
            this.CbPrinters = new System.Windows.Forms.ComboBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.RTBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRetornar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CbPrinters
            // 
            this.CbPrinters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbPrinters.FormattingEnabled = true;
            this.CbPrinters.Location = new System.Drawing.Point(12, 25);
            this.CbPrinters.Name = "CbPrinters";
            this.CbPrinters.Size = new System.Drawing.Size(201, 21);
            this.CbPrinters.TabIndex = 0;
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnOk.Location = new System.Drawing.Point(12, 58);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 40);
            this.BtnOk.TabIndex = 1;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // RTBox1
            // 
            this.RTBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBox1.Location = new System.Drawing.Point(12, 52);
            this.RTBox1.Name = "RTBox1";
            this.RTBox1.Size = new System.Drawing.Size(201, 0);
            this.RTBox1.TabIndex = 2;
            this.RTBox1.Text = "";
            this.RTBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Impressoras do sistema:";
            // 
            // BtnRetornar
            // 
            this.BtnRetornar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRetornar.Location = new System.Drawing.Point(138, 58);
            this.BtnRetornar.Name = "BtnRetornar";
            this.BtnRetornar.Size = new System.Drawing.Size(75, 40);
            this.BtnRetornar.TabIndex = 4;
            this.BtnRetornar.Text = "Retornar";
            this.BtnRetornar.UseVisualStyleBackColor = true;
            // 
            // MyPrinters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 110);
            this.Controls.Add(this.BtnRetornar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RTBox1);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.CbPrinters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyPrinters";
            this.Text = "MyPrinters";
            this.Load += new System.EventHandler(this.MyPrinters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbPrinters;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.RichTextBox RTBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRetornar;
    }
}