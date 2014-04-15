using Widemeadows.MachineLearning.Kohonen.Neuron;

namespace Widemeadows.MachineLearning.Kohonen.Grid
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
