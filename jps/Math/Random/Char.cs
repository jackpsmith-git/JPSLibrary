using System.Security.Cryptography;

namespace JPS.Math.Random
{
    /// <summary>
    /// Provides static methods for generating random characters.
    /// </summary>
    public static class Char
    {
        /// <summary>
        /// Generates a random character.
        /// </summary>
        /// <returns>The generated random character.</returns>
        public static char Generate()
        {
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            string pool = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_-+=";
            byte[] chars = new byte[1];
            char character;

            do
            {
                rng.GetBytes(chars);
                character = (char)chars[0];
            } while (!pool.Any(x => x == character));

            return character;
        }
    }
}
