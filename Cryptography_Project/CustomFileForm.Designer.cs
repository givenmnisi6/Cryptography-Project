namespace Cryptography_Project
{
    partial class CustomFileForm
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
            this.decryptRadiobtn = new System.Windows.Forms.RadioButton();
            this.encryptRadiobtn = new System.Windows.Forms.RadioButton();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.Textbtn = new System.Windows.Forms.Button();
            this.plainTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Openbtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblKey = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.decryptRadiobtn);
            this.groupBox1.Controls.Add(this.encryptRadiobtn);
            this.groupBox1.Location = new System.Drawing.Point(629, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 75);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cryptography Method";
            // 
            // decryptRadiobtn
            // 
            this.decryptRadiobtn.AutoSize = true;
            this.decryptRadiobtn.Location = new System.Drawing.Point(12, 44);
            this.decryptRadiobtn.Margin = new System.Windows.Forms.Padding(2);
            this.decryptRadiobtn.Name = "decryptRadiobtn";
            this.decryptRadiobtn.Size = new System.Drawing.Size(65, 17);
            this.decryptRadiobtn.TabIndex = 5;
            this.decryptRadiobtn.TabStop = true;
            this.decryptRadiobtn.Text = "Decrypt ";
            this.decryptRadiobtn.UseVisualStyleBackColor = true;
            // 
            // encryptRadiobtn
            // 
            this.encryptRadiobtn.AutoSize = true;
            this.encryptRadiobtn.Location = new System.Drawing.Point(12, 22);
            this.encryptRadiobtn.Margin = new System.Windows.Forms.Padding(2);
            this.encryptRadiobtn.Name = "encryptRadiobtn";
            this.encryptRadiobtn.Size = new System.Drawing.Size(64, 17);
            this.encryptRadiobtn.TabIndex = 4;
            this.encryptRadiobtn.Text = "Encrypt ";
            this.encryptRadiobtn.UseVisualStyleBackColor = true;
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(394, 235);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(188, 60);
            this.Clearbtn.TabIndex = 34;
            this.Clearbtn.Text = "CLEAR";
            this.Clearbtn.UseVisualStyleBackColor = true;
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(261, 313);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(188, 60);
            this.Backbtn.TabIndex = 33;
            this.Backbtn.Text = "BACK";
            this.Backbtn.UseVisualStyleBackColor = true;
            // 
            // Textbtn
            // 
            this.Textbtn.Location = new System.Drawing.Point(135, 235);
            this.Textbtn.Name = "Textbtn";
            this.Textbtn.Size = new System.Drawing.Size(188, 60);
            this.Textbtn.TabIndex = 32;
            this.Textbtn.Text = "SUBMIT";
            this.Textbtn.UseVisualStyleBackColor = true;
            this.Textbtn.Click += new System.EventHandler(this.Textbtn_Click);
            // 
            // plainTextbox
            // 
            this.plainTextbox.Location = new System.Drawing.Point(111, 39);
            this.plainTextbox.Name = "plainTextbox";
            this.plainTextbox.ReadOnly = true;
            this.plainTextbox.Size = new System.Drawing.Size(373, 20);
            this.plainTextbox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "File path";
            // 
            // Openbtn
            // 
            this.Openbtn.Location = new System.Drawing.Point(514, 37);
            this.Openbtn.Name = "Openbtn";
            this.Openbtn.Size = new System.Drawing.Size(88, 23);
            this.Openbtn.TabIndex = 37;
            this.Openbtn.Text = "Open File";
            this.Openbtn.UseVisualStyleBackColor = true;
            this.Openbtn.Click += new System.EventHandler(this.Openbtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(8, 78);
            this.lblKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(53, 13);
            this.lblKey.TabIndex = 26;
            this.lblKey.Text = "Password";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(111, 75);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(192, 20);
            this.passwordTextbox.TabIndex = 25;
            // 
            // CustomFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.Openbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.Textbtn);
            this.Controls.Add(this.plainTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.lblKey);
            this.Name = "CustomFileForm";
            this.Text = "B&G File";
            this.Load += new System.EventHandler(this.CustomFileForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton decryptRadiobtn;
        private System.Windows.Forms.RadioButton encryptRadiobtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button Textbtn;
        private System.Windows.Forms.TextBox plainTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Openbtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox passwordTextbox;
    }
}