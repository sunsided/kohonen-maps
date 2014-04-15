namespace Widemeadows.MachineLearning.Kohonen.Model.Learning
{
    /// <summary>
    /// Interface ILearningRate
    /// </summary>
    public interface ILearningRate : IIterationDependent
    {
        /// <summary>
        /// The starting learning rate
        /// </summary>
        double StartRate { get; set; }
        
        /// <summary>
        /// The end learning rate
        /// </summary>
        double EndRate { get; set; }

        /// <summary>
        /// Calculates the learning rate.
        /// </summary>
        /// <param name="iteration">The iteration.</param>
        /// <returns>System.Double.</returns>
        double CalculateLearningRate(int iteration);
    }
}
