using System.Collections.Generic;

namespace widemeadows.ml.kohonen.model
{
    /// <summary>
    /// Interface IBestMatchingUnit
    /// </summary>
    public interface IBestMatchingUnit : IGridNeuron
    {
        /// <summary>
        /// Gets the distance.
        /// </summary>
        /// <value>The distance.</value>
        double Distance { get; }
    }
}
