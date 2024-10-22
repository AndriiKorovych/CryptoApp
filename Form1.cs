using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CryptoApp
{
    public partial class Form1 : Form
    {
        private byte[] aesKey;
        private byte[] aesIV;
        private RSACryptoServiceProvider rsa;

        public Form1()
        {
            InitializeComponent();
            GenerateAESKeyAndIV();
            rsa = new RSACryptoServiceProvider(2048); // Генерація ключів RSA
        }

        // Генерація AES ключа та IV
        private void GenerateAESKeyAndIV()
        {
            aesKey = GenerateRandomBytes(32); // 256-бітний ключ
            aesIV = GenerateRandomBytes(16);  // 128-бітний IV
        }

        private byte[] GenerateRandomBytes(int length)
        {
            byte[] bytes = new byte[length];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytes);
            }
            return bytes;
        }

        // Шифрування файлу з AES
        private void btnEncryptAES_Click(object sender, EventArgs e)
        {
            string inputFile = txtFileName.Text + ".txt";
            string encryptedFile = txtFileName.Text + ".aes";

            if (File.Exists(inputFile))
            {
                EncryptAES(inputFile, encryptedFile);
                MessageBox.Show("Файл зашифровано успішно!");
            }
            else
            {
                MessageBox.Show("Файл не знайдено!");
            }
        }

        private void EncryptAES(string inputFile, string encryptedFile)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = aesKey;
                aes.IV = aesIV;

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                using (var inputStream = File.OpenRead(inputFile))
                using (var outputStream = File.OpenWrite(encryptedFile))
                using (var cryptoStream = new CryptoStream(outputStream, encryptor, CryptoStreamMode.Write))
                {
                    inputStream.CopyTo(cryptoStream);
                }
            }
        }

        // Дешифрування файлу з AES
        private void btnDecryptAES_Click(object sender, EventArgs e)
        {
            string encryptedFile = txtFileName.Text + ".aes";
            string decryptedFile = txtFileName.Text + "_decrypted.txt";

            if (File.Exists(encryptedFile))
            {
                DecryptAES(encryptedFile, decryptedFile);
                MessageBox.Show("Файл розшифровано успішно!");
            }
            else
            {
                MessageBox.Show("Зашифрований файл не знайдено!");
            }
        }

        private void DecryptAES(string encryptedFile, string decryptedFile)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = aesKey;
                aes.IV = aesIV;

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                using (var inputStream = File.OpenRead(encryptedFile))
                using (var outputStream = File.OpenWrite(decryptedFile))
                using (var cryptoStream = new CryptoStream(inputStream, decryptor, CryptoStreamMode.Read))
                {
                    cryptoStream.CopyTo(outputStream);
                }
            }
        }

        // Шифрування файлу з RSA
        private void btnEncryptRSA_Click(object sender, EventArgs e)
        {
            string inputFile = txtFileName.Text + ".txt";
            string encryptedFile = txtFileName.Text + ".rsa";

            if (File.Exists(inputFile))
            {
                byte[] data = File.ReadAllBytes(inputFile);
                byte[] encryptedData = rsa.Encrypt(data, false);
                File.WriteAllBytes(encryptedFile, encryptedData);
                MessageBox.Show("Файл зашифровано RSA!");
            }
            else
            {
                MessageBox.Show("Файл не знайдено!");
            }
        }

        // Дешифрування файлу з RSA
        private void btnDecryptRSA_Click(object sender, EventArgs e)
        {
            string encryptedFile = txtFileName.Text + ".rsa";
            string decryptedFile = txtFileName.Text + "_decrypted.txt";

            if (File.Exists(encryptedFile))
            {
                byte[] encryptedData = File.ReadAllBytes(encryptedFile);
                byte[] decryptedData = rsa.Decrypt(encryptedData, false);
                File.WriteAllBytes(decryptedFile, decryptedData);
                MessageBox.Show("Файл розшифровано RSA!");
            }
            else
            {
                MessageBox.Show("Зашифрований файл не знайдено!");
            }
        }
    }
}
