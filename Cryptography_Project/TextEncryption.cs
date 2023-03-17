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
    public partial class TextEncryption : Form
    {
        public TextEncryption()
        {
            InitializeComponent();
        }
        private void TextEncryption_Shown(object sender, EventArgs e)
        {
            //focus on the first textbox
            ViInputtxt.Focus();
        }

    }
}
