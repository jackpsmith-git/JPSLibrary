namespace Jpsmith.Math.Statistics
{
    /// <summary>
    /// Represents a statistical sample set of floating point values
    /// </summary>
    public class Sample(float[] values) : StatisticalSet(values)
    {
        public override float StandardDeviation()
        {
            float deviationSum = 0;
            foreach (float value in Values)
            {
                deviationSum += MathF.Pow(value - Mean, 2);
            }

            return MathF.Sqrt(deviationSum / N - 1);
        }
    }
}
