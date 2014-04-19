using System;
using System.Collections;
using System.Collections.Generic;
using Widemeadows.MachineLearning.Kohonen.Metrics;
using Widemeadows.MachineLearning.Kohonen.Neuron;

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
        /// Gets or sets a value indicating whether this instance is spherical.
        /// </summary>
        /// <value><c>true</c> if this instance is spherical; otherwise, <c>false</c>.</value>
        public bool IsSpherical { get; set; }

        /// <summary>
        /// Calculates the distance.
        /// </summary>
        /// <param name="metric">The metric.</param>
        /// <param name="bmu">The bmu.</param>
        /// <param name="gridNeuron">The grid neuron.</param>
        /// <returns>System.Double.</returns>
        public double CalculateDistance(IMetric metric, IBestMatchingUnit bmu, IGridNeuron gridNeuron)
        {
            var distanceToBmu = metric.CalculateDistance(bmu.GridCoordinates, gridNeuron.GridCoordinates);
            if (!IsSpherical) return distanceToBmu;

            // on spherical grids, check the wrap-around distances
            //
            //
            //   X 1 2 2 1
            //   1 2 3 3 2
            //   2 3 4 4 3
            //   1 2 3 3 2

            var coordinates = gridNeuron.GridCoordinates;
            var coordinatesX = new[] { coordinates[0] - Width + 2, coordinates[1] };
            var coordinatesY = new[] { coordinates[0], coordinates[1] - Height + 2 };
            var coordinatesXy = new[] { coordinatesX[0], coordinatesY[1] };

            distanceToBmu = Math.Min(distanceToBmu, metric.CalculateDistance(bmu.GridCoordinates, coordinatesX));
            distanceToBmu = Math.Min(distanceToBmu, metric.CalculateDistance(bmu.GridCoordinates, coordinatesY));
            distanceToBmu = Math.Min(distanceToBmu, metric.CalculateDistance(bmu.GridCoordinates, coordinatesXy));
            return distanceToBmu;
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
