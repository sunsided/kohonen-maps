using System;
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
        [Import("TotalIterations", AllowDefault = true)]
        public int TotalIterations { get; set; }

        /// <summary>
        /// The starting learning rate
        /// </summary>
        [Import("StartRadius", AllowDefault = true)]
        public double StartRadius { get; set; }

        /// <summary>
        /// Calculates the radius.
        /// </summary>
        /// <param name="iteration">The iteration.</param>
        /// <returns>System.Double.</returns>
        public double CalculateRadius(int iteration)
        {
            var totalIterations = (double)TotalIterations;
            var radius = StartRadius;

            return radius * Math.Exp(-(double)iteration / totalIterations / Math.Log(radius));
        }
    }
}
