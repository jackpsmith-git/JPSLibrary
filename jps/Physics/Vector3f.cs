namespace Jpsmith.Physics;

/// <summary>
/// Represents a 3-dimensional floating point vector
/// </summary>
/// <param name="x"></param>
/// <param name="y"></param>
/// <param name="z"></param>
public class Vector3f(float x, float y, float z)
{
    float X => x;
    float Y => y;
    float Z => z;

    public float Magnitude => MathF.Sqrt(
        MathF.Pow(X, 2) +
        MathF.Pow(Y, 2) +
        MathF.Pow(Z, 2));

    public Vector3f Normalize()
    {
        float magnitude = Magnitude;
        return new(
            X / magnitude,
            Y / magnitude,
            Z / magnitude);
    }

    public static float DotProduct(Vector3f a, Vector3f b) => (a.X * b.X) + (a.Y * b.Y) + (a.Z * b.Z);
    public static float DotProduct(Vector3f a, Vector3f b, float angle) => a.Magnitude * b.Magnitude * MathF.Cos(angle);
    public static float Angle(Vector3f a, Vector3f b) => MathF.Acos(DotProduct(a, b) / (a.Magnitude * b.Magnitude));

    public static Vector3f CrossProduct(Vector3f a, Vector3f b) => new(
        (a.Y * b.Z) - (a.Z * b.Y), 
        (a.Z * b.X) - (a.X * b.Z), 
        (a.X * b.Y) - (a.Y * b.X));

    public static Vector3f operator +(Vector3f a, Vector3f b) => new(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    public static Vector3f operator -(Vector3f a) => new(-a.X, -a.Y, -a.Z);
    public static Vector3f operator -(Vector3f a, Vector3f b) => new(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

    public static Vector3f operator *(float a, Vector3f b) => new(a * b.X, a * b.Y, a * b.Z);
    public static Vector3f operator *(Vector3f a, float b) => new(a.X * b, a.Y * b, a.Z * b);
    public static Vector3f operator *(int a, Vector3f b) => new(a * b.X, a * b.Y, a * b.Z);
    public static Vector3f operator *(Vector3f a, int b) => new(a.X * b, a.Y * b, a.Z * b);
    public static float operator *(Vector3f a, Vector3f b) => DotProduct(a, b);

    public static Vector3f operator /(Vector3f a, float b) => new(a.X / b, a.Y / b, a.Z / b);
    public static Vector3f operator /(Vector3f a, int b) => new(a.X / b, a.Y / b, a.Z / b);
}