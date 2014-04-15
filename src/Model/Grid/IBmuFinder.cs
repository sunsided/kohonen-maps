using Widemeadows.MachineLearning.Kohonen.Data;

namespace Widemeadows.MachineLearning.Kohonen.Grid
{
    /// <summary>
    /// Interface IBmuFinder
    /// </summary>
    public interface IBmuFinder
    {
        /// <summary>
        /// Finds the best matching unit.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="datum">The datum.</param>
        /// <returns>INeuron.</returns>
        IBestMatchingUnit FindBestMatchingUnit(IGrid2D grid, IDatum datum);
    }
}
