namespace Widemeadows.MachineLearning.Kohonen.Model.Learning
{
    /// <summary>
    /// Interface INeighborhoodFunction
    /// </summary>
    public interface INeighborhoodFunction
    {
        /// <summary>
        /// Calculates the neighborhood factor.
        /// </summary>
        /// <param name="distance">The distance of the neuron to the best matching unit.</param>
        /// <param name="radius">The radius of the neighborhood.</param>
        /// <returns>System.Double.</returns>
        double CalculateFactor(double distance, double radius);
    }
}
