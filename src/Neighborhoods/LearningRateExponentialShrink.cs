using System.ComponentModel.Composition;
using widemeadows.ml.kohonen.model;

namespace widemeadows.ml.kohonen.neighborhoods
{
    /// <summary>
    /// Class ExponentialShrink.
    /// </summary>
    [Export(typeof(ILearningRate))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [IdMetadataAttribute("E2043121-F0B0-4029-93E0-02B066E0B572", "Exponential Shrink", "1.0.0.0")]
    public sealed class LearningRateExponentialShrink : ExponentialShrink, ILearningRate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningRateExponentialShrink"/> class.
        /// </summary>
        /// <param name="totalIterations">The total number of iterations.</param>
        /// <param name="baseRate">The base radius.</param>
        [ImportingConstructor]
        public LearningRateExponentialShrink([Import("TotalIterations")] int totalIterations, [Import("BaseRadius")] double baseRate)
            : base(totalIterations, baseRate)
        {
        }

        /// <summary>
        /// Calculates the learning rate.
        /// </summary>
        /// <param name="iteration">The iteration.</param>
        /// <returns>System.Double.</returns>
        public double CalculateLearningRate(int iteration)
        {
            return Calculate(iteration);
        }
    }
}
