using System.Collections.Generic;

namespace Widemeadows.MachineLearning.Kohonen.Neuron
{
    /// <summary>
    /// Interface IGridNeuron
    /// </summary>
    public interface IGridNeuron
    {
        /// <summary>
        /// Gets the neuron.
        /// </summary>
        /// <value>The neuron.</value>
        INeuron Neuron { get; }

        /// <summary>
        /// Gets the grid coordinates.
        /// </summary>
        /// <value>The grid coordinates.</value>
        IReadOnlyList<double> GridCoordinates { get; }
    }
}
