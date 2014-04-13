namespace widemeadows.ml.kohonen.model
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
