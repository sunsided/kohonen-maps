using System.Collections.Generic;

namespace widemeadows.ml.kohonen.model
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