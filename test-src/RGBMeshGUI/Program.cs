using System;
using System.Windows.Forms;
using Widemeadows.MachineLearning.Kohonen.Data.Colors;
using Widemeadows.MachineLearning.Kohonen.Grid;
using Widemeadows.MachineLearning.Kohonen.Learning;
using Widemeadows.MachineLearning.Kohonen.Metrics;
using Widemeadows.MachineLearning.Kohonen.Neuron;
using Widemeadows.MachineLearning.Kohonen.Random;

namespace Widemeadows.MachineLearning.Kohonen.Tests.RgbMesh
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var program = new Program();
            program.Run();
        }

        /// <summary>
        /// Runs this instance.
        /// </summary>
        private void Run()
        {
            const int width = 32;
            const int height = 32;
            const int count = width * height;

            const int totalIterations = 300;
            double baseRadius = Math.Sqrt(count)*0.4;

            // prepare generator and randomized data set
            var generator = new StandardRng();
            var dataSetProvider = new DiscreteRandomRgbDataSetProvider(generator, 5);
            var dataSet = dataSetProvider.ProvideDataSet();

            // prepare factories
            var gridFactory = new Grid2DFactory(generator);
            var neuronFactory = new RandomWeightGenerator(3);

            // prepare the metric
            var metric = new EuclideanDistance();
            var bmuFinder = new BmuFinder(metric);

            // prepare the grid
            var grid = gridFactory.CreateGrid(width, height, neuronFactory);
            grid.IsSpherical = true;

            // prepare adjustment functions
            var radiusFunction = new RadiusExponentialShrink()
                                 {
                                     TotalIterations = totalIterations,
                                     StartRadius = baseRadius
                                 };
            var neighborhoodFunction = new GaussianNeighborhood();
            var learningRateFunction = new LearningRateExponentialShrink()
                                       {
                                           TotalIterations = totalIterations,
                                           StartRate = 2
                                       };
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
                    // calculate the distance on the grid
                    var distanceToBmu = grid.CalculateDistance(metric, bmu, gridNeuron);

                    // calculate the new weights
                    var currentWeights = gridNeuron.Neuron.Weights;
                    var newWeights = weightAdjustment.CalculateNewWeights(i, trainingVectorWeights, currentWeights, distanceToBmu);

                    // update the neuron with the new weights
                    gridNeuron.Neuron.UpdateWeights(newWeights);
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new Main();
            form.SetGrid(grid);
            form.SetData(dataSet);
            Application.Run(form);
        }
    }
}
