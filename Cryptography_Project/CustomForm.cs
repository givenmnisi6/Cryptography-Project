using Cryptography_Project.Custom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cryptography_Project
{
    public partial class CustomForm : Form
    {
        string plainText;
        public CustomForm()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            plainTextbox.Text = "";
            cipherTextbox.Text = "";
            encryptionRadiobtn.Checked = false;
            decryptionRadiobtn.Checked = false;
        }

        private void Textbtn_Click(object sender, EventArgs e)
        {
            plainText = plainTextbox.Text;
            if (encryptionRadiobtn.Checked)
            {
                CustomText custom = new CustomText();
                cipherTextbox.Text = custom.encryptedText(custom.reverseText(custom.swapText(plainText)));
                MessageBox.Show("Sucessfully encrypted the text with the B&G InHouse algorithm!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (decryptionRadiobtn.Checked)
            {
                CustomText custom = new CustomText();
                cipherTextbox.Text = custom.decryptedText(custom.reverseText(custom.swapText(plainText)));
                MessageBox.Show("Sucessfully decrypted the text with the B&G InHouse algorithm!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
