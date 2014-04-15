using System.ComponentModel;

namespace Widemeadows.MachineLearning.Kohonen.Model
{
    /// <summary>
    /// Interface IMetadata
    /// </summary>
    public interface IExtendedMetadata : IMetadata
    {
        /// <summary>
        /// Gets a value indicating whether this instance is default.
        /// </summary>
        /// <value><c>true</c> if this instance is default; otherwise, <c>false</c>.</value>
        [DefaultValue(false)]
        bool IsDefault { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is internal.
        /// </summary>
        /// <value><c>true</c> if this instance is internal; otherwise, <c>false</c>.</value>
        [DefaultValue(false)]
        bool IsInternal { get; }
    }
}
