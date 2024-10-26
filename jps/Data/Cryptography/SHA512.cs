namespace Jpsmith.Data.Cryptography;

/// <summary>
/// Provides static classes for hashing data with the SHA512 algorithm.
/// </summary>
public static class SHA512
{
    /// <summary>
    /// Computes a hash for the given byte array using the SHA512 algorithm.
    /// </summary>
    /// <param name="exposed">The exposed byte array.</param>
    /// <returns>The computed hash.</returns>
    public static byte[] Hash(byte[] exposed) => System.Security.Cryptography.SHA512.HashData(exposed);
}
