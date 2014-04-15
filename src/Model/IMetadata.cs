namespace Widemeadows.MachineLearning.Kohonen
{
    /// <summary>
    /// Interface IMetadata
    /// </summary>
    public interface IMetadata
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; }

        /// <summary>
        /// Gets the version.
        /// </summary>
        /// <value>The version.</value>
        string Version { get; }
        
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        string Id { get; }
    }
}
