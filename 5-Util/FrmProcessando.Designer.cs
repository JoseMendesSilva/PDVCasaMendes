namespace CasaMendes
{
    partial class FrmProcessando
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
            this.barra1 = new CasaMendes.Barra();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // barra1
            // 
            this.barra1.Location = new System.Drawing.Point(12, 102);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(695, 11);
            this.barra1.TabIndex = 0;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(12, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(35, 13);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "label1";
            // 
            // LblMensagem
            // 
            this.LblMensagem.Location = new System.Drawing.Point(10, 32);
            this.LblMensagem.Name = "LblMensagem";
            this.LblMensagem.Size = new System.Drawing.Size(696, 70);
            this.LblMensagem.TabIndex = 2;
            this.LblMensagem.Text = "label1";
            this.LblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmProcessando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 125);
            this.ControlBox = false;
            this.Controls.Add(this.LblMensagem);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.barra1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProcessando";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProcessando";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Barra barra1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblMensagem;
    }
}