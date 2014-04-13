namespace widemeadows.ml.kohonen.model
{
    /// <summary>
    /// Interface ILearningRate
    /// </summary>
    public interface ILearningRate
    {
        /// <summary>
        /// Calculates the learning rate.
        /// </summary>
        /// <param name="iteration">The iteration.</param>
        /// <returns>System.Double.</returns>
        double CalculateLearningRate(int iteration);
    }
}
