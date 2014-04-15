using System;
using System.ComponentModel.Composition;
using Widemeadows.MachineLearning.Kohonen.Model;
using Widemeadows.MachineLearning.Kohonen.Model.Learning;

namespace Widemeadows.MachineLearning.Kohonen.Learning
{
    /// <summary>
    /// Class MexicanHatNeighborhood. This class cannot be inherited.
    /// </summary>
    [Export(typeof(INeighborhoodFunction))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    [InternalIdMetadata("6628DFF4-240A-437B-8641-4EEF03242BC3", "Mexican Hat", "1.0.0.0")]
    public sealed class MexicanHatNeighborhood : INeighborhoodFunction
    {
        /// <summary>
        /// Calculates the neighborhood factor.
        /// </summary>
        /// <param name="distance">The distance of the neuron to the best matching unit.</param>
        /// <param name="radius">The radius of the neighborhood.</param>
        /// <returns>System.Double.</returns>
        public double CalculateFactor(double distance, double radius)
        {
            var dbyrsquared = (distance*distance)/(radius*radius);
            var a = (1 - dbyrsquared);
            var b = Math.Exp(-dbyrsquared);
            return a * b;
        }
    }
}
