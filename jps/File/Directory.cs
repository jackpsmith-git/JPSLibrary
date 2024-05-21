namespace JPS.File
{
    /// <summary>
    /// Provides static methods relating to directories and file paths.
    /// </summary>
    public static class Directory
    {
        /// <summary>
        /// Creates an instance of the DirectoryInfo class for the given file path.
        /// </summary>
        /// <param name="path">Path to generate DirectoryInfo for.</param>
        /// <returns>Directoryinfo for the given file path.</returns>
        public static DirectoryInfo GetDirectoryInfo(string path)
        {
            DirectoryInfo di = new(path);
            return di;
        }

        /// <summary>
        /// Creates an instance of the FileInfo class for the given file path.
        /// </summary>
        /// <param name="path">Path to generate FileInfo for.</param>
        /// <returns>Fileinfo for the given file path.</returns>
        public static FileInfo GetFileInfo(string path)
        {
            FileInfo fi = new FileInfo(path);
            return fi;
        }

        /// <summary>
        /// Creates an instance of the FileAttributes class for the given file path.
        /// </summary>
        /// <param name="path">Path to generate FileAttributes for.</param>
        /// <returns>FileAttributes for the given file path.</returns>
        public static FileAttributes GetFileAttributes(string path)
        {
            return System.IO.File.GetAttributes(path);
        }

        /// <summary>
        /// Deletes all files and directories in the given file path.
        /// </summary>
        /// <param name="path">The directory to clear.</param>
        /// <returns>void</returns>
        public static void Clear(DirectoryInfo di)
        {
            foreach (DirectoryInfo dichild in di.EnumerateDirectories())
            {
                Clear(dichild);
                di.Delete();
            }
            foreach (FileInfo fi in di.GetFiles())
            {
                fi.Delete();
            }
        }

        /// <summary>
        /// Hides the given directory.
        /// </summary>
        /// <param name="di">The directory to hide.</param>
        /// <returns>void</returns>
        public static void Hide(DirectoryInfo di)
        {
            di.Attributes = FileAttributes.Hidden;
        }

        /// <summary>
        /// Gets whether the given file path exists.
        /// </summary>
        /// <param name="path">The file path to check.</param>
        /// <returns>true if the file path exists, otherwise false</returns>
        public static bool Exists(string path)
        {
            return Path.Exists(path);
        }

        /// <summary>
        /// Gets whether the give file path is a directory or a file.
        /// </summary>
        /// <param name="fa">The file path to check.</param>
        /// <returns>true if the file path is a directory, false if the file path is a file</returns>
        public static bool IsDirectory(FileAttributes fa)
        {
            return fa.HasFlag(FileAttributes.Directory);
        }
    }
}
