using System;
using System.Collections.Generic;
using widemeadows.ml.kohonen.model;

namespace widemeadows.ml.kohonen.net
{
    /// <summary>
    /// Class BmuFinder.
    /// </summary>
    public sealed class BmuFinder : IBmuFinder
    {
        /// <summary>
        /// The distance metric
        /// </summary>
        private readonly IMetric _metric;

        /// <summary>
        /// Initializes a new instance of the <see cref="BmuFinder" /> class.
        /// </summary>
        /// <param name="metric">The metric.</param>
        /// <exception cref="System.ArgumentNullException">metric</exception>
        public BmuFinder(IMetric metric)
        {
            if (metric == null) throw new ArgumentNullException("metric");
            _metric = metric;
        }

        /// <summary>
        /// Finds the best matching unit.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="datum">The datum.</param>
        /// <returns>INeuron.</returns>
        public IBestMatchingUnit FindBestMatchingUnit(IGrid2D grid, IDatum datum)
        {
            // get weights from datum
            var referenceWeighs = datum.MapToWeights();

            // prepare search
            var metric = _metric;
            var smallestDistance = Double.NaN;
            var bmu = null as IGridNeuron;

            // linear search
            foreach (var gridNeuron in grid)
            {
                var weigths = gridNeuron.Neuron.Weights;
                var distance = metric.CalculateDistance(referenceWeighs, weigths);
                if (!(Double.IsNaN(smallestDistance) || distance < smallestDistance)) continue;

                smallestDistance = distance;
                bmu = gridNeuron;
            }

            return new BestMatchingUnit(bmu, smallestDistance);
        }

        /// <summary>
        /// Class BestMatchingUnit. This class cannot be inherited.
        /// </summary>
        private sealed class BestMatchingUnit : IBestMatchingUnit
        {
            /// <summary>
            /// Gets the distance.
            /// </summary>
            /// <value>The distance.</value>
            public double Distance { get; private set; }

            /// <summary>
            /// The _bmu
            /// </summary>
            private readonly IGridNeuron _bmu;

            /// <summary>
            /// Gets the neuron.
            /// </summary>
            /// <value>The neuron.</value>
            public INeuron Neuron { get { return _bmu.Neuron; } }

            /// <summary>
            /// Gets the grid coordinates.
            /// </summary>
            /// <value>The grid coordinates.</value>
            public IReadOnlyList<double> GridCoordinates { get { return _bmu.GridCoordinates; } }

            /// <summary>
            /// Initializes a new instance of the <see cref="BestMatchingUnit"/> class.
            /// </summary>
            /// <param name="bmu">The bmu.</param>
            /// <param name="distance">The distance.</param>
            public BestMatchingUnit(IGridNeuron bmu, double distance)
            {
                Distance = distance;
                _bmu = bmu;
            }
        }
    }
}
