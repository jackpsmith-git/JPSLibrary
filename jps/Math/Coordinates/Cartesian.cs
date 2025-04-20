namespace Jpsmith.Math.Coordinates;

/// <summary>
/// Represents a point in 3d space in cartesian coordinates
/// </summary>
/// <param name="vector"></param>
public class Cartesian(Vector3f vector)
{
    /// <summary>
    /// X-Coordinate
    /// </summary>
    public Vector3f Coordinates { get; set; } = vector;

    /// <summary>
    /// Convert to spherical coordinates
    /// </summary>
    public Spherical ToSpherical()
    {
        return new Spherical(
            MathF.Sqrt(Coordinates.X * Coordinates.X + Coordinates.Y * Coordinates.Y + Coordinates.Z * Coordinates.Z),
            MathF.Atan(Coordinates.Y / Coordinates.X),
            MathF.Acos(Coordinates.Z / MathF.Sqrt(Coordinates.X * Coordinates.X + Coordinates.Y * Coordinates.Y + Coordinates.Z * Coordinates.Z)));
    }
}