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
        private IEnumerable<Lazy<IRandomNumber, IMetadata>> _rngs = null;

        /// <summary>
        /// Runs this instance.
        /// </summary>
        private void Run()
        {
            var catalog = new DirectoryCatalog(".");
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);

            foreach (var contract in _rngs)
            {
                var name = contract.Metadata.Name;
                var version = contract.Metadata.Version;
                var id = contract.Metadata.Id;
                
                Console.WriteLine("Selecting \"{0}\", Version {1}", name, version);

                var number = contract.Value.GetDouble();
                Console.WriteLine("Number from generator: {0}", number);
            }

            Console.WriteLine("Press key to exit.");
            Console.ReadKey(true);
        }
    }
}
