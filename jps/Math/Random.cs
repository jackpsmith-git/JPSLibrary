using System.Security.Cryptography;
using System.Text;

namespace Jpsmith.Math;

/// <summary>
/// Provides static methods for generating random values
/// </summary>
public static class Random
{
    /// <summary>
    /// Generates a random boolean value.
    /// </summary>
    /// <returns>Generated random boolean.</returns>
    public static bool Bool()
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

    /// <summary>
    /// Generates a random character.
    /// </summary>
    /// <returns>The generated random character.</returns>
    public static char Char()
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

    /// <summary>
    /// Generates a random integer.
    /// </summary>
    /// <returns>The generated random integer.</returns>
    public static int Int() => RandomNumberGenerator.GetInt32(int.MaxValue, int.MaxValue);

    /// <summary>
    /// Generates a random integer between the given boundaries.
    /// </summary>
    /// <param name="upper">The upper boundary.</param>
    /// <param name="lower">The lower boundary.</param>
    /// <returns>The generated random integer.</returns>
    public static int Int(int upper, int lower) => RandomNumberGenerator.GetInt32(lower, upper);

    /// <summary>
    /// Generates a random string of the given length.
    /// </summary>
    /// <param name="length">The length of the string to generate.</param>
    /// <returns>The generated random string.</returns>
    public static string String(int length)
    {
        string pool = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_-+=";
        StringBuilder sb = new();
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