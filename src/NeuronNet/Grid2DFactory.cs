using System;
using Widemeadows.MachineLearning.Kohonen.Model;
using Widemeadows.MachineLearning.Kohonen.Model.Grid;
using Widemeadows.MachineLearning.Kohonen.Model.Neuron;

namespace Widemeadows.MachineLearning.Kohonen.Net
{
    /// <summary>
    /// Class Grid2DFactory.
    /// </summary>
    public sealed class Grid2DFactory
    {
        /// <summary>
        /// The random number generator
        /// </summary>
        private readonly IRandomNumber _generator;

        /// <summary>
        /// Initializes a new instance of the <see cref="Grid2DFactory" /> class.
        /// </summary>
        /// <param name="generator">The generator.</param>
        /// <exception cref="System.ArgumentNullException">generator</exception>
        public Grid2DFactory(IRandomNumber generator)
        {
            if (generator == null) throw new ArgumentNullException("generator");
            _generator = generator;
        }

        /// <summary>
        /// Creates the grid.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="neuronFactory">The neuron factory.</param>
        /// <returns>IGird2D.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// width;Width must be greater than zero.
        /// or
        /// height;Height must be greater than zero.
        /// </exception>
        /// <exception cref="System.ArgumentNullException">neuronFactory</exception>
        public IGrid2D CreateGrid(int width, int height, IRandomNeuronFactory neuronFactory)
        {
            if (width <= 0) throw new ArgumentOutOfRangeException("width", "Width must be greater than zero.");
            if (height <= 0) throw new ArgumentOutOfRangeException("height", "Height must be greater than zero.");
            if (neuronFactory == null) throw new ArgumentNullException("neuronFactory");

            var generator = _generator;
            var grid = new NeuronGrid2D(width, height);
            
            // fill the grid
            for (int h = 0; h < height; ++h)
            {
                for (int w = 0; w < width; ++w)
                {
                    grid[w, h] = neuronFactory.CreateRandom(generator);
                }
            }

            return grid;
        }
    }
}
