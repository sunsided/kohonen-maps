using System;
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
        public IGridNeuron FindBestMatchingUnit(IGrid2D grid, IDatum datum)
        {
            // get weights from datum
            var referenceWeighs = datum.MapToWeights();

            // prepare search
            var metric = _metric;
            var smallestDistance = Double.MaxValue;
            var bmu = null as IGridNeuron;

            // linear search
            foreach (var gridNeuron in grid)
            {
                var weigths = gridNeuron.Neuron.Weights;
                var distance = metric.CalculateDistance(referenceWeighs, weigths);
                if (!(distance < smallestDistance)) continue;

                smallestDistance = distance;
                bmu = gridNeuron;
            }

            return bmu;
        }
    }
}
