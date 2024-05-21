using System.Security.Cryptography;

namespace JPS.Math.Random
{
    /// <summary>
    /// Provides static methods for generating random booleans.
    /// </summary>
    public static class Bool
    {
        /// <summary>
        /// Generates a random boolean value.
        /// </summary>
        /// <returns>Generated random boolean.</returns>
        public static bool Generate()
        {
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            string pool = "01";
            byte[] chars = new byte[1];
            char character;

            do
            {
                rng.GetBytes(chars);
                character = (char)chars[0];
            } while (!pool.Any(x => x == character));

            if (character == '0')
            {
                return false;
            } 
            else
            {
                return true;
            }
        }
    }
}
