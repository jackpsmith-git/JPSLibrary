using Jpsmith.Math.Logic;

namespace Jpsmith.Math.Statistics
{
    /// <summary>
    /// Represents a statistical set of floating point values
    /// </summary>
    public abstract class StatisticalSet(float[] values) : Set<float>(values)
    {
        /// <summary>
        /// The sum of the values in the set
        /// </summary>
        public float Sum { get => Values.Sum(); }
        
        /// <summary>
        /// The arithmetic mean of the values in the set
        /// </summary>
        public virtual float Mean { get => Sum / N; }

        public float Min { get => Values.Min(); }
        public float Max { get => Values.Max(); }
        public float Range { get => Max - Min; }

        public float Variance { get => MathF.Pow(StandardDeviation(), 2); }

        /// <summary>
        /// The quantitative amount of variation of the values in the set with respect to the arithmetic mean
        /// </summary>
        /// <returns></returns>
        public abstract float StandardDeviation();
    }
}
