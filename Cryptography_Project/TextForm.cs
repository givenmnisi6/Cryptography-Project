using Cryptography_Project.Transposition;
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
                        MessageBox.Show("Sucessfully encrypted the text with the vigenere encryption!");
                    }
                    
                    else if (decryptionRadiobtn.Checked)
                    {
                        VigenereText vigenere = new VigenereText();
                        cipherTextbox.Text = vigenere.VigenereTextDecrypt(plainText, encryptionKey);
                        MessageBox.Show("Sucessfully decrypted the text with the vigenere encryption!");
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
                            TranspositionText trans = new TranspositionText(keyValue = Convert.ToInt32(encryptionTextbox.Text));
                            cipherTextbox.Text = trans.Encrypt(plainText);
                        }
                        MessageBox.Show("Sucessfully encrypted the text with the transposition encryption!");
                    }
                    else if (decryptionRadiobtn.Checked)
                    {
                        int test, keyValue;

                        if (int.TryParse(encryptionTextbox.Text, out test))
                        {
                            TranspositionText trans = new TranspositionText(keyValue = Convert.ToInt32(encryptionTextbox.Text));
                            cipherTextbox.Text = trans.Decrypt(plainText);
                        }
                        MessageBox.Show("Sucessfully decrypted the text with the transposition encryption!");
                    }
                }
            }
            else
            {
                MessageBox.Show("You need to input text and a numerical key");
            }
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
