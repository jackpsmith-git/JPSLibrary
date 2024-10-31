namespace Jpsmith.Physics;

/// <summary>
/// Static class containing kinematic functions
/// </summary>
public static class Kinematics
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="Vi">Initial velocity (m/s)</param>
    /// <param name="a">Acceleration (m/s^2)</param>
    /// <param name="t">Time elapsed (s)</param>
    /// <returns>Final velocity (m/s)</returns>
    public static Vector3f Vf(Vector3f Vi, Vector3f a, float t) => Vi + (a * t);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Vi">Initial velocity (m/s)</param>
    /// <param name="Vf">Final velocity (m/s)</param>
    /// <param name="a">Acceleration (m/s^2)</param>
    /// <returns>Time elapsed (s)</returns>
    public static float t(Vector3f Vi, Vector3f Vf, Vector3f a) => ((Vf - Vi) / a.Magnitude()).Magnitude();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Vi"></param>
    /// <param name="a"></param>
    /// <param name="d"></param>
    /// <returns></returns>
    public static float Speed(float Vi, float a, float d) => MathF.Sqrt((Vi * Vi) + (2 * a * d));

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Xf">Final position (m)</param>
    /// <param name="Xi">Initial position (m)</param>
    /// <param name="t">Time elapsed (s)</param>
    /// <returns>Average velocity (m/s)</returns>
    public static Vector3f Vavg(Vector3f Xf, Vector3f Xi, float t) => (Xf - Xi) / t;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Vi">Initial velocity (m/s)</param>
    /// <param name="Vf">Final velocity (m/s)</param>
    /// <returns>Average velocity (m/s)</returns>
    public static Vector3f Vavg(Vector3f Vf, Vector3f Vi) => (Vi + Vf) / 2;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Vf">Final velocity (m/s)</param>
    /// <param name="Vi">Initial velocity (m/s)</param>
    /// <param name="t">Time elapsed (s)</param>
    /// <returns>Average acceleration (m/s^2)</returns>
    public static Vector3f Aavg(Vector3f Vf, Vector3f Vi, float t) => (Vf - Vi) / t;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Xi">Initial position (m)</param>
    /// <param name="Vavg">Average velocity (m/s)</param>
    /// <param name="t">Time elapsed (s)</param>
    /// <returns>Final position (m)</returns>
    public static Vector3f Xf(Vector3f Xi, Vector3f Vavg, float t) => Xi + (t * Vavg);
}