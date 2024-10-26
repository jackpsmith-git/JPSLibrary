namespace Jpsmith.Math.Algorithm;

/// <summary>
/// Contains static methods for performing string manipulation
/// </summary>
public static class String
{
    /// <summary>
    /// Reverses the characters in the given string
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static string Reverse(string s)
    {
        string result = string.Empty;
        int length = s.Length - 1;

        while (length >= 0)
        {
            result += s[length];
            length--;
        }

        return result;
    }
}