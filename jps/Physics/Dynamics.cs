namespace Jpsmith.Physics;

/// <summary>
/// Static class containing motion functions
/// </summary>
public static class Dynamics
{
    /// <summary>
    /// Earth's gravitational acceleration (m/s)
    /// </summary>
    public const float g = -9.81f;

    /// <summary>
    /// Gravitational constant
    /// </summary>
    public const float G = 6.67430E-11f;

    /// <summary>
    /// Round-trip speed of light (m/s)
    /// </summary>
    public const int c = 299792458;

    /// <summary>
    /// Planck constant (J-s)
    /// </summary>
    public const float h = 6.62607015E-34f;
    
    /// <summary>
    /// Newton's Second Law
    /// </summary>
    /// <param name="m">Mass (kg)</param>
    /// <param name="a">Acceleration (m/s^2)</param>
    /// <returns>Net force (N)</returns>
    public static Vector3f NewtonsSecondLaw(float m, Vector3f a) => m * a;

    /// <summary>
    /// Gravitational Force Formula
    /// </summary>
    /// <param name="m1">Mass 1 (kg)</param>
    /// <param name="m2">Mass 2 (kg)</param>
    /// <param name="r">Radius (m)</param>
    /// <returns>Gravitational force (N)</returns>
    public static float LawOfUniversalGravitation(float m1, float m2, float r) => G * m1 * m2 / (r * r);

    /// <summary>
    /// Centripetal Acceleration Formula
    /// </summary>
    /// <param name="v">Velocity (m/s)</param>
    /// <param name="r">Radius (m)</param>
    /// <returns>Centripetal acceleration (m/s^2)</returns>
    public static float CentripetalAcceleration(Vector3f v, float r) => (v.Magnitude() * v.Magnitude()) / r;

    /// <summary>
    /// Centripetal Force Formula
    /// </summary>
    /// <param name="m">Mass (kg)</param>
    /// <param name="Ac">Centripetal acceleration (m/s^2)</param>
    /// <returns>Centripetal force (N)</returns>
    public static Vector3f CentripetalForce(float m, Vector3f Ac) => m * Ac;

    /// <summary>
    /// Kepler's Third Law
    /// </summary>
    /// <param name="M">Mass of the central body of the system (kg)</param>
    /// <param name="r">Orbital radius (m)</param>
    /// <returns>Period (s)</returns>
    public static float KeplersThirdLaw(float M, float r) => (4 * MathF.PI * MathF.PI * r * r * r) / (G * M);

    /// <summary>
    /// Momentum Formula
    /// </summary>
    /// <param name="m">Mass (kg)</param>
    /// <param name="v">Velocity (m/s)</param>
    /// <returns>Momentum (kg * m/s)</returns>
    public static Vector3f Momentum(float m, Vector3f v) => m * v;

    /// <summary>
    /// Impulse Formula
    /// </summary>
    /// <param name="F">Force (N)</param>
    /// <param name="ti">Initial time (s)</param>
    /// <param name="tf">Final time (s)</param>
    /// <returns>Impulse (kg * m/s)</returns>
    public static Vector3f Impulse(Vector3f F, float ti, float tf) => F * (tf - ti);

    /// <summary>
    /// Work Formula
    /// </summary>
    /// <param name="F">Force (N)</param>
    /// <param name="s">Displacement (m)</param>
    /// <returns>Work (J)</returns>
    public static float Work(Vector3f F, Vector3f s) => F * s;

    /// <summary>
    /// Work-Energy Theorem
    /// </summary>
    /// <param name="Ki">Initial kinetic energy (J)</param>
    /// <param name="Kf">Final kinetic energy (J)</param>
    /// <returns>Net work (J)</returns>
    public static float NetWork(float Ki, float Kf) => Kf - Ki;

    /// <summary>
    /// Kinetic energy formula
    /// </summary>
    /// <param name="m">Mass (kg)</param>
    /// <param name="v">Velocity (m/s)</param>
    /// <returns>Kinetic energy (J)</returns>
    public static float KineticEnergy(float m, float v) => (m * v * v) / 2;

    /// <summary>
    /// Gravitational potential energy formula
    /// </summary>
    /// <param name="m">Mass (kg)</param>
    /// <param name="g">Gravitational acceleration (m/s^2)</param>
    /// <param name="h">Height (m)</param>
    /// <returns>Gravitational potential energy (J)</returns>
    public static float GravitationalPotentialEnergy(float m, float g, float h) => m * g * h;

    /// <summary>
    /// Elastic potential energy formula
    /// </summary>
    /// <param name="k">Spring constant (N/m)</param>
    /// <param name="x">Displacement (m)</param>
    /// <returns>Elastic potential energy (J)</returns>
    public static float ElasticPotentialEnergy(float k, float x) => (k * x * x) / 2;

    /// <summary>
    /// Hooke's Law
    /// </summary>
    /// <param name="k">Spring constant (N/m)</param>
    /// <param name="x">Displacement (m)</param>
    /// <returns>Force (N)</returns>
    public static float HookesLaw(float k, float x) => k * x;

    /// <summary>
    /// Theory of Relativity
    /// </summary>
    /// <param name="m">Mass (kg)</param>
    /// <returns>Energy (J)</returns>
    public static float TheoryOfRelativity(float m) => m * c * c;

    /// <summary>
    /// Planck-Einstein Relation
    /// </summary>
    /// <param name="f"></param>
    /// <returns></returns>
    public static float PlanckRelation(float f) => h * f;
}