using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using Widemeadows.MachineLearning.Kohonen.Model;

namespace Widemeadows.MachineLearning.Kohonen.Learning
{
    /// <summary>
    /// Class ExponentialShrink.
    /// </summary>
    [Export(typeof(IRadiusFunction))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [InternalIdMetadata("075CC788-B067-4BEA-88E0-7E89EEC693EE", "Exponential Decay", "1.0.0.0", IsDefault = true)]
    public sealed class RadiusExponentialShrink : IRadiusFunction
    {
        /// <summary>
        /// The number of total iterations
        /// </summary>
        public int TotalIterations { get; set; }

        /// <summary>
        /// The starting learning rate
        /// </summary>
        public double StartRadius { get; set; }

        /// <summary>
        /// The starting learning rate
        /// </summary>
        public double EndRadius { get; set; }

        /// <summary>
        /// Calculates the radius.
        /// </summary>
        /// <param name="iteration">The iteration.</param>
        /// <returns>System.Double.</returns>
        public double CalculateRadius(int iteration)
        {
            var totalIterations = (double)TotalIterations;
            var startRate = StartRadius;
            var endAmount = EndRadius;
            return startRate * Math.Pow(endAmount / startRate, iteration / totalIterations);
        }
    }
}
