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
    public partial class FileForm : Form
    {
        public FileForm()
        {
            InitializeComponent();
        }

        string input, output, key;
        VernamFiles vernam = new VernamFiles();

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
            if (comboBox1.SelectedItem.ToString() == "Vernam")
            {
                if (encryptionRadiobtn.Checked)
                {
                    vernam.VernamFileEncryption(input, key, output);
                    MessageBox.Show("Sucessfully encrypted the file with the Vernam algorithm!");
                }
                else if (decryptionRadiobtn.Checked)
                {
                    VernamText vernam = new VernamText();
                    MessageBox.Show("Sucessfully decrypted the file with the Vernam algorithm!");
                }
            }
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
