using System.Text;
using sysFile = System.IO.File;

namespace Jpsmith.Data;

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
    public static void Write(byte[] data, string path) => sysFile.WriteAllBytes(path, data);

    /// <summary>
    /// Writes the given data to the given file path.
    /// </summary>
    /// <param name="data">Data to write.</param>
    /// <param name="path">File path to write data to.</param>
    /// <returns>void</returns>
    public static void Write(string data, string path) => sysFile.WriteAllText(path, data);

    /// <summary>
    /// Writes the given data to the given file path.
    /// </summary>
    /// <param name="data">Data to write.</param>
    /// <param name="path">File path to write data to.</param>
    /// <param name="encoding">Character encoding format</param>
    /// <returns>void</returns>
    public static void Write(string data, string path, System.Text.Encoding encoding) => sysFile.WriteAllText(path, data, encoding);

    /// <summary>
    /// Writes the given data to the given file path.
    /// </summary>
    /// <param name="data">Data to write.</param>
    /// <param name="path">File path to write data to.</param>
    /// <returns>void</returns>
    public static async void WriteAsync(byte[] data, string path) => await sysFile.WriteAllBytesAsync(path, data);

    /// <summary>
    /// Writes the given data to the given file path.
    /// </summary>
    /// <param name="data">Data to write.</param>
    /// <param name="path">File path to write data to.</param>
    /// <param name="encoding">Character encoding format</param>
    /// <returns>void</returns>
    public static async void WriteAsync(string data, string path, System.Text.Encoding encoding) => await sysFile.WriteAllTextAsync(path, data, encoding);

    /// <summary>
    /// Writes the given data to the given file path.
    /// </summary>
    /// <param name="data">Data to write.</param>
    /// <param name="path">File path to write data to.</param>
    /// <returns>void</returns>
    public static async void WriteAsync(string data, string path) => await sysFile.WriteAllTextAsync(path, data);

    /// <summary>
    /// Reads all bytes from the given file path.
    /// </summary>
    /// <param name="path">File path to read from.</param>
    /// <returns>Byte array containing data read from file.</returns>
    public static byte[] Read(string path) => sysFile.ReadAllBytes(path);
}
