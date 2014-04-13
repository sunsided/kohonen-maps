using System.Collections.Generic;
using widemeadows.ml.kohonen.model;

namespace widemeadows.ml.kohonen.net
{
    /// <summary>
    /// Class GridNeuron. This class cannot be inherited.
    /// </summary>
    internal sealed class GridNeuron : IGridNeuron
    {
        /// <summary>
        /// Gets the neuron.
        /// </summary>
        /// <value>The neuron.</value>
        public INeuron Neuron { get; private set; }

        /// <summary>
        /// Gets the grid coordinates.
        /// </summary>
        /// <value>The grid coordinates.</value>
        public IReadOnlyList<double> GridCoordinates { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GridNeuron"/> class.
        /// </summary>
        /// <param name="neuron">The neuron.</param>
        /// <param name="gridCoordinates">The grid coordinates.</param>
        public GridNeuron(INeuron neuron, IReadOnlyList<double> gridCoordinates)
        {
            Neuron = neuron;
            GridCoordinates = gridCoordinates;
        }
    }
}
