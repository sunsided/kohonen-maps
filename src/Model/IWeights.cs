namespace widemeadows.ml.kohonen.model
{
    /// <summary>
    /// Interface IWeights
    /// </summary>
    public interface IWeights
    {
        /// <summary>
        /// Gets the length.
        /// </summary>
        /// <value>The length.</value>
        int Length { get; }

        /// <summary>
        /// Gets the <see cref="System.Double"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>System.Double.</returns>
        double this[int index]
        {
            get; set;
        }
    }
}