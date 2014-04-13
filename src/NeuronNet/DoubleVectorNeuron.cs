using widemeadows.ml.kohonen.model;

namespace widemeadows.ml.kohonen.net
{
    /// <summary>
    /// Class DoubleVectorNeuron. This class cannot be inherited.
    /// </summary>
    public sealed class DoubleVectorNeuron : INeuron
    {
        /// <summary>
        /// Gets or sets the vector.
        /// </summary>
        /// <value>The vector.</value>
        public DoubleVector Vector { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleVectorNeuron" /> class.
        /// </summary>
        /// <param name="vector">The vector.</param>
        public DoubleVectorNeuron(DoubleVector vector)
        {
            Vector = vector;
        }
    }
}
