namespace Jpsmith.Physics;

/// <summary>
/// Represents a 3-dimensional integer vector
/// </summary>
/// <param name="x"></param>
/// <param name="y"></param>
/// <param name="z"></param>
public class Vector3i(int x, int y, int z)
{
    /// <summary>
    /// X-component
    /// </summary>
    int X => x;

    /// <summary>
    /// Y-component
    /// </summary>
    int Y => y;

    /// <summary>
    /// Z-component
    /// </summary>
    int Z => z;

    /// <summary>
    /// Gets the length of the vector
    /// </summary>
    /// <returns></returns>
    public float Magnitude() => MathF.Sqrt(
        MathF.Pow(X, 2) +
        MathF.Pow(Y, 2) +
        MathF.Pow(Z, 2));

    /// <summary>
    /// Sets the magnitude of the vector to 1 while maintaining the same direction
    /// </summary>
    /// <returns>Normalized 3-dimensional integer vector</returns>
    public Vector3f Normalize()
    {
        float magnitude = Magnitude();
        return new(
            X / magnitude,
            Y / magnitude,
            Z / magnitude);
    }

    /// <summary>
    /// Dot Product
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a * b</returns>
    public static float DotProduct(Vector3i a, Vector3i b) => (a.X * b.X) + (a.Y * b.Y) + (a.Z * b.Z);

    /// <summary>
    /// Dot Product
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="angle">Angle in degrees between a and b</param>
    /// <returns>a * b</returns>
    public static float DotProduct(Vector3i a, Vector3i b, float angle) => a.Magnitude() * b.Magnitude() * MathF.Cos(angle);

    /// <summary>
    /// Gets the angle between two vectors
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>Angle in degrees between a and b</returns>
    public static float Angle(Vector3i a, Vector3i b) => MathF.Acos(DotProduct(a, b) / (a.Magnitude() * b.Magnitude()));

    /// <summary>
    /// Cross Product
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a X b</returns>
    public static Vector3i CrossProduct(Vector3i a, Vector3i b) => new(
        (a.Y * b.Z) - (a.Z * b.Y),
        (a.Z * b.X) - (a.X * b.Z),
        (a.X * b.Y) - (a.Y * b.X));

    /// <summary>
    /// Addition operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a + b</returns>
    public static Vector3i operator +(Vector3i a, Vector3i b) => new(
        a.X + b.X, 
        a.Y + b.Y, 
        a.Z + b.Z);

    /// <summary>
    /// Negation operator
    /// </summary>
    /// <param name="a"></param>
    /// <returns>-a</returns>
    public static Vector3i operator -(Vector3i a) => new(-a.X, -a.Y, -a.Z);

    /// <summary>
    /// Subtraction operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a - b</returns>
    public static Vector3i operator -(Vector3i a, Vector3i b) => new(
        a.X - b.X, 
        a.Y - b.Y, 
        a.Z - b.Z);

    /// <summary>
    /// Multiplication operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a * b</returns>
    public static Vector3f operator *(float a, Vector3i b) => new(a * b.X, a * b.Y, a * b.Z);

    /// <summary>
    /// Multiplication operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a * b</returns>
    public static Vector3f operator *(Vector3i a, float b) => new(a.X * b, a.Y * b, a.Z * b);

    /// <summary>
    /// Multiplication operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a * b</returns>
    public static Vector3i operator *(int a, Vector3i b) => new(a * b.X, a * b.Y, a * b.Z);

    /// <summary>
    /// Multiplication operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a * b</returns>
    public static Vector3i operator *(Vector3i a, int b) => new(a.X * b, a.Y * b, a.Z * b);

    /// <summary>
    /// Dot product operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a * b</returns>
    public static float operator *(Vector3i a, Vector3i b) => DotProduct(a, b);

    /// <summary>
    /// Division operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a / b</returns>
    public static Vector3f operator /(Vector3i a, float b) => new(a.X / b, a.Y / b, a.Z / b);

    /// <summary>
    /// Division operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a / b</returns>
    public static Vector3i operator /(Vector3i a, int b) => new(a.X / b, a.Y / b, a.Z / b);
}