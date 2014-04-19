using JetBrains.Annotations;
using Widemeadows.MachineLearning.Kohonen.Random;

namespace Widemeadows.MachineLearning.Kohonen.Neuron
{
    /// <summary>
    /// Interface IRandomNeuronFactory
    /// </summary>
    public interface IRandomNeuronFactory
    {
        /// <summary>
        /// Creates the random.
        /// </summary>
        /// <param name="generator">The generator.</param>
        /// <returns>INeuron.</returns>
        [NotNull]
        INeuron CreateRandom([NotNull] IRandomNumber generator);
    }
}
