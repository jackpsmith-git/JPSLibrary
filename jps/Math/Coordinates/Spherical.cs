namespace Jpsmith.Math.Coordinates
{
    /// <summary>
    /// Represents a point in 3d space in spherical coordinates
    /// </summary>
    /// <param name="r">Radius</param>
    /// <param name="i">Inclination (Polar angle)</param>
    /// <param name="a">Azimuth (Azimuthal angle)</param>
    public class Spherical(float r, float i, float a)
    {
        public float Radius { get; set; } = r;
        public float Inclination { get; set; } = i;
        public float Azimuth { get; set; } = a;

        /// <summary>
        /// Convert to cartesian coordinates
        /// </summary>
        public Cartesian ToCartesian()
        {
            return new Cartesian(
                new Vector3f(Radius * MathF.Sin(Azimuth) * MathF.Cos(Inclination),
                Radius * MathF.Sin(Azimuth) * MathF.Cos(Azimuth),
                Radius * MathF.Cos(Azimuth)));
        }
    }
}
