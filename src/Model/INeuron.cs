namespace widemeadows.ml.kohonen.model
{
    /// <summary>
    /// Interface INeuron
    /// </summary>
    public interface INeuron
    {
        /// <summary>
        /// Gets the weights.
        /// </summary>
        /// <value>The weights.</value>
        IWeights Weights { get; }

        /// <summary>
        /// Updates the weights.
        /// </summary>
        /// <param name="newWeights">The new weights.</param>
        /// <exception cref="System.ArgumentException">Lengths of weight vectors differ.</exception>
        void UpdateWeights(IWeights newWeights);
    }
}