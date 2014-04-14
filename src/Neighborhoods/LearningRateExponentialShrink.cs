using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using widemeadows.ml.kohonen.model;

namespace widemeadows.ml.kohonen.neighborhoods
{
    /// <summary>
    /// Class ExponentialShrink.
    /// </summary>
    [Export(typeof(ILearningRate))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [IdMetadataAttribute("E2043121-F0B0-4029-93E0-02B066E0B572", "Exponential Decay", "1.0.0.0")]
    public sealed class LearningRateExponentialShrink : ILearningRate
    {
        /// <summary>
        /// The default learning rate
        /// </summary>
        private const double DefaultEndLearningRate = 0.01;

        /// <summary>
        /// The number of total iterations
        /// </summary>
        [Import("TotalIterations", AllowDefault = true)]
        public int TotalIterations { get; set; }

        /// <summary>
        /// The starting learning rate
        /// </summary>
        [Import("StartRate", AllowDefault = true)]
        public double StartRate { get; set; }

        /// <summary>
        /// The end learning rate
        /// </summary>
        [DefaultValue(DefaultEndLearningRate)]
        [Import("EndRate", AllowDefault = true)]
        public double EndRate { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningRateExponentialShrink"/> class.
        /// </summary>
        public LearningRateExponentialShrink()
        {
            EndRate = DefaultEndLearningRate;
        }

        /// <summary>
        /// Calculates the learning rate.
        /// </summary>
        /// <param name="iteration">The iteration.</param>
        /// <returns>System.Double.</returns>
        public double CalculateLearningRate(int iteration)
        {
            var startRate = StartRate;
            var endAmount = EndRate;
            return startRate * Math.Pow(endAmount / startRate, iteration / (double)TotalIterations);
        }
    }
}
