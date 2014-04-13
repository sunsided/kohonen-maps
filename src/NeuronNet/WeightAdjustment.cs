using widemeadows.ml.kohonen.model;

namespace widemeadows.ml.kohonen.net
{
    /// <summary>
    /// Class WeightAdjustment. This class cannot be inherited.
    /// </summary>
    public sealed class WeightAdjustment : IWeightAdjustment
    {
        /// <summary>
        /// The radius function
        /// </summary>
        private readonly IRadiusFunction _radiusFunction;

        /// <summary>
        /// The neighborhood function
        /// </summary>
        private readonly INeighborhoodFunction _neighboorFunction;

        /// <summary>
        /// The learning rate function
        /// </summary>
        private readonly ILearningRate _learningRate;

        /// <summary>
        /// Initializes a new instance of the <see cref="WeightAdjustment"/> class.
        /// </summary>
        /// <param name="radiusFunction">The radius function.</param>
        /// <param name="neighboorFunction">The neighboor function.</param>
        /// <param name="learningRate">The learning rate.</param>
        public WeightAdjustment(IRadiusFunction radiusFunction, INeighborhoodFunction neighboorFunction, ILearningRate learningRate)
        {
            _radiusFunction = radiusFunction;
            _neighboorFunction = neighboorFunction;
            _learningRate = learningRate;
        }

        /// <summary>
        /// Calculates the new weights.
        /// </summary>
        /// <param name="iteration">The iteration.</param>
        /// <param name="trainingVector">The training vector.</param>
        /// <param name="currentWeights">The current weights.</param>
        /// <param name="distance">The distance.</param>
        /// <returns>IWeights.</returns>
        public IWeights CalculateNewWeights(int iteration, IWeights trainingVector, IWeights currentWeights, double distance)
        {
            var radius = _radiusFunction.CalculateRadius(iteration);
            var h = _neighboorFunction.CalculateFactor(distance, radius);
            var epsilon = _learningRate.CalculateLearningRate(iteration);
            var factor = h*epsilon;

            // Ritter et al. (1991)

            // calculate V(t)-W(t)
            var delta = trainingVector.Subtract(currentWeights);

            // calculate W(t) + N(t)*L(t) * (V(t)-W(t))
            var weights = new WeightVector(currentWeights);
            return weights.AddScaledInPlace(delta, factor);
        }
    }
}
