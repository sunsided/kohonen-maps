using System.Drawing;
using Widemeadows.MachineLearning.Kohonen.Model;
using Widemeadows.MachineLearning.Kohonen.Model.Data;

namespace Widemeadows.MachineLearning.Kohonen.Tests.RgbMesh
{
    /// <summary>
    /// Class RandomRgbDataSetProvider.
    /// </summary>
    class RandomRgbDataSetProvider : IDataSetProvider
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
        /// Initializes a new instance of the <see cref="RgbDataSet" /> class.
        /// </summary>
        /// <param name="generator">The generator.</param>
        /// <param name="size">The size of the data set.</param>
        public RandomRgbDataSetProvider(IRandomNumber generator, int size)
        {
            _generator = generator;
            _size = size;
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
            for (int i = 0; i < _size; ++i)
            {
                var r = (int)_generator.GetDouble(0, 255);
                var g = (int)_generator.GetDouble(0, 255);
                var b = (int)_generator.GetDouble(0, 255);
                colors[i] = Color.FromArgb(r, g, b);
            }
            return new RgbDataSet(colors);
        }
    }
}
