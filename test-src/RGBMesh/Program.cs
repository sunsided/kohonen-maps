using RandomNumberGenerator;
using widemeadows.ml.kohonen.net;

namespace RGBMesh
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

            var generator = new StandardRng();
            var dataSet = new RgbDataSet(generator, count);

            var gridFactory = new Grid2DFactory(generator);
            var neuronFactory = new RandomWeightGenerator(3);

            var grid = gridFactory.CreateGrid(width, height, neuronFactory);
            
            var lol = dataSet.PickRandom(generator);
        }
    }
}
