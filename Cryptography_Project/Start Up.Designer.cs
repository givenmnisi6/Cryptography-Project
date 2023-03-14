namespace Cryptography_Project
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
            this.Exitbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Filesbtn = new System.Windows.Forms.Button();
            this.Textbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(305, 267);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(188, 60);
            this.Exitbtn.TabIndex = 8;
            this.Exitbtn.Text = "EXIT";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "What do you want to encrypt?";
            // 
            // Filesbtn
            // 
            this.Filesbtn.Location = new System.Drawing.Point(435, 183);
            this.Filesbtn.Name = "Filesbtn";
            this.Filesbtn.Size = new System.Drawing.Size(188, 60);
            this.Filesbtn.TabIndex = 6;
            this.Filesbtn.Text = "FILES";
            this.Filesbtn.UseVisualStyleBackColor = true;
            // 
            // Textbtn
            // 
            this.Textbtn.Location = new System.Drawing.Point(178, 183);
            this.Textbtn.Name = "Textbtn";
            this.Textbtn.Size = new System.Drawing.Size(188, 60);
            this.Textbtn.TabIndex = 5;
            this.Textbtn.Text = "TEXT";
            this.Textbtn.UseVisualStyleBackColor = true;
            this.Textbtn.Click += new System.EventHandler(this.Textbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Filesbtn);
            this.Controls.Add(this.Textbtn);
            this.Name = "Form1";
            this.Text = "Start Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Filesbtn;
        private System.Windows.Forms.Button Textbtn;
    }
}

