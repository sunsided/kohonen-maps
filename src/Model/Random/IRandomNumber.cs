namespace Widemeadows.MachineLearning.Kohonen.Model.Random
{
    /// <summary>
    /// Interface IRandomNumber
    /// </summary>
    public interface IRandomNumber
    {
        /// <summary>
        /// Sets the seed for the generator.
        /// </summary>
        /// <param name="seed">The seed.</param>
        void SetSeed(long seed);

        /// <summary>
        /// Gets a <see cref="System.Double"/> value in the range of <paramref name="min"/> to <paramref name="max"/>.
        /// </summary>
        /// <param name="min">The minimum value (inclusive).</param>
        /// <param name="max">The maximum value (inclusive).</param>
        /// <returns>System.Double.</returns>
        double GetDouble(double min = 0, double max = 1);
    }
}
