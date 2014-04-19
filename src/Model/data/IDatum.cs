using JetBrains.Annotations;
using Widemeadows.MachineLearning.Kohonen.Neuron;

namespace Widemeadows.MachineLearning.Kohonen.Data
{
    /// <summary>
    /// Interface IDatum
    /// </summary>
    public interface IDatum
    {
#if false
        [NotNull]
        IWeights GetDistance([NotNull] IDatum gridDatum);
#endif

        /// <summary>
        /// Maps to weights.
        /// </summary>
        /// <returns>IWeights.</returns>
        [NotNull]
        IWeights MapToWeights();
    }
}
