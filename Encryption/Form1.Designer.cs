
namespace Encryption
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.comboEncryptionType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTextToEncrypt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTextToDecrypt = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.lblEncryptedText = new System.Windows.Forms.TextBox();
            this.lblDecryptedText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encryption Type:";
            // 
            // comboEncryptionType
            // 
            this.comboEncryptionType.FormattingEnabled = true;
            this.comboEncryptionType.Items.AddRange(new object[] {
            "AES",
            "Rijndael"});
            this.comboEncryptionType.Location = new System.Drawing.Point(191, 9);
            this.comboEncryptionType.Name = "comboEncryptionType";
            this.comboEncryptionType.Size = new System.Drawing.Size(155, 24);
            this.comboEncryptionType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Test to Encrypt";
            // 
            // txtTextToEncrypt
            // 
            this.txtTextToEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextToEncrypt.Location = new System.Drawing.Point(49, 103);
            this.txtTextToEncrypt.Name = "txtTextToEncrypt";
            this.txtTextToEncrypt.Size = new System.Drawing.Size(427, 22);
            this.txtTextToEncrypt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Text to Decrypt";
            // 
            // txtTextToDecrypt
            // 
            this.txtTextToDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextToDecrypt.Location = new System.Drawing.Point(52, 241);
            this.txtTextToDecrypt.Name = "txtTextToDecrypt";
            this.txtTextToDecrypt.Size = new System.Drawing.Size(428, 22);
            this.txtTextToDecrypt.TabIndex = 5;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncrypt.Location = new System.Drawing.Point(385, 53);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(91, 44);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(385, 179);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(91, 44);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Private Key:";
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrivateKey.Location = new System.Drawing.Point(207, 312);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.PasswordChar = '*';
            this.txtPrivateKey.Size = new System.Drawing.Size(269, 22);
            this.txtPrivateKey.TabIndex = 9;
            // 
            // lblEncryptedText
            // 
            this.lblEncryptedText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEncryptedText.Location = new System.Drawing.Point(52, 141);
            this.lblEncryptedText.Name = "lblEncryptedText";
            this.lblEncryptedText.ReadOnly = true;
            this.lblEncryptedText.Size = new System.Drawing.Size(424, 22);
            this.lblEncryptedText.TabIndex = 10;
            // 
            // lblDecryptedText
            // 
            this.lblDecryptedText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDecryptedText.Location = new System.Drawing.Point(49, 276);
            this.lblDecryptedText.Name = "lblDecryptedText";
            this.lblDecryptedText.ReadOnly = true;
            this.lblDecryptedText.Size = new System.Drawing.Size(427, 22);
            this.lblDecryptedText.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 352);
            this.Controls.Add(this.lblDecryptedText);
            this.Controls.Add(this.lblEncryptedText);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtTextToDecrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTextToEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboEncryptionType);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboEncryptionType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTextToEncrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTextToDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.TextBox lblEncryptedText;
        private System.Windows.Forms.TextBox lblDecryptedText;
    }
}

