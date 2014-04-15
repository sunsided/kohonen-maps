using System.Collections.Generic;
using Widemeadows.MachineLearning.Kohonen.Model.Neuron;

namespace Widemeadows.MachineLearning.Kohonen.Model.Learning
{
    /// <summary>
    /// Interface IMetric
    /// </summary>
    public interface IMetric
    {
        /// <summary>
        /// Calculates the distance between two weight vectors.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns>System.Double.</returns>
        /// <exception cref="System.ArgumentException">Lengths of weight vectors differ.</exception>
        double CalculateDistance(IWeights a, IWeights b);

        /// <summary>
        /// Calculates the distance between two value vectors.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns>System.Double.</returns>
        /// <exception cref="System.ArgumentException">Lengths of input vectors differ.</exception>
        double CalculateDistance(IReadOnlyList<double> a, IReadOnlyList<double> b);
    }
}
