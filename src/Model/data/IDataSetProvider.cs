namespace Widemeadows.MachineLearning.Kohonen.Model.Data
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
