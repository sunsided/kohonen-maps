namespace widemeadows.ml.kohonen.model
{
    /// <summary>
    /// Interface IMetric
    /// </summary>
    public interface IMetric
    {
        /// <summary>
        /// Calculates the distance between two weight vectors.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns>System.Double.</returns>
        /// <exception cref="System.ArgumentException">Lengths of weight vectors differ.</exception>
        double Distance(IWeights a, IWeights b);
    }
}
