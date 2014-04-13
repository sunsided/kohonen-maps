using System;
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
        private IRandomNumber[] _rngs = null;

        /// <summary>
        /// Runs this instance.
        /// </summary>
        private void Run()
        {
            var catalog = new DirectoryCatalog(".");
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);

            foreach (IRandomNumber contract in _rngs)
            {
                var number = contract.GetDouble();
                Console.WriteLine("Number from generator: {0}", number);
            }

            Console.WriteLine("Press key to exit.");
            Console.ReadKey(true);
        }
    }
}
