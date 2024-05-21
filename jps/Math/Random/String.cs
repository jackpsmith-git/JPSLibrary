using System.Security.Cryptography;
using System.Text;

namespace JPS.Math.Random
{
    /// <summary>
    /// Provides static methods for generating random strings.
    /// </summary>
    public static class String
    {
        /// <summary>
        /// Generates a random string of the given length.
        /// </summary>
        /// <param name="length">The length of the string to generate.</param>
        /// <returns>The generated random string.</returns>
        public static string Generate(int length)
        {
            string pool = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_-+=";
            StringBuilder sb = new StringBuilder();
            RandomNumberGenerator rng = RandomNumberGenerator.Create();

            for (int i = 0; i < length; i++)
            {
                byte[] chars = new byte[1];
                char character;

                do
                {
                    rng.GetBytes(chars);
                    character = (char)chars[0];
                } while (!pool.Any(x => x == character));

                sb = sb.Append(character);
            }

            return sb.ToString();
        }
    }
}
