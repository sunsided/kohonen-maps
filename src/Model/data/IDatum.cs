using Widemeadows.MachineLearning.Kohonen.Neuron;

namespace Widemeadows.MachineLearning.Kohonen.Data
{
    /// <summary>
    /// Interface IDatum
    /// </summary>
    public interface IDatum
    {
        /// <summary>
        /// Maps this datum's categories to weights.
        /// </summary>
        /// <returns>IWeights.</returns>
        IWeights MapToWeights();
    }
}
