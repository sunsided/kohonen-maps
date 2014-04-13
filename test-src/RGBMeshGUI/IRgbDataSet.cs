using System.Drawing;

namespace widemeadows.ml.kohonen.tests.rgbmesh
{
    /// <summary>
    /// Interface IRgbDataSet
    /// </summary>
    public interface IRgbDataSet
    {
        /// <summary>
        /// Gets the colors.
        /// </summary>
        /// <value>The colors.</value>
        Color[] Colors { get; }
    }
}
