namespace CryptoApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnEncryptAES;
        private System.Windows.Forms.Button btnDecryptAES;
        private System.Windows.Forms.Button btnEncryptRSA;
        private System.Windows.Forms.Button btnDecryptRSA;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileName;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnEncryptAES = new System.Windows.Forms.Button();
            this.btnDecryptAES = new System.Windows.Forms.Button();
            this.btnEncryptRSA = new System.Windows.Forms.Button();
            this.btnDecryptRSA = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(20, 20);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(70, 17);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "File Name";

            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(100, 20);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(250, 22);
            this.txtFileName.TabIndex = 1;

            // 
            // btnEncryptAES
            // 
            this.btnEncryptAES.Location = new System.Drawing.Point(100, 60);
            this.btnEncryptAES.Name = "btnEncryptAES";
            this.btnEncryptAES.Size = new System.Drawing.Size(100, 30);
            this.btnEncryptAES.TabIndex = 2;
            this.btnEncryptAES.Text = "Encrypt AES";
            this.btnEncryptAES.UseVisualStyleBackColor = true;
            this.btnEncryptAES.Click += new System.EventHandler(this.btnEncryptAES_Click);

            // 
            // btnDecryptAES
            // 
            this.btnDecryptAES.Location = new System.Drawing.Point(250, 60);
            this.btnDecryptAES.Name = "btnDecryptAES";
            this.btnDecryptAES.Size = new System.Drawing.Size(100, 30);
            this.btnDecryptAES.TabIndex = 3;
            this.btnDecryptAES.Text = "Decrypt AES";
            this.btnDecryptAES.UseVisualStyleBackColor = true;
            this.btnDecryptAES.Click += new System.EventHandler(this.btnDecryptAES_Click);

            // 
            // btnEncryptRSA
            // 
            this.btnEncryptRSA.Location = new System.Drawing.Point(100, 100);
            this.btnEncryptRSA.Name = "btnEncryptRSA";
            this.btnEncryptRSA.Size = new System.Drawing.Size(100, 30);
            this.btnEncryptRSA.TabIndex = 4;
            this.btnEncryptRSA.Text = "Encrypt RSA";
            this.btnEncryptRSA.UseVisualStyleBackColor = true;
            this.btnEncryptRSA.Click += new System.EventHandler(this.btnEncryptRSA_Click);

            // 
            // btnDecryptRSA
            // 
            this.btnDecryptRSA.Location = new System.Drawing.Point(250, 100);
            this.btnDecryptRSA.Name = "btnDecryptRSA";
            this.btnDecryptRSA.Size = new System.Drawing.Size(100, 30);
            this.btnDecryptRSA.TabIndex = 5;
            this.btnDecryptRSA.Text = "Decrypt RSA";
            this.btnDecryptRSA.UseVisualStyleBackColor = true;
            this.btnDecryptRSA.Click += new System.EventHandler(this.btnDecryptRSA_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.btnEncryptAES);
            this.Controls.Add(this.btnDecryptAES);
            this.Controls.Add(this.btnEncryptRSA);
            this.Controls.Add(this.btnDecryptRSA);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblFileName);
            this.Name = "Form1";
            this.Text = "CryptoApp";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

