namespace CasaMendes
{
    partial class Form1
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
            this.BtnLer = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLer
            // 
            this.BtnLer.Location = new System.Drawing.Point(12, 228);
            this.BtnLer.Name = "BtnLer";
            this.BtnLer.Size = new System.Drawing.Size(75, 23);
            this.BtnLer.TabIndex = 0;
            this.BtnLer.Text = "Ler";
            this.BtnLer.UseVisualStyleBackColor = true;
            this.BtnLer.Click += new System.EventHandler(this.BtnLer_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(293, 228);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 1;
            this.BtnSair.Text = "Fechar";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(110, 228);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(75, 23);
            this.BtnGravar.TabIndex = 2;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 263);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLer;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnGravar;
    }
}