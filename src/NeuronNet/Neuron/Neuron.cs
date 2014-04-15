namespace Widemeadows.MachineLearning.Kohonen.Neuron
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
        public IWeights Weights { get; set; }

        /// <summary>
        /// Updates the weights.
        /// </summary>
        /// <param name="newWeights">The new weights.</param>
        public void UpdateWeights(IWeights newWeights)
        {
            Weights.Update(newWeights);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Neuron" /> class.
        /// </summary>
        /// <param name="weights">The Weights.</param>
        public Neuron(IWeights weights)
        {
            Weights = weights;
        }
    }
}
