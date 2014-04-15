using System.ComponentModel.Composition;
using System.Drawing;
using Widemeadows.MachineLearning.Kohonen.Random;

namespace Widemeadows.MachineLearning.Kohonen.Data.Colors
{
    /// <summary>
    /// Class RandomRgbDataSetProvider.
    /// </summary>
    [Export(typeof(IDataSetProvider))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    [IdMetadata("87C13498-0696-4E92-A9B0-5D851C703838", "Fully Random RGB", "1.0.0.0")]
    public sealed class RandomRgbDataSetProvider : IDataSetProvider, IRequiresRng
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
        /// Initializes a new instance of the <see cref="RgbDataSet" /> class.
        /// </summary>
        public RandomRgbDataSetProvider()
            : this(5)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RgbDataSet" /> class.
        /// </summary>
        /// <param name="size">The size of the data set.</param>
        public RandomRgbDataSetProvider(int size)
        {
            _size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RgbDataSet" /> class.
        /// </summary>
        /// <param name="generator">The generator.</param>
        /// <param name="size">The size of the data set.</param>
        public RandomRgbDataSetProvider(IRandomNumber generator, int size)
            : this(size)
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
