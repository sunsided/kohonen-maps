using Widemeadows.MachineLearning.Kohonen.Model.Neuron;

namespace Widemeadows.MachineLearning.Kohonen.Model.Data
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
