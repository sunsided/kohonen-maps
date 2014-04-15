using Widemeadows.MachineLearning.Kohonen.Model.Random;

namespace Widemeadows.MachineLearning.Kohonen.Model.Neuron
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
        INeuron CreateRandom(IRandomNumber generator);
    }
}
