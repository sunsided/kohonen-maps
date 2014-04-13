using System.Diagnostics;
using System.Drawing;
using widemeadows.ml.kohonen.model;
using widemeadows.ml.kohonen.net;

namespace RGBMesh
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

        /// <summary>
        /// Class ColorDatum. This class cannot be inherited.
        /// </summary>
        [DebuggerDisplay("{_color}")]
        private sealed class ColorDatum : IDatum
        {
            /// <summary>
            /// The color
            /// </summary>
            private readonly Color _color;

            /// <summary>
            /// Initializes a new instance of the <see cref="ColorDatum"/> class.
            /// </summary>
            /// <param name="color">The color.</param>
            public ColorDatum(Color color)
            {
                _color = color;
            }

            /// <summary>
            /// Maps this datum's categories to weights.
            /// </summary>
            /// <returns>IWeights.</returns>
            public IWeights MapToWeights()
            {
                var weights = new []
                              {
                                  _color.R/255.0,
                                  _color.G/255.0,
                                  _color.B/255.0
                              };
                var vector = new WeightVector(weights);
                return vector;
            }
        }
    }
}
