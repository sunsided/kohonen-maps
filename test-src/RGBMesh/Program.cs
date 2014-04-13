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
            var generator = new StandardRng();
            var gridFactory = new Grid2DFactory(generator);
            var neuronFactory = new RandomWeightGenerator(3);

            const int width = 4;
            const int height = 4;

            var grid = gridFactory.CreateGrid(width, height, neuronFactory);
        }
    }
}
