using JetBrains.Annotations;

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
        [NotNull]
        string Name { get; }

        /// <summary>
        /// Gets the version.
        /// </summary>
        /// <value>The version.</value>
        [NotNull]
        string Version { get; }
        
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [NotNull]
        string Id { get; }
    }
}
