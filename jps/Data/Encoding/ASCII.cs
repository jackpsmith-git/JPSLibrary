namespace JPS.Data.Encoding
{
    /// <summary>
    /// Provides static methods for encoding and decoding data with the ASCII format.
    /// </summary>
    public static class ASCII
    {
        /// <summary>
        /// Encodes the given string to a byte array.
        /// </summary>
        /// <param name="data">The string to encode.</param>
        /// <returns>Byte array containing encoded data.</returns>
        public static byte[] Encode(string data)
        {
            return System.Text.Encoding.ASCII.GetBytes(data);
        }

        /// <summary>
        /// Decodes the given byte array to a string.
        /// </summary>
        /// <param name="data">The data to decode.</param>
        /// <returns>String containing decoded data.</returns>
        public static string Decode(byte[] data)
        {
            return System.Text.Encoding.ASCII.GetString(data);
        }
    }

}
