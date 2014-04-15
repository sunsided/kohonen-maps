using System.Drawing;
using widemeadows.ml.kohonen.model.data;

namespace widemeadows.ml.kohonen.tests.rgbmesh
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
