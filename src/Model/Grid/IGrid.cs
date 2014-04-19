using System.Collections.Generic;
using JetBrains.Annotations;
using Widemeadows.MachineLearning.Kohonen.Metrics;
using Widemeadows.MachineLearning.Kohonen.Neuron;

namespace Widemeadows.MachineLearning.Kohonen.Grid
{
    /// <summary>
    /// Interface IGrid
    /// </summary>
    public interface IGrid : IEnumerable<IGridNeuron>
    {
        /// <summary>
        /// Gets number of dimensions.
        /// </summary>
        /// <value>The dimensions.</value>
        int Dimensions { get; }

        /// <summary>
        /// Calculates the distance.
        /// </summary>
        /// <param name="metric">The metric.</param>
        /// <param name="bmu">The bmu.</param>
        /// <param name="gridNeuron">The grid neuron.</param>
        /// <returns>System.Double.</returns>
        double CalculateDistance([NotNull] IMetric metric, [NotNull] IBestMatchingUnit bmu, [NotNull] IGridNeuron gridNeuron);
    }
}