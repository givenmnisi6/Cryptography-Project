﻿namespace Cryptography_Project
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
            this.components = new System.ComponentModel.Container();
            this.cipherTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.plainTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.encryptionTextbox = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.VigPanel = new System.Windows.Forms.Panel();
            this.encryptionRadiobtn = new System.Windows.Forms.RadioButton();
            this.decryptionRadiobtn = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Textbtn = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.VigPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // cipherTextbox
            // 
            this.cipherTextbox.Location = new System.Drawing.Point(111, 115);
            this.cipherTextbox.Name = "cipherTextbox";
            this.cipherTextbox.Size = new System.Drawing.Size(373, 20);
            this.cipherTextbox.TabIndex = 13;
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
            // plainTextbox
            // 
            this.plainTextbox.Location = new System.Drawing.Point(111, 39);
            this.plainTextbox.Name = "plainTextbox";
            this.plainTextbox.Size = new System.Drawing.Size(373, 20);
            this.plainTextbox.TabIndex = 10;
            this.plainTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.plainTextbox_Validating);
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
            // encryptionTextbox
            // 
            this.encryptionTextbox.Location = new System.Drawing.Point(111, 75);
            this.encryptionTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.encryptionTextbox.Name = "encryptionTextbox";
            this.encryptionTextbox.Size = new System.Drawing.Size(151, 20);
            this.encryptionTextbox.TabIndex = 11;
            this.encryptionTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.encryptionTextbox_Validating);
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
            this.VigPanel.Controls.Add(this.encryptionRadiobtn);
            this.VigPanel.Controls.Add(this.decryptionRadiobtn);
            this.VigPanel.Location = new System.Drawing.Point(573, 39);
            this.VigPanel.Name = "VigPanel";
            this.VigPanel.Size = new System.Drawing.Size(119, 76);
            this.VigPanel.TabIndex = 16;
            // 
            // encryptionRadiobtn
            // 
            this.encryptionRadiobtn.AutoSize = true;
            this.encryptionRadiobtn.Location = new System.Drawing.Point(12, 16);
            this.encryptionRadiobtn.Margin = new System.Windows.Forms.Padding(2);
            this.encryptionRadiobtn.Name = "encryptionRadiobtn";
            this.encryptionRadiobtn.Size = new System.Drawing.Size(64, 17);
            this.encryptionRadiobtn.TabIndex = 4;
            this.encryptionRadiobtn.Text = "Encrypt ";
            this.encryptionRadiobtn.UseVisualStyleBackColor = true;
            // 
            // decryptionRadiobtn
            // 
            this.decryptionRadiobtn.AutoSize = true;
            this.decryptionRadiobtn.Location = new System.Drawing.Point(12, 44);
            this.decryptionRadiobtn.Margin = new System.Windows.Forms.Padding(2);
            this.decryptionRadiobtn.Name = "decryptionRadiobtn";
            this.decryptionRadiobtn.Size = new System.Drawing.Size(65, 17);
            this.decryptionRadiobtn.TabIndex = 5;
            this.decryptionRadiobtn.TabStop = true;
            this.decryptionRadiobtn.Text = "Decrypt ";
            this.decryptionRadiobtn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Items.AddRange(new object[] {
            "Transposition",
            "Vigenere",
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
            this.Textbtn.Click += new System.EventHandler(this.Textbtn_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(429, 235);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(188, 60);
            this.Backbtn.TabIndex = 20;
            this.Backbtn.Text = "BACK";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // TextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 414);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.Textbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.VigPanel);
            this.Controls.Add(this.cipherTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plainTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encryptionTextbox);
            this.Controls.Add(this.lblKey);
            this.Name = "TextForm";
            this.Text = "Text Encryption";
            this.VigPanel.ResumeLayout(false);
            this.VigPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cipherTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox plainTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox encryptionTextbox;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Panel VigPanel;
        private System.Windows.Forms.RadioButton encryptionRadiobtn;
        private System.Windows.Forms.RadioButton decryptionRadiobtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Textbtn;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}