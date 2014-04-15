using System;
using System.Drawing;
using widemeadows.ml.kohonen.model;
using widemeadows.ml.kohonen.model.data;

namespace widemeadows.ml.kohonen.tests.rgbmesh
{
    /// <summary>
    /// Class DiscreteRandomRgbDataSetProvider.
    /// </summary>
    class DiscreteRandomRgbDataSetProvider : IDataSetProvider
    {
         /// <summary>
        /// The generator
        /// </summary>
        private readonly IRandomNumber _generator;

        /// <summary>
        /// The size
        /// </summary>
        private readonly int _size;

        /// <summary>
        /// The _discrete colors
        /// </summary>
        private readonly Color[] _discreteColors;

        /// <summary>
        /// Initializes a new instance of the <see cref="RgbDataSet" /> class.
        /// </summary>
        /// <param name="generator">The generator.</param>
        /// <param name="size">The size of the data set.</param>
        /// <param name="discreteColors">The discrete colors.</param>
        public DiscreteRandomRgbDataSetProvider(IRandomNumber generator, int size, params Color[] discreteColors)
        {
            _generator = generator;
            _size = size;
            _discreteColors = discreteColors;

            // set default colors
            if (discreteColors == null || discreteColors.Length == 0)
            {
                _discreteColors = new[]
                                  {
                                      Color.Magenta,
                                      Color.Lime,
                                      Color.OrangeRed,
                                      Color.DeepSkyBlue
                                  };
            }
        }
        
        /// <summary>
        /// Provides the data set.
        /// </summary>
        /// <returns>IDataSet.</returns>
        IDataSet IDataSetProvider.ProvideDataSet()
        {
            return ProvideDataSet();
        }

        /// <summary>
        /// Provides the data set.
        /// </summary>
        /// <returns>IDataSet.</returns>
        public IRgbDataSet ProvideDataSet()
        {
            var colors = new Color[_size];
            var discreteColors = _discreteColors;
            var discreteColorCount = discreteColors.Length;

            for (int i = 0; i < _size; ++i)
            {
                var index = (int)Math.Round(_generator.GetDouble(0, discreteColorCount - 1));
                colors[i] = discreteColors[index];
            }

            return new RgbDataSet(colors);
        }
    }
}
