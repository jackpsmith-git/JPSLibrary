using System.Security.Cryptography;

namespace JPS.Math.Random
{
    /// <summary>
    /// Provides static methods for generating random integers.
    /// </summary>
    public static class Int
    {
        /// <summary>
        /// Generates a random integer.
        /// </summary>
        /// <returns>The generated random integer.</returns>
        public static int Generate()
        {
            return RandomNumberGenerator.GetInt32(int.MaxValue, int.MaxValue);
        }

        /// <summary>
        /// Generates a random integer between the given boundaries.
        /// </summary>
        /// <param name="upper">The upper boundary.</param>
        /// <param name="lower">The lower boundary.</param>
        /// <returns>The generated random integer.</returns>
        public static int Generate(int upper, int lower)
        {
            return RandomNumberGenerator.GetInt32(int.MaxValue, int.MaxValue);
        }

    }
}
