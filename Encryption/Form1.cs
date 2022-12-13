using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboEncryptionType.SelectedIndex = 0;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string result;
                if ( comboEncryptionType.SelectedIndex == 0)
                {
                    result = Encryption.Encrypt(txtTextToEncrypt.Text, txtPrivateKey.Text);
                }
                else
                {
                    result = Encryption1.Encrypt(txtTextToEncrypt.Text, txtPrivateKey.Text);
                }

                lblEncryptedText.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string result;
                if ( comboEncryptionType.SelectedIndex == 0)
                {
                    result = Encryption.Decrypt(txtTextToDecrypt.Text, txtPrivateKey.Text);
                }
                else
                {
                    result = Encryption1.Decrypt(txtTextToDecrypt.Text, txtPrivateKey.Text);
                }

                lblDecryptedText.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
