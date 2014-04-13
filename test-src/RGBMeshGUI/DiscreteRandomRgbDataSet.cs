using System.Drawing;
using widemeadows.ml.kohonen.model;

namespace widemeadows.ml.kohonen.tests.rgbmesh
{
    /// <summary>
    /// Class RgbDataSet.
    /// </summary>
    class DiscreteRandomRgbDataSet : IDataSet, IRgbDataSet
    {
        /// <summary>
        /// The colors
        /// </summary>
        private readonly Color[] _colors;

        /// <summary>
        /// Gets the colors.
        /// </summary>
        /// <value>The colors.</value>
        public Color[] Colors
        {
            get { return _colors; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RgbDataSet" /> class.
        /// </summary>
        /// <param name="generator">The generator.</param>
        /// <param name="size">The size of the data set.</param>
        public DiscreteRandomRgbDataSet(IRandomNumber generator, int size)
        {
            _colors = new Color[size];
            for (int i = 0; i < size; ++i)
            {
                Color c;

                var r = generator.GetDouble();
                if (r < 0.25)
                {
                    c = Color.OrangeRed;
                }
                else if (r < 0.5)
                {
                    c = Color.LawnGreen;
                }
                else if (r < 0.75)
                {
                    c = Color.Magenta;
                }
                else
                {
                    c = Color.DeepSkyBlue;
                }

                _colors[i] = c;
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
