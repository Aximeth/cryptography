using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cryptography
{
    public partial class cryptographyMachine : Form
    {
        public cryptographyMachine()
        {
            InitializeComponent();
        }
        RsaEncryption rsa = new RsaEncryption();
        string cypher = string.Empty;
        private void encryptButton_Click(object sender, EventArgs e)
        {
            var text = encryptTextBox.Text;
            if (!string.IsNullOrEmpty(text))
            {
                encryptedTextBox.AppendText(rsa.Encrypt(text));
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            var text = decryptTextBox.Text;
            var plainText = rsa.Decrypt(text);
            decryptedTextBox.AppendText(plainText);
        }
    }
}
