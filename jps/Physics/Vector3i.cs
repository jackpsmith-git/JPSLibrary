namespace Jpsmith.Physics;

/// <summary>
/// Represents a 3-dimensional integer vector
/// </summary>
/// <param name="x"></param>
/// <param name="y"></param>
/// <param name="z"></param>
public class Vector3i(int x, int y, int z)
{
    int X => x;
    int Y => y;
    int Z => z;

    public float Magnitude => MathF.Sqrt(
        MathF.Pow(X, 2) +
        MathF.Pow(Y, 2) +
        MathF.Pow(Z, 2));

    /// <summary>
    /// Sets the magnitude of the vector to 1 while maintaining the same direction
    /// </summary>
    /// <returns>Normalized 3-dimensional floating point vector</returns>
    public Vector3f Normalize()
    {
        float magnitude = Magnitude;
        return new(
            X / magnitude,
            Y / magnitude,
            Z / magnitude);
    }

    public static float DotProduct(Vector3i a, Vector3i b) => (a.X * b.X) + (a.Y * b.Y) + (a.Z * b.Z);
    public static float DotProduct(Vector3i a, Vector3i b, float angle) => a.Magnitude * b.Magnitude * MathF.Cos(angle);
    public static float Angle(Vector3i a, Vector3i b) => MathF.Acos(DotProduct(a, b) / (a.Magnitude * b.Magnitude));

    public static Vector3i CrossProduct(Vector3i a, Vector3i b) => new(
        (a.Y * b.Z) - (a.Z * b.Y),
        (a.Z * b.X) - (a.X * b.Z),
        (a.X * b.Y) - (a.Y * b.X));

    public static Vector3i operator +(Vector3i a, Vector3i b) => new(
        a.X + b.X, 
        a.Y + b.Y, 
        a.Z + b.Z);

    public static Vector3i operator -(Vector3i a) => new(-a.X, -a.Y, -a.Z);

    public static Vector3i operator -(Vector3i a, Vector3i b) => new(
        a.X - b.X, 
        a.Y - b.Y, 
        a.Z - b.Z);

    public static Vector3f operator *(float a, Vector3i b) => new(a * b.X, a * b.Y, a * b.Z);
    public static Vector3f operator *(Vector3i a, float b) => new(a.X * b, a.Y * b, a.Z * b);

    public static Vector3i operator *(int a, Vector3i b) => new(a * b.X, a * b.Y, a * b.Z);
    public static Vector3i operator *(Vector3i a, int b) => new(a.X * b, a.Y * b, a.Z * b);
    public static float operator *(Vector3i a, Vector3i b) => DotProduct(a, b);

    public static Vector3f operator /(Vector3i a, float b) => new(a.X / b, a.Y / b, a.Z / b);
    public static Vector3i operator /(Vector3i a, int b) => new(a.X / b, a.Y / b, a.Z / b);
}