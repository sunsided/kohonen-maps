namespace widemeadows.ml.kohonen.model
{
    /// <summary>
    /// Interface IWeightAdjustment
    /// </summary>
    public interface IWeightAdjustment
    {
        /// <summary>
        /// Calculates the new weights.
        /// </summary>
        /// <param name="iteration">The iteration.</param>
        /// <param name="trainingVector">The training vector.</param>
        /// <param name="currentWeights">The current weights.</param>
        /// <param name="distance">The distance.</param>
        /// <returns>IWeights.</returns>
        IWeights CalculateNewWeights(int iteration, IWeights trainingVector, IWeights currentWeights, double distance);
    }
}
