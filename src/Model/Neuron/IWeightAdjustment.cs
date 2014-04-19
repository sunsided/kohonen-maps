using JetBrains.Annotations;

namespace Widemeadows.MachineLearning.Kohonen.Neuron
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
        [NotNull]
        IWeights CalculateNewWeights(int iteration, [NotNull] IWeights trainingVector, [NotNull] IWeights currentWeights, double distance);
    }
}
