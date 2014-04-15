using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using Widemeadows.MachineLearning.Kohonen.Model;
using Widemeadows.MachineLearning.Kohonen.Model.Data;
using Widemeadows.MachineLearning.Kohonen.Model.Learning;
using Widemeadows.MachineLearning.Kohonen.Model.Metrics;
using Widemeadows.MachineLearning.Kohonen.Model.Random;

namespace Widemeadows.MachineLearning.Kohonen.Tests.InterfaceScan
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.Run();
        }

        [ImportMany(typeof(IRandomNumber))]
        private IEnumerable<Lazy<IRandomNumber, IExtendedMetadata>> _randomNumberGenerators = null;

        [ImportMany(typeof(IMetric))]
        private IEnumerable<Lazy<IMetric, IExtendedMetadata>> _metrics = null;

        [ImportMany(typeof(INeighborhoodFunction))]
        private IEnumerable<Lazy<INeighborhoodFunction, IExtendedMetadata>> _neighborhoodFunctions = null;

        [ImportMany(typeof(IRadiusFunction))]
        private IEnumerable<Lazy<IRadiusFunction, IExtendedMetadata>> _radiusFunctions = null;

        [ImportMany(typeof(ILearningRate))]
        private IEnumerable<Lazy<ILearningRate, IExtendedMetadata>> _learningRateFunctions = null;

        [ImportMany(typeof(IDataSetProvider))]
        private IEnumerable<Lazy<IDataSetProvider, IExtendedMetadata>> _dataSetProviders = null;

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
            List("Data Set Providers", _dataSetProviders);

            Console.WriteLine("Press key to exit.");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Lists the specified items.
        /// </summary>
        /// <param name="header">The header.</param>
        /// <param name="constructed">The constructed.</param>
        private void List<T>(string header, IEnumerable<Lazy<T, IExtendedMetadata>> constructed)
        {
            Console.WriteLine(header);

            foreach (var contract in constructed)
            {
                var name = contract.Metadata.Name;
                var version = contract.Metadata.Version;
                var id = contract.Metadata.Id;
                var isDefault = contract.Metadata.IsDefault;

                Console.Write(isDefault ? " * " : " - ");
                Console.WriteLine("{0}, Version {1}", name, version);
            }
            
            Console.WriteLine();
        }
    }
}
