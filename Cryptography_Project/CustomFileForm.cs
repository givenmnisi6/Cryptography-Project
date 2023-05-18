using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Cryptography_Project.Custom;

namespace Cryptography_Project
{
    public partial class CustomFileForm : Form
    {
        byte[] abcd;
        byte[,] byteTable;


        public CustomFileForm()
        {
            InitializeComponent();
        }
        private void CustomFileForm_Load(object sender, EventArgs e)
        {
            InitializeTable();
        }

        private void InitializeTable()
        {
            abcd = new byte[256];
            for (int i = 0; i < 256; i++)
            {
                abcd[i] = Convert.ToByte(i);
            }

            byteTable = new byte[256, 256];
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    byteTable[i, j] = abcd[(i + j) % 256];
                }
            }
        }

        private void Openbtn_Click(object sender, EventArgs e)
        {
            string input;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                input = openFileDialog1.FileName;
                plainTextbox.Text = input;
            }
        }

        private void Textbtn_Click(object sender, EventArgs e)
        {
            if(!File.Exists(plainTextbox.Text))
            {
                MessageBox.Show("Please select a file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(passwordTextbox.Text))
            {
                MessageBox.Show("Please generate a key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(encryptRadiobtn.Checked == false && decryptRadiobtn.Checked == false)
            {
                MessageBox.Show("Please select an option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                byte[] fileContents = File.ReadAllBytes(plainTextbox.Text);
                byte[] passwordTemp = Encoding.ASCII.GetBytes(passwordTextbox.Text);
                byte[] keys = new byte[fileContents.Length];
                byte[] encrypted = new byte[fileContents.Length];

                for (int i = 0; i < fileContents.Length; i++)
                {
                    keys[i] = passwordTemp[i % passwordTemp.Length];
                }


                if (encryptRadiobtn.Checked)
                {
                    for (int i = 0; i < fileContents.Length; i++)
                    {
                        byte value = fileContents[i];
                        byte cipherKey = keys[i];
                        int valueIndexes = -1, keyIndexes = -1;

                        for (int j = 0; j < 256; j++)
                        {
                            if (abcd[j] == value)
                            {
                                valueIndexes = j;
                                break;
                            }
                        }
                        for (int j = 0; j < 256; j++)
                        {
                            if (abcd[j] == cipherKey)
                            {
                                keyIndexes = j;
                                break;
                            }
                        }
                        encrypted[i] = byteTable[keyIndexes, valueIndexes];
                    }
                    string fileName = Path.GetExtension(plainTextbox.Text);
                    SaveFileDialog sd = new SaveFileDialog
                    {
                        Filter = "Files (*" + fileName + " ) | *" + fileName
                    };

                    if (sd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(sd.FileName, encrypted);
                    }
                    MessageBox.Show("File encrypted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (decryptRadiobtn.Checked)
                {
                    for (int i = 0; i < fileContents.Length; i++)
                    {
                        byte value = fileContents[i];
                        byte cipherKey = keys[i];
                        int valueIndexes = -1, keyIndexes = -1;

                        for (int j = 0; j < 256; j++)
                        {
                            if (abcd[j] == cipherKey)
                            {
                                keyIndexes = j;
                                break;
                            }
                        }
                        for (int j = 0; j < 256; j++)
                        {
                            if (byteTable[keyIndexes, j] == value)
                            {
                                valueIndexes = j;
                                break;
                            }
                        }
                        encrypted[i] = abcd[valueIndexes];
                    }
                    string fileName = Path.GetExtension(plainTextbox.Text);
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Files (*" + fileName + " ) | *" + fileName;

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(saveDialog.FileName, encrypted);
                    }
                    MessageBox.Show("File decrypted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("File is in use");
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            plainTextbox.Text = "";
            passwordTextbox.Text = "";
            encryptRadiobtn.Checked = false;
            decryptRadiobtn.Checked = false;
        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            KeyGenerator keyGenerator = new KeyGenerator();
            passwordTextbox.Text = Convert.ToBase64String(keyGenerator.generateKey());
        }
    }
}
