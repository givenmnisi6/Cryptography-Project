namespace Cryptography_Project
{
    partial class CustomForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.decryptionRadiobtn = new System.Windows.Forms.RadioButton();
            this.encryptionRadiobtn = new System.Windows.Forms.RadioButton();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.Textbtn = new System.Windows.Forms.Button();
            this.cipherTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.plainTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.decryptionRadiobtn);
            this.groupBox1.Controls.Add(this.encryptionRadiobtn);
            this.groupBox1.Location = new System.Drawing.Point(589, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 75);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cryptography Method";
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
            // encryptionRadiobtn
            // 
            this.encryptionRadiobtn.AutoSize = true;
            this.encryptionRadiobtn.Location = new System.Drawing.Point(12, 22);
            this.encryptionRadiobtn.Margin = new System.Windows.Forms.Padding(2);
            this.encryptionRadiobtn.Name = "encryptionRadiobtn";
            this.encryptionRadiobtn.Size = new System.Drawing.Size(64, 17);
            this.encryptionRadiobtn.TabIndex = 4;
            this.encryptionRadiobtn.Text = "Encrypt ";
            this.encryptionRadiobtn.UseVisualStyleBackColor = true;
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(410, 236);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(188, 60);
            this.Clearbtn.TabIndex = 34;
            this.Clearbtn.Text = "CLEAR";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(277, 314);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(188, 60);
            this.Backbtn.TabIndex = 33;
            this.Backbtn.Text = "BACK";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // Textbtn
            // 
            this.Textbtn.Location = new System.Drawing.Point(151, 236);
            this.Textbtn.Name = "Textbtn";
            this.Textbtn.Size = new System.Drawing.Size(188, 60);
            this.Textbtn.TabIndex = 32;
            this.Textbtn.Text = "SUBMIT";
            this.Textbtn.UseVisualStyleBackColor = true;
            this.Textbtn.Click += new System.EventHandler(this.Textbtn_Click);
            // 
            // cipherTextbox
            // 
            this.cipherTextbox.Location = new System.Drawing.Point(127, 84);
            this.cipherTextbox.Name = "cipherTextbox";
            this.cipherTextbox.ReadOnly = true;
            this.cipherTextbox.Size = new System.Drawing.Size(373, 20);
            this.cipherTextbox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Cipher Text:";
            // 
            // plainTextbox
            // 
            this.plainTextbox.Location = new System.Drawing.Point(127, 40);
            this.plainTextbox.Name = "plainTextbox";
            this.plainTextbox.Size = new System.Drawing.Size(373, 20);
            this.plainTextbox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Plain Text:";
            // 
            // CustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 414);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.Textbtn);
            this.Controls.Add(this.cipherTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plainTextbox);
            this.Controls.Add(this.label1);
            this.Name = "CustomForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "B&G Text ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton decryptionRadiobtn;
        private System.Windows.Forms.RadioButton encryptionRadiobtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button Textbtn;
        private System.Windows.Forms.TextBox cipherTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox plainTextbox;
        private System.Windows.Forms.Label label1;
    }
}