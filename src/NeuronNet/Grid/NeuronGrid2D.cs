using System;
using System.Collections;
using System.Collections.Generic;
using Widemeadows.MachineLearning.Kohonen.Model.Grid;
using Widemeadows.MachineLearning.Kohonen.Model.Neuron;

namespace Widemeadows.MachineLearning.Kohonen.Grid
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

        /// <summary>
        /// Gets the dimensions.
        /// </summary>
        /// <value>The dimensions.</value>
        public int Dimensions { get { return 2; }}

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.</returns>
        public IEnumerator<IGridNeuron> GetEnumerator()
        {
            var width = _width;
            var height = _height;
            var neurons = _neurons;
            for (int h = 0; h < height; ++h)
            {
                for (int w = 0; w < width; ++w)
                {
                    var coordinates = new double[] { w, h };
                    var neuron = neurons[w, h];

                    yield return new GridNeuron(neuron, coordinates);
                }
            }
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
