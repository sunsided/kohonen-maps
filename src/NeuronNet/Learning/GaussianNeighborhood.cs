using System;
using System.ComponentModel.Composition;
using Widemeadows.MachineLearning.Kohonen.Model;
using Widemeadows.MachineLearning.Kohonen.Model.Learning;

namespace Widemeadows.MachineLearning.Kohonen.Learning
{
    /// <summary>
    /// Class GaussianNeighborhood. This class cannot be inherited.
    /// </summary>
    [Export(typeof(INeighborhoodFunction))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    [InternalIdMetadata("2114FB74-91EF-47AB-AC8D-AEE5A076746B", "Gaussian", "1.0.0.0", IsDefault = true)]
    public sealed class GaussianNeighborhood : INeighborhoodFunction
    {
        /// <summary>
        /// Calculates the neighborhood factor.
        /// </summary>
        /// <param name="distance">The distance of the neuron to the best matching unit.</param>
        /// <param name="radius">The radius of the neighborhood.</param>
        /// <returns>System.Double.</returns>
        public double CalculateFactor(double distance, double radius)
        {
            return Math.Exp(-(distance * distance) / (radius * radius));
        }
    }
}
