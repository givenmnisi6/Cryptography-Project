using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography_Project
{
    public partial class TextForm : Form
    {
        //Global string variables
        string plainText, encryptionKey, cipherText;
        public TextForm()
        {
            InitializeComponent();
        }

        private void plainTextbox_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(plainTextbox.Text))
            {
                e.Cancel = true;   
                plainTextbox.Focus();
                errorProvider1.SetError(plainTextbox, "Required Field");
            } else
            {
                e.Cancel = true;
                errorProvider1.SetError(plainTextbox, null);
            }
        }

        private void encryptionTextbox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(encryptionTextbox.Text))
            {
                e.Cancel = true;
                plainTextbox.Focus();
                errorProvider2.SetError(encryptionTextbox, "Required Field");
            }
            else
            {
                e.Cancel = true;
                errorProvider2.SetError(encryptionTextbox, null);
            }
        }

        private void Textbtn_Click(object sender, EventArgs e)
        {
            plainText = plainTextbox.Text;
            encryptionKey = encryptionTextbox.Text;
            cipherText = cipherTextbox.Text;


            if (plainText != "" && encryptionKey != "" && (int.TryParse(encryptionKey, out int x) || comboBox1.SelectedItem.ToString() == "Vigenere"))
            {
                if (comboBox1.SelectedItem.ToString() == "Vigenere")
                {
                    if (encryptionRadiobtn.Checked)
                    {
                        VigenereText vigenere = new VigenereText();
                        cipherTextbox.Text = vigenere.VigenereTextEncrypt(plainText, encryptionKey);

                    }
                    else if (decryptionRadiobtn.Checked)
                    {
                        VigenereText vigenere = new VigenereText();
                        cipherTextbox.Text = vigenere.VigenereTextDecrypt(plainText, encryptionKey);

                    }
                }
            }
            else
            {
                MessageBox.Show("You need to input text and a numerical key", "Hold up!");
            }

            //Error Providers
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(plainTextbox.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(encryptionTextbox.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
