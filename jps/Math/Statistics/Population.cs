namespace Jpsmith.Math.Statistics
{
    /// <summary>
    /// Represents a statistical population set of floating point values
    /// </summary>
    public class Population(float[] values) : StatisticalSet(values)
    {
        public override float StandardDeviation()
        {
            float deviationSum = 0;
            foreach (float value in Values)
            {
                deviationSum += MathF.Pow(value - Mean, 2);
            }

            return MathF.Sqrt(deviationSum / N);
        }
    }
}
