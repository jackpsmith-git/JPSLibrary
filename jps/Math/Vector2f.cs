namespace Jpsmith.Math;

/// <summary>
/// Represents a 2-dimensional floating point vector
/// </summary>
/// <param name="x"></param>
/// <param name="y"></param>
public class Vector2f(float x, float y)
{
    /// <summary>
    /// X-component
    /// </summary>
    public float X { get; set; } = x;

    /// <summary>
    /// Y-component
    /// </summary>
    public float Y { get; set; } = y;

    /// <summary>
    /// Gets the length of the vector
    /// </summary>
    /// <returns></returns>
    public float Magnitude => MathF.Sqrt(MathF.Pow(X, 2) + MathF.Pow(Y, 2));

    /// <summary>
    /// Sets the magnitude of the vector to 1 while maintaining the same direction
    /// </summary>
    /// <returns>Normalized 3-dimensional floating point vector</returns>
    public Vector2f Normalize()
    {
        float magnitude = Magnitude;
        return new(
            X / magnitude,
            Y / magnitude);
    }

    /// <summary>
    /// Dot Product
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a * b</returns>
    public static float DotProduct(Vector2f a, Vector2f b) => a.X * b.X + a.Y * b.Y;

    /// <summary>
    /// Dot Product
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="angle">Angle in degrees between a and b</param>
    /// <returns>a * b</returns>
    public static float DotProduct(Vector2f a, Vector2f b, float angle) => a.Magnitude * b.Magnitude * MathF.Cos(angle);

    /// <summary>
    /// Gets the angle between two vectors
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>Angle in degrees between a and b</returns>
    public static float Angle(Vector2f a, Vector2f b) => MathF.Acos(DotProduct(a, b) / (a.Magnitude * b.Magnitude));

    /// <summary>
    /// Addition operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a + b</returns>
    public static Vector2f operator +(Vector2f a, Vector2f b) => new(
        a.X + b.X,
        a.Y + b.Y);

    /// <summary>
    /// Negation operator
    /// </summary>
    /// <param name="a"></param>
    /// <returns>-a</returns>
    public static Vector2f operator -(Vector2f a) => new(-a.X, -a.Y);

    /// <summary>
    /// Difference operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a - b</returns>
    public static Vector2f operator -(Vector2f a, Vector2f b) => new(
        a.X - b.X,
        a.Y - b.Y);

    /// <summary>
    /// CartesianProduct operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a * b</returns>
    public static Vector2f operator *(float a, Vector2f b) => new(
        a * b.X,
        a * b.Y);

    /// <summary>
    /// CartesianProduct operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a * b</returns>
    public static Vector2f operator *(Vector2f a, float b) => new(
        a.X * b,
        a.Y * b);

    /// <summary>
    /// CartesianProduct operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a * b</returns>
    public static Vector2f operator *(int a, Vector2f b) => new(
        a * b.X,
        a * b.Y);

    /// <summary>
    /// CartesianProduct operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a * b</returns>
    public static Vector2f operator *(Vector2f a, int b) => new(
        a.X * b,
        a.Y * b);

    /// <summary>
    /// Dot product operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a * b</returns>
    public static float operator *(Vector2f a, Vector2f b) => DotProduct(a, b);

    /// <summary>
    /// Division operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a / b</returns>
    public static Vector2f operator /(Vector2f a, float b) => new(
        a.X / b,
        a.Y / b);

    /// <summary>
    /// Division operator
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a / b</returns>
    public static Vector2f operator /(Vector2f a, int b) => new(
        a.X / b,
        a.Y / b);
}