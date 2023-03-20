namespace Cryptography_Project
{
    partial class TextEncryption
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
            this.Vigeneretc = new System.Windows.Forms.TabControl();
            this.tcVigenere = new System.Windows.Forms.TabPage();
            this.VigDonebtn = new System.Windows.Forms.Button();
            this.ViOutputtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VigPanel = new System.Windows.Forms.Panel();
            this.VigEncryptrb = new System.Windows.Forms.RadioButton();
            this.VigDecryptrb = new System.Windows.Forms.RadioButton();
            this.ViInputtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ViKeytxt = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.tcVernam = new System.Windows.Forms.TabPage();
            this.VerDonebtn = new System.Windows.Forms.Button();
            this.VerOutputtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VerPanel = new System.Windows.Forms.Panel();
            this.VerEncryptrb = new System.Windows.Forms.RadioButton();
            this.VerDecryptrb = new System.Windows.Forms.RadioButton();
            this.VerInputtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VerKeytxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tcTransposition = new System.Windows.Forms.TabPage();
            this.TransDonebtn = new System.Windows.Forms.Button();
            this.TransOutputtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TransPanel = new System.Windows.Forms.Panel();
            this.TransEncryptrb = new System.Windows.Forms.RadioButton();
            this.TransDecryptrb = new System.Windows.Forms.RadioButton();
            this.TransInputtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TransKeytxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tcCustom = new System.Windows.Forms.TabPage();
            this.CusDonebtn = new System.Windows.Forms.Button();
            this.CusPanel = new System.Windows.Forms.Panel();
            this.CusEncryptrb = new System.Windows.Forms.RadioButton();
            this.CusDecryptrb = new System.Windows.Forms.RadioButton();
            this.CusInputtxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CusOutputtxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Vigeneretc.SuspendLayout();
            this.tcVigenere.SuspendLayout();
            this.VigPanel.SuspendLayout();
            this.tcVernam.SuspendLayout();
            this.VerPanel.SuspendLayout();
            this.tcTransposition.SuspendLayout();
            this.TransPanel.SuspendLayout();
            this.tcCustom.SuspendLayout();
            this.CusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Vigeneretc
            // 
            this.Vigeneretc.Controls.Add(this.tcVigenere);
            this.Vigeneretc.Controls.Add(this.tcVernam);
            this.Vigeneretc.Controls.Add(this.tcTransposition);
            this.Vigeneretc.Controls.Add(this.tcCustom);
            this.Vigeneretc.Location = new System.Drawing.Point(3, 0);
            this.Vigeneretc.Name = "Vigeneretc";
            this.Vigeneretc.SelectedIndex = 0;
            this.Vigeneretc.Size = new System.Drawing.Size(710, 399);
            this.Vigeneretc.TabIndex = 1;
            // 
            // tcVigenere
            // 
            this.tcVigenere.Controls.Add(this.VigDonebtn);
            this.tcVigenere.Controls.Add(this.ViOutputtxt);
            this.tcVigenere.Controls.Add(this.label2);
            this.tcVigenere.Controls.Add(this.VigPanel);
            this.tcVigenere.Controls.Add(this.ViInputtxt);
            this.tcVigenere.Controls.Add(this.label1);
            this.tcVigenere.Controls.Add(this.ViKeytxt);
            this.tcVigenere.Controls.Add(this.lblKey);
            this.tcVigenere.Location = new System.Drawing.Point(4, 22);
            this.tcVigenere.Name = "tcVigenere";
            this.tcVigenere.Padding = new System.Windows.Forms.Padding(3);
            this.tcVigenere.Size = new System.Drawing.Size(702, 373);
            this.tcVigenere.TabIndex = 0;
            this.tcVigenere.Text = "Vigenère";
            this.tcVigenere.UseVisualStyleBackColor = true;
            // 
            // VigDonebtn
            // 
            this.VigDonebtn.Location = new System.Drawing.Point(250, 172);
            this.VigDonebtn.Name = "VigDonebtn";
            this.VigDonebtn.Size = new System.Drawing.Size(180, 73);
            this.VigDonebtn.TabIndex = 6;
            this.VigDonebtn.Text = "DONE";
            this.VigDonebtn.UseVisualStyleBackColor = true;
            // 
            // ViOutputtxt
            // 
            this.ViOutputtxt.Location = new System.Drawing.Point(91, 95);
            this.ViOutputtxt.Name = "ViOutputtxt";
            this.ViOutputtxt.Size = new System.Drawing.Size(373, 20);
            this.ViOutputtxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cipher Text:";
            // 
            // VigPanel
            // 
            this.VigPanel.Controls.Add(this.VigEncryptrb);
            this.VigPanel.Controls.Add(this.VigDecryptrb);
            this.VigPanel.Location = new System.Drawing.Point(561, 22);
            this.VigPanel.Name = "VigPanel";
            this.VigPanel.Size = new System.Drawing.Size(119, 76);
            this.VigPanel.TabIndex = 8;
            // 
            // VigEncryptrb
            // 
            this.VigEncryptrb.AutoSize = true;
            this.VigEncryptrb.Location = new System.Drawing.Point(12, 16);
            this.VigEncryptrb.Margin = new System.Windows.Forms.Padding(2);
            this.VigEncryptrb.Name = "VigEncryptrb";
            this.VigEncryptrb.Size = new System.Drawing.Size(80, 17);
            this.VigEncryptrb.TabIndex = 4;
            this.VigEncryptrb.Text = "Encrypt File";
            this.VigEncryptrb.UseVisualStyleBackColor = true;
            // 
            // VigDecryptrb
            // 
            this.VigDecryptrb.AutoSize = true;
            this.VigDecryptrb.Location = new System.Drawing.Point(12, 44);
            this.VigDecryptrb.Margin = new System.Windows.Forms.Padding(2);
            this.VigDecryptrb.Name = "VigDecryptrb";
            this.VigDecryptrb.Size = new System.Drawing.Size(81, 17);
            this.VigDecryptrb.TabIndex = 5;
            this.VigDecryptrb.TabStop = true;
            this.VigDecryptrb.Text = "Decrypt File";
            this.VigDecryptrb.UseVisualStyleBackColor = true;
            // 
            // ViInputtxt
            // 
            this.ViInputtxt.Location = new System.Drawing.Point(91, 19);
            this.ViInputtxt.Name = "ViInputtxt";
            this.ViInputtxt.Size = new System.Drawing.Size(373, 20);
            this.ViInputtxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plain Text:";
            // 
            // ViKeytxt
            // 
            this.ViKeytxt.Location = new System.Drawing.Point(91, 55);
            this.ViKeytxt.Margin = new System.Windows.Forms.Padding(2);
            this.ViKeytxt.Name = "ViKeytxt";
            this.ViKeytxt.Size = new System.Drawing.Size(151, 20);
            this.ViKeytxt.TabIndex = 2;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(2, 58);
            this.lblKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(81, 13);
            this.lblKey.TabIndex = 2;
            this.lblKey.Text = "Encryption Key:";
            // 
            // tcVernam
            // 
            this.tcVernam.Controls.Add(this.VerDonebtn);
            this.tcVernam.Controls.Add(this.VerOutputtxt);
            this.tcVernam.Controls.Add(this.label3);
            this.tcVernam.Controls.Add(this.VerPanel);
            this.tcVernam.Controls.Add(this.VerInputtxt);
            this.tcVernam.Controls.Add(this.label4);
            this.tcVernam.Controls.Add(this.VerKeytxt);
            this.tcVernam.Controls.Add(this.label5);
            this.tcVernam.Location = new System.Drawing.Point(4, 22);
            this.tcVernam.Name = "tcVernam";
            this.tcVernam.Padding = new System.Windows.Forms.Padding(3);
            this.tcVernam.Size = new System.Drawing.Size(702, 373);
            this.tcVernam.TabIndex = 1;
            this.tcVernam.Text = "Vernam";
            this.tcVernam.UseVisualStyleBackColor = true;
            // 
            // VerDonebtn
            // 
            this.VerDonebtn.Location = new System.Drawing.Point(250, 172);
            this.VerDonebtn.Name = "VerDonebtn";
            this.VerDonebtn.Size = new System.Drawing.Size(180, 73);
            this.VerDonebtn.TabIndex = 6;
            this.VerDonebtn.Text = "DONE";
            this.VerDonebtn.UseVisualStyleBackColor = true;
            // 
            // VerOutputtxt
            // 
            this.VerOutputtxt.Location = new System.Drawing.Point(91, 95);
            this.VerOutputtxt.Name = "VerOutputtxt";
            this.VerOutputtxt.Size = new System.Drawing.Size(373, 20);
            this.VerOutputtxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cipher Text:";
            // 
            // VerPanel
            // 
            this.VerPanel.Controls.Add(this.VerEncryptrb);
            this.VerPanel.Controls.Add(this.VerDecryptrb);
            this.VerPanel.Location = new System.Drawing.Point(561, 22);
            this.VerPanel.Name = "VerPanel";
            this.VerPanel.Size = new System.Drawing.Size(119, 76);
            this.VerPanel.TabIndex = 16;
            // 
            // VerEncryptrb
            // 
            this.VerEncryptrb.AutoSize = true;
            this.VerEncryptrb.Location = new System.Drawing.Point(12, 16);
            this.VerEncryptrb.Margin = new System.Windows.Forms.Padding(2);
            this.VerEncryptrb.Name = "VerEncryptrb";
            this.VerEncryptrb.Size = new System.Drawing.Size(80, 17);
            this.VerEncryptrb.TabIndex = 4;
            this.VerEncryptrb.Text = "Encrypt File";
            this.VerEncryptrb.UseVisualStyleBackColor = true;
            // 
            // VerDecryptrb
            // 
            this.VerDecryptrb.AutoSize = true;
            this.VerDecryptrb.Location = new System.Drawing.Point(12, 44);
            this.VerDecryptrb.Margin = new System.Windows.Forms.Padding(2);
            this.VerDecryptrb.Name = "VerDecryptrb";
            this.VerDecryptrb.Size = new System.Drawing.Size(81, 17);
            this.VerDecryptrb.TabIndex = 5;
            this.VerDecryptrb.TabStop = true;
            this.VerDecryptrb.Text = "Decrypt File";
            this.VerDecryptrb.UseVisualStyleBackColor = true;
            // 
            // VerInputtxt
            // 
            this.VerInputtxt.Location = new System.Drawing.Point(91, 19);
            this.VerInputtxt.Name = "VerInputtxt";
            this.VerInputtxt.Size = new System.Drawing.Size(373, 20);
            this.VerInputtxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Plain Text:";
            // 
            // VerKeytxt
            // 
            this.VerKeytxt.Location = new System.Drawing.Point(91, 55);
            this.VerKeytxt.Margin = new System.Windows.Forms.Padding(2);
            this.VerKeytxt.Name = "VerKeytxt";
            this.VerKeytxt.Size = new System.Drawing.Size(151, 20);
            this.VerKeytxt.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Encryption Key:";
            // 
            // tcTransposition
            // 
            this.tcTransposition.Controls.Add(this.TransDonebtn);
            this.tcTransposition.Controls.Add(this.TransOutputtxt);
            this.tcTransposition.Controls.Add(this.label6);
            this.tcTransposition.Controls.Add(this.TransPanel);
            this.tcTransposition.Controls.Add(this.TransInputtxt);
            this.tcTransposition.Controls.Add(this.label7);
            this.tcTransposition.Controls.Add(this.TransKeytxt);
            this.tcTransposition.Controls.Add(this.label8);
            this.tcTransposition.Location = new System.Drawing.Point(4, 22);
            this.tcTransposition.Name = "tcTransposition";
            this.tcTransposition.Size = new System.Drawing.Size(702, 373);
            this.tcTransposition.TabIndex = 2;
            this.tcTransposition.Text = "Transposition";
            this.tcTransposition.UseVisualStyleBackColor = true;
            // 
            // TransDonebtn
            // 
            this.TransDonebtn.Location = new System.Drawing.Point(250, 172);
            this.TransDonebtn.Name = "TransDonebtn";
            this.TransDonebtn.Size = new System.Drawing.Size(180, 73);
            this.TransDonebtn.TabIndex = 21;
            this.TransDonebtn.Text = "DONE";
            this.TransDonebtn.UseVisualStyleBackColor = true;
            // 
            // TransOutputtxt
            // 
            this.TransOutputtxt.Location = new System.Drawing.Point(91, 95);
            this.TransOutputtxt.Name = "TransOutputtxt";
            this.TransOutputtxt.Size = new System.Drawing.Size(373, 20);
            this.TransOutputtxt.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Cipher Text:";
            // 
            // TransPanel
            // 
            this.TransPanel.Controls.Add(this.TransEncryptrb);
            this.TransPanel.Controls.Add(this.TransDecryptrb);
            this.TransPanel.Location = new System.Drawing.Point(561, 22);
            this.TransPanel.Name = "TransPanel";
            this.TransPanel.Size = new System.Drawing.Size(119, 76);
            this.TransPanel.TabIndex = 24;
            // 
            // TransEncryptrb
            // 
            this.TransEncryptrb.AutoSize = true;
            this.TransEncryptrb.Location = new System.Drawing.Point(12, 16);
            this.TransEncryptrb.Margin = new System.Windows.Forms.Padding(2);
            this.TransEncryptrb.Name = "TransEncryptrb";
            this.TransEncryptrb.Size = new System.Drawing.Size(80, 17);
            this.TransEncryptrb.TabIndex = 4;
            this.TransEncryptrb.Text = "Encrypt File";
            this.TransEncryptrb.UseVisualStyleBackColor = true;
            // 
            // TransDecryptrb
            // 
            this.TransDecryptrb.AutoSize = true;
            this.TransDecryptrb.Location = new System.Drawing.Point(12, 44);
            this.TransDecryptrb.Margin = new System.Windows.Forms.Padding(2);
            this.TransDecryptrb.Name = "TransDecryptrb";
            this.TransDecryptrb.Size = new System.Drawing.Size(81, 17);
            this.TransDecryptrb.TabIndex = 5;
            this.TransDecryptrb.TabStop = true;
            this.TransDecryptrb.Text = "Decrypt File";
            this.TransDecryptrb.UseVisualStyleBackColor = true;
            // 
            // TransInputtxt
            // 
            this.TransInputtxt.Location = new System.Drawing.Point(91, 19);
            this.TransInputtxt.Name = "TransInputtxt";
            this.TransInputtxt.Size = new System.Drawing.Size(373, 20);
            this.TransInputtxt.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Plain Text:";
            // 
            // TransKeytxt
            // 
            this.TransKeytxt.Location = new System.Drawing.Point(91, 55);
            this.TransKeytxt.Margin = new System.Windows.Forms.Padding(2);
            this.TransKeytxt.Name = "TransKeytxt";
            this.TransKeytxt.Size = new System.Drawing.Size(151, 20);
            this.TransKeytxt.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Encryption Key:";
            // 
            // tcCustom
            // 
            this.tcCustom.Controls.Add(this.CusDonebtn);
            this.tcCustom.Controls.Add(this.CusPanel);
            this.tcCustom.Controls.Add(this.CusInputtxt);
            this.tcCustom.Controls.Add(this.label10);
            this.tcCustom.Controls.Add(this.CusOutputtxt);
            this.tcCustom.Controls.Add(this.label11);
            this.tcCustom.Location = new System.Drawing.Point(4, 22);
            this.tcCustom.Name = "tcCustom";
            this.tcCustom.Size = new System.Drawing.Size(702, 373);
            this.tcCustom.TabIndex = 3;
            this.tcCustom.Text = "Custom";
            this.tcCustom.UseVisualStyleBackColor = true;
            // 
            // CusDonebtn
            // 
            this.CusDonebtn.Location = new System.Drawing.Point(250, 172);
            this.CusDonebtn.Name = "CusDonebtn";
            this.CusDonebtn.Size = new System.Drawing.Size(180, 73);
            this.CusDonebtn.TabIndex = 29;
            this.CusDonebtn.Text = "DONE";
            this.CusDonebtn.UseVisualStyleBackColor = true;
            // 
            // CusPanel
            // 
            this.CusPanel.Controls.Add(this.CusEncryptrb);
            this.CusPanel.Controls.Add(this.CusDecryptrb);
            this.CusPanel.Location = new System.Drawing.Point(561, 22);
            this.CusPanel.Name = "CusPanel";
            this.CusPanel.Size = new System.Drawing.Size(119, 76);
            this.CusPanel.TabIndex = 32;
            // 
            // CusEncryptrb
            // 
            this.CusEncryptrb.AutoSize = true;
            this.CusEncryptrb.Location = new System.Drawing.Point(12, 16);
            this.CusEncryptrb.Margin = new System.Windows.Forms.Padding(2);
            this.CusEncryptrb.Name = "CusEncryptrb";
            this.CusEncryptrb.Size = new System.Drawing.Size(80, 17);
            this.CusEncryptrb.TabIndex = 4;
            this.CusEncryptrb.Text = "Encrypt File";
            this.CusEncryptrb.UseVisualStyleBackColor = true;
            // 
            // CusDecryptrb
            // 
            this.CusDecryptrb.AutoSize = true;
            this.CusDecryptrb.Location = new System.Drawing.Point(12, 44);
            this.CusDecryptrb.Margin = new System.Windows.Forms.Padding(2);
            this.CusDecryptrb.Name = "CusDecryptrb";
            this.CusDecryptrb.Size = new System.Drawing.Size(81, 17);
            this.CusDecryptrb.TabIndex = 5;
            this.CusDecryptrb.TabStop = true;
            this.CusDecryptrb.Text = "Decrypt File";
            this.CusDecryptrb.UseVisualStyleBackColor = true;
            // 
            // CusInputtxt
            // 
            this.CusInputtxt.Location = new System.Drawing.Point(91, 19);
            this.CusInputtxt.Name = "CusInputtxt";
            this.CusInputtxt.Size = new System.Drawing.Size(373, 20);
            this.CusInputtxt.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 22);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Plain Text:";
            // 
            // CusOutputtxt
            // 
            this.CusOutputtxt.Location = new System.Drawing.Point(91, 55);
            this.CusOutputtxt.Margin = new System.Windows.Forms.Padding(2);
            this.CusOutputtxt.Name = "CusOutputtxt";
            this.CusOutputtxt.Size = new System.Drawing.Size(373, 20);
            this.CusOutputtxt.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 58);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Cipher Text:";
            // 
            // TextEncryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 394);
            this.Controls.Add(this.Vigeneretc);
            this.Name = "TextEncryption";
            this.Text = "Text Encryption";
            this.Shown += new System.EventHandler(this.TextEncryption_Shown);
            this.Vigeneretc.ResumeLayout(false);
            this.tcVigenere.ResumeLayout(false);
            this.tcVigenere.PerformLayout();
            this.VigPanel.ResumeLayout(false);
            this.VigPanel.PerformLayout();
            this.tcVernam.ResumeLayout(false);
            this.tcVernam.PerformLayout();
            this.VerPanel.ResumeLayout(false);
            this.VerPanel.PerformLayout();
            this.tcTransposition.ResumeLayout(false);
            this.tcTransposition.PerformLayout();
            this.TransPanel.ResumeLayout(false);
            this.TransPanel.PerformLayout();
            this.tcCustom.ResumeLayout(false);
            this.tcCustom.PerformLayout();
            this.CusPanel.ResumeLayout(false);
            this.CusPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Vigeneretc;
        private System.Windows.Forms.TabPage tcVigenere;
        private System.Windows.Forms.TabPage tcVernam;
        private System.Windows.Forms.TabPage tcTransposition;
        private System.Windows.Forms.TabPage tcCustom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ViKeytxt;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox ViInputtxt;
        private System.Windows.Forms.Panel VigPanel;
        private System.Windows.Forms.RadioButton VigEncryptrb;
        private System.Windows.Forms.RadioButton VigDecryptrb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ViOutputtxt;
        private System.Windows.Forms.Button VigDonebtn;
        private System.Windows.Forms.Button VerDonebtn;
        private System.Windows.Forms.TextBox VerOutputtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel VerPanel;
        private System.Windows.Forms.RadioButton VerEncryptrb;
        private System.Windows.Forms.RadioButton VerDecryptrb;
        private System.Windows.Forms.TextBox VerInputtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox VerKeytxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button TransDonebtn;
        private System.Windows.Forms.TextBox TransOutputtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel TransPanel;
        private System.Windows.Forms.RadioButton TransEncryptrb;
        private System.Windows.Forms.RadioButton TransDecryptrb;
        private System.Windows.Forms.TextBox TransInputtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TransKeytxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CusDonebtn;
        private System.Windows.Forms.Panel CusPanel;
        private System.Windows.Forms.RadioButton CusEncryptrb;
        private System.Windows.Forms.RadioButton CusDecryptrb;
        private System.Windows.Forms.TextBox CusInputtxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CusOutputtxt;
        private System.Windows.Forms.Label label11;
    }
}