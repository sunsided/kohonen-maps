namespace Widemeadows.MachineLearning.Kohonen.Random
{
    /// <summary>
    /// Interface IRandomNumber
    /// </summary>
    public interface IRequiresRng
    {
        /// <summary>
        /// Sets the random number generator.
        /// </summary>
        /// <param name="generator">The generator.</param>
        void SetRandomNumberGenerator(IRandomNumber generator);
    }
}
