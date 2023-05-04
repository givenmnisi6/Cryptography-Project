using Cryptography_Project.Custom;
using Cryptography_Project.Transposition;
using Cryptography_Project.Vernam;
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
                        MessageBox.Show("Sucessfully encrypted the text with the Vigene algorithm!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    else if (decryptionRadiobtn.Checked)
                    {
                        VigenereText vigenere = new VigenereText();
                        cipherTextbox.Text = vigenere.VigenereTextDecrypt(plainText, encryptionKey);
                        MessageBox.Show("Sucessfully decrypted the text with the Vigene algorithm!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
 
                    //error Providers
                    if (plainTextbox.Text == "")
                    {
                        errorProvider1.SetError(plainTextbox, "Required Field");
                    }
                    if (encryptionTextbox.Text == "")
                    {
                        errorProvider2.SetError(encryptionTextbox, "Required Field");
                    }
                }
                else if (comboBox1.SelectedItem.ToString() == "Transposition")
                {
                    if (encryptionRadiobtn.Checked)
                    {
                        int test, keyValue;

                        if (int.TryParse(encryptionTextbox.Text, out test))
                        {
                            TranspositionText transposition = new TranspositionText(keyValue = Convert.ToInt32(encryptionTextbox.Text));
                            cipherTextbox.Text = transposition.Encrypt(plainText);
                        }
                        MessageBox.Show("Sucessfully encrypted the text with the Transposition algorithm!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (decryptionRadiobtn.Checked)
                    {
                        int keyValue;

                        if (int.TryParse(encryptionTextbox.Text, out int test))
                        {
                            TranspositionText transposition = new TranspositionText(keyValue = Convert.ToInt32(encryptionTextbox.Text));
                            cipherTextbox.Text = transposition.Decrypt(plainText);
                        }
                        MessageBox.Show("Sucessfully decrypted the text with the Transposition algorithm!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } 
                else if (comboBox1.SelectedItem.ToString() == "Vernam")
                {
                    if (encryptionRadiobtn.Checked)
                    {
                        VernamText vernam = new VernamText();
                        cipherTextbox.Text = vernam.VernamEncryptionAndDecryption(plainText, encryptionKey);
                        MessageBox.Show("Sucessfully encrypted the text with the Vernam algorithm!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (decryptionRadiobtn.Checked)
                    {
                        VernamText vernam = new VernamText();
                        cipherTextbox.Text = vernam.VernamEncryptionAndDecryption(plainText, encryptionKey);
                        MessageBox.Show("Sucessfully decrypted the text with the Vernam algorithm!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please check your inputs");
            }
        }

        private void Custombtn_Click(object sender, EventArgs e)
        {
            //creating an instance of the TextEncryption form
            CustomForm custom = new CustomForm();
            custom.ShowDialog();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            plainTextbox.Text = "";
            encryptionTextbox.Text = "";
            cipherTextbox.Text = "";
            comboBox1.SelectedItem= null;
            encryptionRadiobtn.Checked = false;
            decryptionRadiobtn.Checked = false; 
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
