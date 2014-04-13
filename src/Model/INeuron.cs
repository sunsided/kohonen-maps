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
    }
}