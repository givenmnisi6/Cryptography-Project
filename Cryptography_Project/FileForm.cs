using Cryptography_Project.Transposition;
using Cryptography_Project.Vernam;
using Cryptography_Project.Vigenère;
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
    public partial class FileForm : Form
    {
        public FileForm()
        {
            InitializeComponent();
        }

        string input, output, key;
        readonly VernamFiles vernam = new VernamFiles();
        readonly VigenereFiles vigenere = new VigenereFiles();
        readonly TranspositionFiles transposition = new TranspositionFiles();

        //Open the file to be encrypted or decrypted
        private void Openbtn_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                input = openFileDialog1.FileName;
                browseTextbox.Text = input;   
            }
        }
        
        //Open the key file
        private void OpenKeybtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                key = openFileDialog1.FileName;
                keyTextbox.Text = key;
            }
        }

        //Save the encrypted or decrypted file
        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                output = saveFileDialog1.FileName;
                outputTextbox.Text = output;
            }
        }

        private void Filebtn_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an algorithm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (encryptionRadiobtn.Checked == false && decryptionRadiobtn.Checked == false)
            {
                MessageBox.Show("Please select an operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (browseTextbox.Text == "")
            {
                MessageBox.Show("Please select a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (keyTextbox.Text == "")
            {
                MessageBox.Show("Please select a key file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (outputTextbox.Text == "")
            {
                MessageBox.Show("Please select a file to save the output!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox1.SelectedItem.ToString() == "Vernam" && encryptionRadiobtn.Checked && keyTextbox.Text != "")
            {
                //VernamText vernam = new VernamText();
                //vernam.VernamFileEncryption(input, output, key);
                vernam.VernamFileEncrypt(input, output, key);
                MessageBox.Show("Sucessfully encrypted the file with the Vernam algorithm!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBox1.SelectedItem.ToString() == "Vernam" && decryptionRadiobtn.Checked && keyTextbox.Text != "")
            {
                //VernamText vernam = new VernamText();
                //vernam.VernamFileDecryption(input, output, key);
                vernam.VernamFileDecrypt(input, key, output);
                MessageBox.Show("Sucessfully decrypted the file with the Vernam algorithm!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else if (comboBox1.SelectedItem.ToString() == "Transposition" && encryptionRadiobtn.Checked && keyTextbox.Text != "")
            {
                transposition.Transpose(input, output, 0);
                MessageBox.Show("Sucessfully encrypted the file with the Transposition algorithm!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBox1.SelectedItem.ToString() == "Transposition" && decryptionRadiobtn.Checked && keyTextbox.Text != "")
            {
                transposition.Transpose(input, output, 1);
                MessageBox.Show("Sucessfully decrypted the file with the Transposition algorithm!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBox1.SelectedItem.ToString() == "Vigenere" && encryptionRadiobtn.Checked && keyTextbox.Text != "")
            {
                vigenere.VigenereFileEncrypt(input, output, key);
                MessageBox.Show("Sucessfully encrypted the file with the Vigenere algorithm!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBox1.SelectedItem.ToString() == "Vigenere" && decryptionRadiobtn.Checked && keyTextbox.Text != "")
            {
                vigenere.VigenereFileDecrypt(input, key, output);
                MessageBox.Show("Sucessfully decrypted the file with the Vigenere algorithm!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            /* if (comboBox1.SelectedItem.ToString() == "Vernam")
             {
                 if (encryptionRadiobtn.Checked)
                 {
                     //vernam.VernamFileEncryption(input, output, key);
                     vernam.VernamFileEncrypt(input, output, key);
                     MessageBox.Show("Sucessfully encrypted the file with the Vernam algorithm!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                 else if (decryptionRadiobtn.Checked)
                 {
                     //VernamText vernam = new VernamText();
                     //vernam.VernamFileDecryption(input, output, key);
                     vernam.VernamFileDecrypt(input, key, output);
                     MessageBox.Show("Sucessfully decrypted the file with the Vernam algorithm!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
             }*/
        }

        private void Custombtn_Click(object sender, EventArgs e)
        {
            //creating an instance of the TextEncryption form
            CustomFileForm customfile = new CustomFileForm();
            customfile.ShowDialog();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            browseTextbox.Text = "";
            keyTextbox.Text = "";
            outputTextbox.Text = "";
            comboBox1.SelectedItem = null;
            encryptionRadiobtn.Checked = false;
            decryptionRadiobtn.Checked = false;
        }
    }
}
