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
        byte[] abc;
        byte[,] table;


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
            abc = new byte[256];
            for (int i = 0; i < 256; i++)
            {
                abc[i] = Convert.ToByte(i);
            }

            table = new byte[256, 256];
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    table[i, j] = abc[(i + j) % 256];
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
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                byte[] fileContent = File.ReadAllBytes(plainTextbox.Text);
                byte[] passwordTemp = Encoding.ASCII.GetBytes(passwordTextbox.Text);
                byte[] keys = new byte[fileContent.Length];
                byte[] encrypted = new byte[fileContent.Length];

                for (int i = 0; i < fileContent.Length; i++)
                {
                    keys[i] = passwordTemp[i % passwordTemp.Length];
                }


                if (encryptRadiobtn.Checked)
                {
                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        byte value = fileContent[i];
                        byte key = keys[i];
                        int valueIndex = -1, keyIndex = -1;

                        for (int j = 0; j < 256; j++)
                        {
                            if (abc[j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        }
                        for (int j = 0; j < 256; j++)
                        {
                            if (abc[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }
                        }
                        encrypted[i] = table[keyIndex, valueIndex];
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
                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        byte value = fileContent[i];
                        byte key = keys[i];
                        int valueIndex = -1, keyIndex = -1;

                        for (int j = 0; j < 256; j++)
                        {
                            if (abc[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }
                        }
                        for (int j = 0; j < 256; j++)
                        {
                            if (table[keyIndex, j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        }
                        encrypted[i] = abc[valueIndex];
                    }
                    string fileName = Path.GetExtension(plainTextbox.Text);
                    SaveFileDialog sd = new SaveFileDialog();
                    sd.Filter = "Files (*" + fileName + " ) | *" + fileName;

                    if (sd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(sd.FileName, encrypted);
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
