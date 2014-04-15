using System.Diagnostics;
using System.Drawing;
using Widemeadows.MachineLearning.Kohonen.Model.Data;
using Widemeadows.MachineLearning.Kohonen.Model.Neuron;
using Widemeadows.MachineLearning.Kohonen.Net;

namespace Widemeadows.MachineLearning.Kohonen.Tests.RgbMesh
{
    /// <summary>
    /// Class ColorDatum. This class cannot be inherited.
    /// </summary>
    [DebuggerDisplay("{_color}")]
    internal sealed class ColorDatum : IDatum
    {
        /// <summary>
        /// The color
        /// </summary>
        private readonly Color _color;

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorDatum"/> class.
        /// </summary>
        /// <param name="color">The color.</param>
        public ColorDatum(Color color)
        {
            _color = color;
        }

        /// <summary>
        /// Maps this datum's categories to weights.
        /// </summary>
        /// <returns>IWeights.</returns>
        public IWeights MapToWeights()
        {
            var weights = new[]
                          {
                              _color.R/255.0,
                              _color.G/255.0,
                              _color.B/255.0
                          };
            var vector = new WeightVector(weights);
            return vector;
        }
    }
}
