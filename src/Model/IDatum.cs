namespace widemeadows.ml.kohonen.model
{
    /// <summary>
    /// Interface IDatum
    /// </summary>
    public interface IDatum
    {
        /// <summary>
        /// Maps this datum's categories to weights.
        /// </summary>
        /// <returns>IWeights.</returns>
        IWeights MapToWeights();
    }
}
