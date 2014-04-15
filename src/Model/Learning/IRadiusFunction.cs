namespace Widemeadows.MachineLearning.Kohonen.Model.Learning
{
    /// <summary>
    /// Interface IRadiusFunction
    /// </summary>
    public interface IRadiusFunction
    {
        /// <summary>
        /// The starting radius
        /// </summary>
        double StartRadius { get; set; }

        /// <summary>
        /// Calculates the radius.
        /// </summary>
        /// <param name="iteration">The iteration.</param>
        /// <returns>System.Double.</returns>
        double CalculateRadius(int iteration);
    }
}
