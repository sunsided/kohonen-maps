using System.Drawing;
using Widemeadows.MachineLearning.Kohonen.Model.Data;

namespace Widemeadows.MachineLearning.Kohonen.Tests.RgbMesh
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
