using System;
using widemeadows.ml.kohonen.model;

namespace widemeadows.ml.kohonen.net
{
    /// <summary>
    /// Class NeuronGrid2D.
    /// </summary>
    public sealed class NeuronGrid2D : IGrid2D
    {
        /// <summary>
        /// The width
        /// </summary>
        private readonly int _width;

        /// <summary>
        /// The height
        /// </summary>
        private readonly int _height;

        /// <summary>
        /// The array of neurons
        /// </summary>
        private readonly INeuron[,] _neurons;

        /// <summary>
        /// Gets the grid width.
        /// </summary>
        /// <value>The width.</value>
        public int Width { get { return _width; } }

        /// <summary>
        /// Gets the grid height.
        /// </summary>
        /// <value>The height.</value>
        public int Height { get { return _height; } }

        /// <summary>
        /// Gets the <see cref="INeuron"/> with the specified x.
        /// </summary>
        /// <param name="y">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <returns>NeuronNet.INeuron.</returns>
        public INeuron this[int x, int y]
        {
            get { return _neurons[x, y]; }
            set { _neurons[x, y] = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeuronGrid2D" /> class.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">width;Width must be greater than zero.
        /// or
        /// height;Height must be greater than zero.</exception>
        public NeuronGrid2D(int width, int height)
        {
            if (width <= 0) throw new ArgumentOutOfRangeException("width", "Width must be greater than zero.");
            if (height <= 0) throw new ArgumentOutOfRangeException("height", "Height must be greater than zero.");

            _width = width;
            _height = height;
            _neurons = new INeuron[width, height];
        }
    }
}
