namespace widemeadows.ml.kohonen.model.data
{
    /// <summary>
    /// Interface IDataSetProvider
    /// </summary>
    public interface IDataSetProvider
    {
        /// <summary>
        /// Provides the data set.
        /// </summary>
        /// <returns>IDataSet.</returns>
        IDataSet ProvideDataSet();
    }
}
