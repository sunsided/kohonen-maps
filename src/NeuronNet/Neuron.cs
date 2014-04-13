using widemeadows.ml.kohonen.model;

namespace widemeadows.ml.kohonen.net
{
    /// <summary>
    /// Class DoubleVectorNeuron. This class cannot be inherited.
    /// </summary>
    public sealed class Neuron : INeuron
    {
        /// <summary>
        /// Gets or sets the vector.
        /// </summary>
        /// <value>The vector.</value>
        public WeightVector Weight { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Neuron" /> class.
        /// </summary>
        /// <param name="weight">The weight.</param>
        public Neuron(WeightVector weight)
        {
            Weight = weight;
        }
    }
}
