using System.Drawing;
using widemeadows.ml.kohonen.model;

namespace widemeadows.ml.kohonen.tests.rgbmesh
{
    /// <summary>
    /// Class RgbDataSet.
    /// </summary>
    class RgbDataSet : IDataSet
    {
        /// <summary>
        /// The colors
        /// </summary>
        private readonly Color[] _colors;

        /// <summary>
        /// Initializes a new instance of the <see cref="RgbDataSet" /> class.
        /// </summary>
        /// <param name="generator">The generator.</param>
        /// <param name="size">The size of the data set.</param>
        public RgbDataSet(IRandomNumber generator, int size)
        {
            _colors = new Color[size];
            for (int i = 0; i < size; ++i)
            {
                var r = (int)generator.GetDouble(0, 255);
                var g = (int)generator.GetDouble(0, 255);
                var b = (int)generator.GetDouble(0, 255);
                _colors[i] = Color.FromArgb(r, g, b);
            }
        }

        /// <summary>
        /// Picks a random datum from the data.
        /// </summary>
        /// <param name="generator">The generator.</param>
        /// <returns>IDatum.</returns>
        public IDatum PickRandom(IRandomNumber generator)
        {
            var size = _colors.Length;
            var index = (int)generator.GetDouble(0, size - 1);
            var color = _colors[index];
            return new ColorDatum(color);
        }
    }
}
