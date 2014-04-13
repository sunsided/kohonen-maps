namespace widemeadows.ml.kohonen.model
{
    /// <summary>
    /// Interface IMetric
    /// </summary>
    interface IMetric
    {
        /// <summary>
        /// Distances the specified neuron.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns>System.Double.</returns>
        double Distance(IWeights a, IWeights b);
    }
}
