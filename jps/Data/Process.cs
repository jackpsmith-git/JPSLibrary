namespace JPS.Data
{
    /// <summary>
    /// Provides static methods for reading/writing data to files.
    /// </summary>
    public static class Process
    {
        /// <summary>
        /// Writes the given data to the given file path.
        /// </summary>
        /// <param name="data">Data to write.</param>
        /// <param name="path">File path to write data to.</param>
        /// <returns>void</returns>
        public static void Write(byte[] data, string path)
        {
            System.IO.File.WriteAllBytes(path, data);
        }

        /// <summary>
        /// Reads all bytes from the given file path.
        /// </summary>
        /// <param name="path">File path to read from.</param>
        /// <returns>Byte array containing data read from file.</returns>
        public static byte[] Read(string path)
        {
            return System.IO.File.ReadAllBytes(path);
        }
    }
}
