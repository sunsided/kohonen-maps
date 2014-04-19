using JetBrains.Annotations;

namespace Widemeadows.MachineLearning.Kohonen.Data
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
        [NotNull]
        IDataSet ProvideDataSet();
    }
}
