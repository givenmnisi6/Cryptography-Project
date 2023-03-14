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
            this.tcVernam = new System.Windows.Forms.TabPage();
            this.tcTransposition = new System.Windows.Forms.TabPage();
            this.tcCustom = new System.Windows.Forms.TabPage();
            this.txtVigKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbDecryptVig = new System.Windows.Forms.RadioButton();
            this.rbEncryptVig = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Vigeneretc.SuspendLayout();
            this.tcVigenere.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tcVigenere.Controls.Add(this.panel1);
            this.tcVigenere.Controls.Add(this.textBox1);
            this.tcVigenere.Controls.Add(this.label1);
            this.tcVigenere.Controls.Add(this.txtVigKey);
            this.tcVigenere.Controls.Add(this.lblKey);
            this.tcVigenere.Location = new System.Drawing.Point(4, 22);
            this.tcVigenere.Name = "tcVigenere";
            this.tcVigenere.Padding = new System.Windows.Forms.Padding(3);
            this.tcVigenere.Size = new System.Drawing.Size(702, 373);
            this.tcVigenere.TabIndex = 0;
            this.tcVigenere.Text = "Vigenère";
            this.tcVigenere.UseVisualStyleBackColor = true;
            // 
            // tcVernam
            // 
            this.tcVernam.Location = new System.Drawing.Point(4, 22);
            this.tcVernam.Name = "tcVernam";
            this.tcVernam.Padding = new System.Windows.Forms.Padding(3);
            this.tcVernam.Size = new System.Drawing.Size(702, 373);
            this.tcVernam.TabIndex = 1;
            this.tcVernam.Text = "Vernam";
            this.tcVernam.UseVisualStyleBackColor = true;
            // 
            // tcTransposition
            // 
            this.tcTransposition.Location = new System.Drawing.Point(4, 22);
            this.tcTransposition.Name = "tcTransposition";
            this.tcTransposition.Size = new System.Drawing.Size(702, 373);
            this.tcTransposition.TabIndex = 2;
            this.tcTransposition.Text = "Transposition";
            this.tcTransposition.UseVisualStyleBackColor = true;
            // 
            // tcCustom
            // 
            this.tcCustom.Location = new System.Drawing.Point(4, 22);
            this.tcCustom.Name = "tcCustom";
            this.tcCustom.Size = new System.Drawing.Size(702, 373);
            this.tcCustom.TabIndex = 3;
            this.tcCustom.Text = "Custom";
            this.tcCustom.UseVisualStyleBackColor = true;
            // 
            // txtVigKey
            // 
            this.txtVigKey.Location = new System.Drawing.Point(91, 61);
            this.txtVigKey.Margin = new System.Windows.Forms.Padding(2);
            this.txtVigKey.Name = "txtVigKey";
            this.txtVigKey.Size = new System.Drawing.Size(151, 20);
            this.txtVigKey.TabIndex = 3;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(2, 64);
            this.lblKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(81, 13);
            this.lblKey.TabIndex = 2;
            this.lblKey.Text = "Encryption Key:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cipher Text:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 20);
            this.textBox1.TabIndex = 5;
            // 
            // rbDecryptVig
            // 
            this.rbDecryptVig.AutoSize = true;
            this.rbDecryptVig.Location = new System.Drawing.Point(12, 44);
            this.rbDecryptVig.Margin = new System.Windows.Forms.Padding(2);
            this.rbDecryptVig.Name = "rbDecryptVig";
            this.rbDecryptVig.Size = new System.Drawing.Size(81, 17);
            this.rbDecryptVig.TabIndex = 7;
            this.rbDecryptVig.TabStop = true;
            this.rbDecryptVig.Text = "Decrypt File";
            this.rbDecryptVig.UseVisualStyleBackColor = true;
            // 
            // rbEncryptVig
            // 
            this.rbEncryptVig.AutoSize = true;
            this.rbEncryptVig.Location = new System.Drawing.Point(12, 16);
            this.rbEncryptVig.Margin = new System.Windows.Forms.Padding(2);
            this.rbEncryptVig.Name = "rbEncryptVig";
            this.rbEncryptVig.Size = new System.Drawing.Size(80, 17);
            this.rbEncryptVig.TabIndex = 6;
            this.rbEncryptVig.Text = "Encrypt File";
            this.rbEncryptVig.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbEncryptVig);
            this.panel1.Controls.Add(this.rbDecryptVig);
            this.panel1.Location = new System.Drawing.Point(561, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 76);
            this.panel1.TabIndex = 8;
            // 
            // TextEncryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Vigeneretc);
            this.Name = "TextEncryption";
            this.Text = "Text Encryption";
            this.Vigeneretc.ResumeLayout(false);
            this.tcVigenere.ResumeLayout(false);
            this.tcVigenere.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Vigeneretc;
        private System.Windows.Forms.TabPage tcVigenere;
        private System.Windows.Forms.TabPage tcVernam;
        private System.Windows.Forms.TabPage tcTransposition;
        private System.Windows.Forms.TabPage tcCustom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVigKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbEncryptVig;
        private System.Windows.Forms.RadioButton rbDecryptVig;
    }
}