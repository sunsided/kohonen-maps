namespace widemeadows.ml.kohonen.model
{
    /// <summary>
    /// Interface IDataSet
    /// </summary>
    interface IDataSet
    {
        /// <summary>
        /// Picks a random datum from the data.
        /// </summary>
        /// <param name="generator">The generator.</param>
        /// <returns>IDatum.</returns>
        IDatum PickRandom(IRandomNumber generator);
    }
}
