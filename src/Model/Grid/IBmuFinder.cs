using Widemeadows.MachineLearning.Kohonen.Model.Data;

namespace Widemeadows.MachineLearning.Kohonen.Model.Grid
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
