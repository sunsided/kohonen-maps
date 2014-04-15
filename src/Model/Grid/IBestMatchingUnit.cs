using Widemeadows.MachineLearning.Kohonen.Model.Neuron;

namespace Widemeadows.MachineLearning.Kohonen.Model.Grid
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
