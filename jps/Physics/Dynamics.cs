namespace Jpsmith.Physics;

/// <summary>
/// Static class containing motion functions
/// </summary>
public static class Dynamics
{
    /// <summary>
    /// Earth's gravitational acceleration
    /// </summary>
    public const float g = -9.81f;

    /// <summary>
    /// Gravitational constant
    /// </summary>
    public const float G = 6.67430E-11f;
    
    /// <summary>
    /// Newton's Second Law
    /// </summary>
    /// <param name="m">Mass (kg)</param>
    /// <param name="a">Acceleration (m/s^2)</param>
    /// <returns>Net force (N)</returns>
    public static Vector3f Fnet(float m, Vector3f a) => m * a;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="m1">Mass 1 (kg)</param>
    /// <param name="m2">Mass 2 (kg)</param>
    /// <param name="r">Radius (m)</param>
    /// <returns>Gravitational force (N)</returns>
    public static float Fg(float m1, float m2, float r) => G * m1 * m2 / (r * r);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="v">Velocity (m/s)</param>
    /// <param name="r">Radius (m)</param>
    /// <returns>Centripetal acceleration (m/s^2)</returns>
    public static float Ac(Vector3f v, float r) => (v.Magnitude * v.Magnitude) / r;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="m">Mass (kg)</param>
    /// <param name="Ac">Centripetal acceleration (m/s^2)</param>
    /// <returns>Centripetal force (N)</returns>
    public static Vector3f Fc(float m, Vector3f Ac) => m * Ac;

    /// <summary>
    /// Kepler's Third Law
    /// </summary>
    /// <param name="M">Mass of the central body of the system (kg)</param>
    /// <param name="r">Orbital radius (m)</param>
    /// <returns>Period (s)</returns>
    public static float T(float M, float r) => (4 * MathF.PI * MathF.PI * r * r * r) / (G * M);
}