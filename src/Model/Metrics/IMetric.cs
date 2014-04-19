using System.Collections.Generic;
using JetBrains.Annotations;
using Widemeadows.MachineLearning.Kohonen.Neuron;

namespace Widemeadows.MachineLearning.Kohonen.Metrics
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
        double CalculateDistance([NotNull] IWeights a, [NotNull] IWeights b);

        /// <summary>
        /// Calculates the distance between two value vectors.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns>System.Double.</returns>
        /// <exception cref="System.ArgumentException">Lengths of input vectors differ.</exception>
        double CalculateDistance([NotNull] IReadOnlyList<double> a, [NotNull] IReadOnlyList<double> b);
    }
}
