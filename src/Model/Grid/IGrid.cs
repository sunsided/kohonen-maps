using System.Collections.Generic;
using Widemeadows.MachineLearning.Kohonen.Model.Neuron;

namespace Widemeadows.MachineLearning.Kohonen.Model.Grid
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
    }
}