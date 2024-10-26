namespace Jpsmith.Data.Encoding;

/// <summary>
/// Provides static methods for encoding and decoding data with the UTF-8 format.
/// </summary>
public static class UTF8
{
    /// <summary>
    /// Encodes the given string to a byte array.
    /// </summary>
    /// <param name="data">The string to encode.</param>
    /// <returns>Byte array containing encoded data.</returns>
    public static byte[] Encode(string data) => System.Text.Encoding.UTF8.GetBytes(data);

    /// <summary>
    /// Decodes the given byte array to a string.
    /// </summary>
    /// <param name="data">The data to decode.</param>
    /// <returns>String containing decoded data.</returns>
    public static string Decode(byte[] data) => System.Text.Encoding.UTF8.GetString(data);
}