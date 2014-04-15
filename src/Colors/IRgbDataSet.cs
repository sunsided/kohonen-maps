using System.Drawing;

namespace Widemeadows.MachineLearning.Kohonen.Data.Colors
{
    /// <summary>
    /// Interface IRgbDataSet
    /// </summary>
    public interface IRgbDataSet : IDataSet
    {
        /// <summary>
        /// Gets the colors.
        /// </summary>
        /// <value>The colors.</value>
        Color[] Colors { get; }
    }
}
