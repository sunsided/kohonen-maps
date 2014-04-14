using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using widemeadows.ml.kohonen.model;

namespace widemeadows.ml.kohonen.tests.interfacescan
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.Run();
        }

        [ImportMany(typeof(IRandomNumber))]
        private IEnumerable<Lazy<IRandomNumber, IMetadata>> _randomNumberGenerators = null;

        [ImportMany(typeof(IMetric))]
        private IEnumerable<Lazy<IMetric, IMetadata>> _metrics = null;

        [ImportMany(typeof(INeighborhoodFunction))]
        private IEnumerable<Lazy<INeighborhoodFunction, IMetadata>> _neighborhoodFunctions = null;

        [ImportMany(typeof(IRadiusFunction))]
        private IEnumerable<Lazy<IRadiusFunction, IMetadata>> _radiusFunctions = null;

        [ImportMany(typeof(ILearningRate))]
        private IEnumerable<Lazy<ILearningRate, IMetadata>> _learningRateFunctions = null;

        [Export("TotalIterations")]
        private int _totalIterations = 100;

        [Export("StartRadius")]
        private int _baseRadius = 10;

        [Export("StartRate")]
        private int _baseRate = 10;

        /// <summary>
        /// Runs this instance.
        /// </summary>
        private void Run()
        {
            var catalog = new DirectoryCatalog(".");
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);

            List("Random Number Generators", _randomNumberGenerators);
            List("Metrics", _metrics);
            List("Neighborhood Functions", _neighborhoodFunctions);
            List("Radius Functions", _radiusFunctions);
            List("Learning Rate Functions", _learningRateFunctions);

            Console.WriteLine("Press key to exit.");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Lists the specified items.
        /// </summary>
        /// <param name="header">The header.</param>
        /// <param name="constructed">The constructed.</param>
        private void List<T>(string header, IEnumerable<Lazy<T, IMetadata>> constructed)
        {
            Console.WriteLine(header);

            foreach (var contract in constructed)
            {
                var name = contract.Metadata.Name;
                var version = contract.Metadata.Version;
                var id = contract.Metadata.Id;

                Console.WriteLine(" - {0}, Version {1}", name, version);
            }
            
            Console.WriteLine();
        }
    }
}
