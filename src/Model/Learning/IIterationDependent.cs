namespace Widemeadows.MachineLearning.Kohonen.Model.Learning
{
    /// <summary>
    /// Interface IIterationDependent
    /// </summary>
    public interface IIterationDependent
    {
        /// <summary>
        /// Gets the number of total iterations.
        /// </summary>
        /// <value>The total iterations.</value>
        int TotalIterations { get; set; }
    }
}
