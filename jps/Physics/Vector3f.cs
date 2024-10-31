namespace Jpsmith.Physics;

/// <summary>
/// Represents a 3-dimensional floating point vector
/// </summary>
/// <param name="x"></param>
/// <param name="y"></param>
/// <param name="z"></param>
public class Vector3f(float x, float y, float z)
{
    /// <summary>
    /// X-component
    /// </summary>
    float X => x;

    /// <summary>
    /// Y-component
    /// </summary>
    float Y => y;

    /// <summary>
    /// Z-component
    /// </summary>
    float Z => z;

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
    /// <returns>Normalized 3-dimensional floating point vector</returns>
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
    public static float DotProduct(Vector3f a, Vector3f b) => (a.X * b.X) + (a.Y * b.Y) + (a.Z * b.Z);

    /// <summary>
    /// Dot Product
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="angle">Angle in degrees between a and b</param>
    /// <returns>a * b</returns>
    public static float DotProduct(Vector3f a, Vector3f b, float angle) => a.Magnitude() * b.Magnitude() * MathF.Cos(angle);

    /// <summary>
    /// Gets the angle between two vectors
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>Angle in degrees between a and b</returns>
    public static float Angle(Vector3f a, Vector3f b) => MathF.Acos(DotProduct(a, b) / (a.Magnitude() * b.Magnitude()));

    /// <summary>
    /// Cross Product
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a X b</returns>
    public static Vector3f CrossProduct(Vector3f a, Vector3f b) => new(
        (a.Y * b.Z) - (a.Z * b.Y), 
        (a.Z * b.X) - (a.X * b.Z), 
        (a.X * b.Y) - (a.Y * b.X));

    /// <summary>
    /// Addition operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a + b</returns>
    public static Vector3f operator +(Vector3f a, Vector3f b) => new(
        a.X + b.X, 
        a.Y + b.Y, 
        a.Z + b.Z);

    /// <summary>
    /// Negation operator
    /// </summary>
    /// <param name="a"></param>
    /// <returns>-a</returns>
    public static Vector3f operator -(Vector3f a) => new(-a.X, -a.Y, -a.Z);

    /// <summary>
    /// Subtraction operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a - b</returns>
    public static Vector3f operator -(Vector3f a, Vector3f b) => new(
        a.X - b.X, 
        a.Y - b.Y, 
        a.Z - b.Z);

    /// <summary>
    /// Multiplication operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a * b</returns>
    public static Vector3f operator *(float a, Vector3f b) => new(
        a * b.X, 
        a * b.Y, 
        a * b.Z);

    /// <summary>
    /// Multiplication operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a * b</returns>
    public static Vector3f operator *(Vector3f a, float b) => new(
        a.X * b, 
        a.Y * b, 
        a.Z * b);

    /// <summary>
    /// Multiplication operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a * b</returns>
    public static Vector3f operator *(int a, Vector3f b) => new(
        a * b.X, 
        a * b.Y, 
        a * b.Z);

    /// <summary>
    /// Multiplication operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a * b</returns>
    public static Vector3f operator *(Vector3f a, int b) => new(
        a.X * b, 
        a.Y * b, 
        a.Z * b);

    /// <summary>
    /// Dot product operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a * b</returns>
    public static float operator *(Vector3f a, Vector3f b) => DotProduct(a, b);

    /// <summary>
    /// Division operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a / b</returns>
    public static Vector3f operator /(Vector3f a, float b) => new(
        a.X / b, 
        a.Y / b, 
        a.Z / b);

    /// <summary>
    /// Division operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a / b</returns>
    public static Vector3f operator /(Vector3f a, int b) => new(
        a.X / b, 
        a.Y / b, 
        a.Z / b);
}