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
        string plainTextText, encryptionKey, cipherText;
        public TextForm()
        {
            InitializeComponent();
        }

        private void Textbtn_Click(object sender, EventArgs e)
        {
            plainTextText = plainTextbox.Text;
            encryptionKey = encryptionTextbox.Text;
            cipherText = cipherTextbox.Text;


            if (plainTextText != "" && encryptionKey != "" && (int.TryParse(encryptionKey, out int x) || comboBox1.SelectedItem.ToString() == "Vigenere"))
            {
                if (comboBox1.SelectedItem.ToString() == "Vigenere")
                {
                    if (encryptionRadiobtn.Checked)
                    {
                        VigenereText vigenere = new VigenereText();
                        cipherTextbox.Text = vigenere.VigenereTextEncrypt(plainTextText, encryptionKey);

                    }
                    else if (decryptionRadiobtn.Checked)
                    {
                        VigenereText vigenere = new VigenereText();
                        cipherTextbox.Text = vigenere.VigenereTextDecrypt(plainTextText, encryptionKey);
                    }
                }
            }
            else
            {
                MessageBox.Show("You need to input text and a numerical key", "Hold up!");
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
