using widemeadows.ml.kohonen.model;
using widemeadows.ml.kohonen.net;

namespace RGBMesh
{
    /// <summary>
    /// Class ColorRandomizer.
    /// </summary>
    sealed class ColorRandomizer : IRandomNeuronFactory
    {
        /// <summary>
        /// Creates the random.
        /// </summary>
        /// <param name="generator">The generator.</param>
        /// <returns>INeuron.</returns>
        public INeuron CreateRandom(IRandomNumber generator)
        {
            var r = generator.GetDouble(0, 1);
            var g = generator.GetDouble(0, 1);
            var b = generator.GetDouble(0, 1);
            var vector = new RGBVector(r, g, b);
            var neuron = new Neuron(vector);
            return neuron;
        }
    }
}
