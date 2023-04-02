namespace Cryptography_Project
{
    partial class TextForm
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
            this.ViOutputtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ViInputtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ViKeytxt = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.VigPanel = new System.Windows.Forms.Panel();
            this.VigEncryptrb = new System.Windows.Forms.RadioButton();
            this.VigDecryptrb = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Textbtn = new System.Windows.Forms.Button();
            this.Bankbtn = new System.Windows.Forms.Button();
            this.VigPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViOutputtxt
            // 
            this.ViOutputtxt.Location = new System.Drawing.Point(111, 115);
            this.ViOutputtxt.Name = "ViOutputtxt";
            this.ViOutputtxt.Size = new System.Drawing.Size(373, 20);
            this.ViOutputtxt.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cipher Text:";
            // 
            // ViInputtxt
            // 
            this.ViInputtxt.Location = new System.Drawing.Point(111, 39);
            this.ViInputtxt.Name = "ViInputtxt";
            this.ViInputtxt.Size = new System.Drawing.Size(373, 20);
            this.ViInputtxt.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Plain Text:";
            // 
            // ViKeytxt
            // 
            this.ViKeytxt.Location = new System.Drawing.Point(111, 75);
            this.ViKeytxt.Margin = new System.Windows.Forms.Padding(2);
            this.ViKeytxt.Name = "ViKeytxt";
            this.ViKeytxt.Size = new System.Drawing.Size(151, 20);
            this.ViKeytxt.TabIndex = 11;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(8, 78);
            this.lblKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(81, 13);
            this.lblKey.TabIndex = 12;
            this.lblKey.Text = "Encryption Key:";
            // 
            // VigPanel
            // 
            this.VigPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VigPanel.Controls.Add(this.VigEncryptrb);
            this.VigPanel.Controls.Add(this.VigDecryptrb);
            this.VigPanel.Location = new System.Drawing.Point(573, 39);
            this.VigPanel.Name = "VigPanel";
            this.VigPanel.Size = new System.Drawing.Size(119, 76);
            this.VigPanel.TabIndex = 16;
            // 
            // VigEncryptrb
            // 
            this.VigEncryptrb.AutoSize = true;
            this.VigEncryptrb.Location = new System.Drawing.Point(12, 16);
            this.VigEncryptrb.Margin = new System.Windows.Forms.Padding(2);
            this.VigEncryptrb.Name = "VigEncryptrb";
            this.VigEncryptrb.Size = new System.Drawing.Size(64, 17);
            this.VigEncryptrb.TabIndex = 4;
            this.VigEncryptrb.Text = "Encrypt ";
            this.VigEncryptrb.UseVisualStyleBackColor = true;
            // 
            // VigDecryptrb
            // 
            this.VigDecryptrb.AutoSize = true;
            this.VigDecryptrb.Location = new System.Drawing.Point(12, 44);
            this.VigDecryptrb.Margin = new System.Windows.Forms.Padding(2);
            this.VigDecryptrb.Name = "VigDecryptrb";
            this.VigDecryptrb.Size = new System.Drawing.Size(65, 17);
            this.VigDecryptrb.TabIndex = 5;
            this.VigDecryptrb.TabStop = true;
            this.VigDecryptrb.Text = "Decrypt ";
            this.VigDecryptrb.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Items.AddRange(new object[] {
            "Transposition",
            "Vigenère",
            "Vernam",
            "Custom"});
            this.comboBox1.Location = new System.Drawing.Point(111, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Encryption Method:";
            // 
            // Textbtn
            // 
            this.Textbtn.Location = new System.Drawing.Point(135, 235);
            this.Textbtn.Name = "Textbtn";
            this.Textbtn.Size = new System.Drawing.Size(188, 60);
            this.Textbtn.TabIndex = 19;
            this.Textbtn.Text = "DONE";
            this.Textbtn.UseVisualStyleBackColor = true;
            // 
            // Bankbtn
            // 
            this.Bankbtn.Location = new System.Drawing.Point(429, 235);
            this.Bankbtn.Name = "Bankbtn";
            this.Bankbtn.Size = new System.Drawing.Size(188, 60);
            this.Bankbtn.TabIndex = 20;
            this.Bankbtn.Text = "BACK";
            this.Bankbtn.UseVisualStyleBackColor = true;
            this.Bankbtn.Click += new System.EventHandler(this.Bankbtn_Click);
            // 
            // TextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 414);
            this.Controls.Add(this.Bankbtn);
            this.Controls.Add(this.Textbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.VigPanel);
            this.Controls.Add(this.ViOutputtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ViInputtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViKeytxt);
            this.Controls.Add(this.lblKey);
            this.Name = "TextForm";
            this.Text = "Text Encryption";
            this.VigPanel.ResumeLayout(false);
            this.VigPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ViOutputtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ViInputtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ViKeytxt;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Panel VigPanel;
        private System.Windows.Forms.RadioButton VigEncryptrb;
        private System.Windows.Forms.RadioButton VigDecryptrb;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Textbtn;
        private System.Windows.Forms.Button Bankbtn;
    }
}