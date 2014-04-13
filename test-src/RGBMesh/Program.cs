using System.Drawing;
using RandomNumberGenerator;
using widemeadows.ml.kohonen.metrics;
using widemeadows.ml.kohonen.neighborhoods;
using widemeadows.ml.kohonen.net;

namespace widemeadows.ml.kohonen.tests.rgbmesh
{
    /// <summary>
    /// Class Program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            var program = new Program();
            program.Run();
        }

        /// <summary>
        /// Runs this instance.
        /// </summary>
        private void Run()
        {
            const int width = 4;
            const int height = 4;
            const int count = width*height;

            const int totalIterations = 10;
            const double baseRadius = 16.0;

            // prepare generator and randomized data set
            var generator = new StandardRng();
            var dataSet = new RgbDataSet(generator, count);

            // prepare factories
            var gridFactory = new Grid2DFactory(generator);
            var neuronFactory = new RandomWeightGenerator(3);

            // prepare the metric
            var metric = new ManhattanDistance();
            var bmuFinder = new BmuFinder(metric);

            // prepare the grid
            var grid = gridFactory.CreateGrid(width, height, neuronFactory);

            // prepare adjustment functions
            var radiusFunction = new RadiusExponentialShrink(totalIterations, baseRadius);
            var neighborhoodFunction = new GaussianNeighborhood();
            var learningRateFunction = new LearningRateExponentialShrink(totalIterations, baseRadius);
            var weightAdjustment = new WeightAdjustment(radiusFunction, neighborhoodFunction, learningRateFunction);

            // iterate
            for (int i = 0; i < totalIterations; ++i)
            {
                // pick a datum and find the best matching unit on the grid
                var picked = dataSet.PickRandom(generator);
                var bmu = bmuFinder.FindBestMatchingUnit(grid, picked);

                // adjust all other neurons
                var trainingVectorWeights = picked.MapToWeights();
                foreach (var gridNeuron in grid)
                {
                    var currentWeights = gridNeuron.Neuron.Weights;
                    var distanceToBmu = metric.CalculateDistance(bmu.GridCoordinates, gridNeuron.GridCoordinates);

                    // calculate the new weights
                    var newWeights = weightAdjustment.CalculateNewWeights(i, trainingVectorWeights, currentWeights, distanceToBmu);

                    // update the neuron with the new weights
                    gridNeuron.Neuron.UpdateWeights(newWeights);
                }
            }
        }
    }
}
