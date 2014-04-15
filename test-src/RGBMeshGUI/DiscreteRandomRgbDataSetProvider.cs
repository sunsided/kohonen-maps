using System;
using System.Collections.Generic;
using System.Drawing;
using Widemeadows.MachineLearning.Kohonen.Model;
using Widemeadows.MachineLearning.Kohonen.Model.Data;
using Widemeadows.MachineLearning.Kohonen.Model.Random;

namespace Widemeadows.MachineLearning.Kohonen.Tests.RgbMesh
{
    /// <summary>
    /// Class DiscreteRandomRgbDataSetProvider.
    /// </summary>
    class DiscreteRandomRgbDataSetProvider : IDataSetProvider, IRequiresRng
    {
         /// <summary>
        /// The generator
        /// </summary>
        private IRandomNumber _generator;

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
        public DiscreteRandomRgbDataSetProvider()
            : this(4, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RgbDataSet" /> class.
        /// </summary>
        /// <param name="size">The size of the data set.</param>
        /// <param name="discreteColors">The discrete colors.</param>
        public DiscreteRandomRgbDataSetProvider(int size, params Color[] discreteColors)
        {
            _size = size;
            _discreteColors = discreteColors;

            // set default colors
            if (discreteColors == null || discreteColors.Length == 0)
            {
                _discreteColors = new[]
                                  {
                                      Color.Magenta,
                                      Color.Lime,
                                      Color.Orange,
                                      Color.DeepSkyBlue,
                                      Color.White,
                                      Color.Crimson,
                                      Color.Salmon,
                                      Color.DarkBlue,
                                      Color.Black,
                                      Color.Olive,
                                      Color.Red
                                  };
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RgbDataSet" /> class.
        /// </summary>
        /// <param name="generator">The generator.</param>
        /// <param name="size">The size of the data set.</param>
        /// <param name="discreteColors">The discrete colors.</param>
        public DiscreteRandomRgbDataSetProvider(IRandomNumber generator, int size, params Color[] discreteColors)
            : this(size, discreteColors)
        {
            SetRandomNumberGenerator(generator);
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
            var discreteColors = new List<Color>(_discreteColors);
            var size = Math.Min(_size, discreteColors.Count);
            var colors = new Color[size];

            for (int i = 0; i < size; ++i)
            {
                var index = (int)Math.Round(_generator.GetDouble(0, discreteColors.Count - 1));
                colors[i] = discreteColors[index];
                discreteColors.RemoveAt(index);
            }

            return new RgbDataSet(colors);
        }

        /// <summary>
        /// Sets the random number generator.
        /// </summary>
        /// <param name="generator">The generator.</param>
        public void SetRandomNumberGenerator(IRandomNumber generator)
        {
            _generator = generator;
        }
    }
}
