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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.attributesDemoControl1 = new CasaMendes.AttributesDemoControl();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(571, 138);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "";
            // 
            // attributesDemoControl1
            // 
            this.attributesDemoControl1.AutoSize = true;
            this.attributesDemoControl1.DataMember = "";
            this.attributesDemoControl1.DataSource = null;
            this.attributesDemoControl1.Location = new System.Drawing.Point(12, 185);
            this.attributesDemoControl1.Name = "attributesDemoControl1";
            this.attributesDemoControl1.Padding = new System.Windows.Forms.Padding(10);
            this.attributesDemoControl1.Size = new System.Drawing.Size(571, 157);
            this.attributesDemoControl1.TabIndex = 3;
            this.attributesDemoControl1.Threshold = null;
            this.attributesDemoControl1.TitleText = "label1";
            // 
            // MyPrinters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 334);
            this.Controls.Add(this.attributesDemoControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "MyPrinters";
            this.Text = "MyPrinters";
            this.Load += new System.EventHandler(this.MyPrinters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox textBox1;
        private AttributesDemoControl attributesDemoControl1;
    }
}