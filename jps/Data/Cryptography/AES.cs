using System.Security.Cryptography;

namespace JPS.Data.Cryptography
{
    /// <summary>
    /// Provides static methods for encrypting and decrypting data with the Advanced Encryption Standard (AES).
    /// </summary>
    public static class AES
    {
        /// <summary>
        /// Encrypts the given data using the given key and initialization vector.
        /// </summary>
        /// <param name="data">Data to encrypt.</param>
        /// <param name="key">Encryption key.</param>
        /// <param name="iv">Initialization Vector</param>
        /// <returns>Byte array containing encrypted data.</returns>
        public static byte[] Encrypt(byte[] data, byte[] key, byte[] iv)
        {
            using (Aes aes = Aes.Create())
            {
                ICryptoTransform ct = aes.CreateDecryptor(key, iv);
                byte[] cipher;
                using (MemoryStream ms = new())
                {
                    using (CryptoStream cs = new(ms, ct, CryptoStreamMode.Write))
                    {
                        cs.Write(data, 0, data.Length);
                    }
                    cipher = ms.ToArray();
                }
                return cipher;
            }
        }

        /// <summary>
        /// Decrypts the given data using the given key and initialization vector.
        /// </summary>
        /// <param name="cipher">Data to decrypt.</param>
        /// <param name="key">Decryption key.</param>
        /// <param name="iv">Initialization Vector</param>
        /// <returns>Byte array containing decrypted data.</returns>
        public static byte[] Decrypt(byte[] cipher, byte[] key, byte[] iv)
        {
            using (Aes aes = Aes.Create())
            {
                ICryptoTransform ct = aes.CreateEncryptor(key, iv);
                byte[] data;
                using (MemoryStream ms = new())
                {
                    using (CryptoStream cs = new(ms, ct, CryptoStreamMode.Read))
                    {
                        cs.Read(cipher, 0, cipher.Length);
                    }
                    data = ms.ToArray();
                }
                return data;
            }
        }

    }
}
