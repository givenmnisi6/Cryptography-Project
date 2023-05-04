namespace Cryptography_Project
{
    partial class FileForm
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
            this.Filebtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.outputTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.browseTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.keyTextbox = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.Openbtn = new System.Windows.Forms.Button();
            this.OpenKeybtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Custombtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.decryptionRadiobtn);
            this.groupBox1.Controls.Add(this.encryptionRadiobtn);
            this.groupBox1.Location = new System.Drawing.Point(629, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 75);
            this.groupBox1.TabIndex = 34;
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
            this.Clearbtn.Location = new System.Drawing.Point(394, 227);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(188, 60);
            this.Clearbtn.TabIndex = 33;
            this.Clearbtn.Text = "CLEAR";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(261, 305);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(188, 60);
            this.Backbtn.TabIndex = 32;
            this.Backbtn.Text = "BACK";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // Filebtn
            // 
            this.Filebtn.Location = new System.Drawing.Point(135, 227);
            this.Filebtn.Name = "Filebtn";
            this.Filebtn.Size = new System.Drawing.Size(188, 60);
            this.Filebtn.TabIndex = 31;
            this.Filebtn.Text = "SUBMIT";
            this.Filebtn.UseVisualStyleBackColor = true;
            this.Filebtn.Click += new System.EventHandler(this.Filebtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Encryption Method:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Items.AddRange(new object[] {
            "Transposition",
            "Vigenere",
            "Vernam"});
            this.comboBox1.Location = new System.Drawing.Point(111, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // outputTextbox
            // 
            this.outputTextbox.Location = new System.Drawing.Point(111, 107);
            this.outputTextbox.Name = "outputTextbox";
            this.outputTextbox.ReadOnly = true;
            this.outputTextbox.Size = new System.Drawing.Size(373, 20);
            this.outputTextbox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Output Location";
            // 
            // browseTextbox
            // 
            this.browseTextbox.Location = new System.Drawing.Point(111, 31);
            this.browseTextbox.Name = "browseTextbox";
            this.browseTextbox.ReadOnly = true;
            this.browseTextbox.Size = new System.Drawing.Size(373, 20);
            this.browseTextbox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Browse Location:";
            // 
            // keyTextbox
            // 
            this.keyTextbox.Location = new System.Drawing.Point(111, 67);
            this.keyTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.keyTextbox.Name = "keyTextbox";
            this.keyTextbox.ReadOnly = true;
            this.keyTextbox.Size = new System.Drawing.Size(373, 20);
            this.keyTextbox.TabIndex = 24;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(8, 70);
            this.lblKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(72, 13);
            this.lblKey.TabIndex = 25;
            this.lblKey.Text = "Key Location:";
            // 
            // Openbtn
            // 
            this.Openbtn.Location = new System.Drawing.Point(507, 27);
            this.Openbtn.Name = "Openbtn";
            this.Openbtn.Size = new System.Drawing.Size(88, 23);
            this.Openbtn.TabIndex = 35;
            this.Openbtn.Text = "Open File";
            this.Openbtn.UseVisualStyleBackColor = true;
            this.Openbtn.Click += new System.EventHandler(this.Openbtn_Click);
            // 
            // OpenKeybtn
            // 
            this.OpenKeybtn.Location = new System.Drawing.Point(507, 64);
            this.OpenKeybtn.Name = "OpenKeybtn";
            this.OpenKeybtn.Size = new System.Drawing.Size(88, 23);
            this.OpenKeybtn.TabIndex = 36;
            this.OpenKeybtn.Text = "Open Key File";
            this.OpenKeybtn.UseVisualStyleBackColor = true;
            this.OpenKeybtn.Click += new System.EventHandler(this.OpenKeybtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(507, 107);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(88, 23);
            this.Savebtn.TabIndex = 37;
            this.Savebtn.Text = "Save File";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Custombtn
            // 
            this.Custombtn.Location = new System.Drawing.Point(629, 112);
            this.Custombtn.Name = "Custombtn";
            this.Custombtn.Size = new System.Drawing.Size(122, 23);
            this.Custombtn.TabIndex = 38;
            this.Custombtn.Text = "B&&G InHouse";
            this.Custombtn.UseVisualStyleBackColor = true;
            this.Custombtn.Click += new System.EventHandler(this.Custombtn_Click);
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.Custombtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.OpenKeybtn);
            this.Controls.Add(this.Openbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.Filebtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.outputTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browseTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyTextbox);
            this.Controls.Add(this.lblKey);
            this.Name = "FileForm";
            this.Text = "File Encryption";
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
        private System.Windows.Forms.Button Filebtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox outputTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox browseTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyTextbox;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Button Openbtn;
        private System.Windows.Forms.Button OpenKeybtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Custombtn;
    }
}