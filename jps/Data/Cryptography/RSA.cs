using System.Security.Cryptography;

namespace Jpsmith.Data.Cryptography;

/// <summary>
/// Provides static methods for encrypting and decrypting data with the Rivest-Shamir-Adleman (RSA) algorithm.
/// </summary>
public static class RSA
{
    /// <summary>
    /// Encrypts the given data using the given key.
    /// </summary>
    /// <param name="data">Data to encrypt.</param>
    /// <param name="key">Encryption key.</param>
    /// <returns>Byte array containing encrypted data.</returns>
    public static byte[] Encrypt(byte[] data, RSAParameters key)
    {
        byte[] cipher;

        using (RSACryptoServiceProvider rsa = new())
        {
            rsa.ImportParameters(key);
            cipher = rsa.Encrypt(data, true);
        }

        return cipher;
    }

    /// <summary>
    /// Decrypts the given data using the given key.
    /// </summary>
    /// <param name="cipher">Data to decrypt.</param>
    /// <param name="key">Decryption key.</param>
    /// <returns>Byte array containing decrypted data.</returns>
    public static byte[] Decrypt(byte[] cipher, RSAParameters key)
    {
        byte[] data;

        using (RSACryptoServiceProvider rsa = new())
        {
            rsa.ImportParameters(key);
            data = rsa.Decrypt(cipher, true);
        }

        return data;
    }

}
