using System.ComponentModel;
using System.ComponentModel.Composition;

namespace Widemeadows.MachineLearning.Kohonen.Model
{
    /// <summary>
    /// Class IdMetadataAttribute. This class cannot be inherited.
    /// </summary>
    [MetadataAttribute]
    public class InternalIdMetadataAttribute : IdMetadataAttribute, IExtendedMetadata
    {
        /// <summary>
        /// Gets a value indicating whether this instance is internal.
        /// </summary>
        /// <value><c>true</c> if this instance is internal; otherwise, <c>false</c>.</value>
        public bool IsInternal { get { return true; } }

        /// <summary>
        /// Gets a value indicating whether this instance is default.
        /// </summary>
        /// <value><c>true</c> if this instance is default; otherwise, <c>false</c>.</value>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdMetadataAttribute"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="version">The version.</param>
        /// <exception cref="System.ArgumentException">The given ID string was not a valid GUID format.;id</exception>
        /// <exception cref="System.ArgumentException">The given version string was not a valid Version format.;version</exception>
        internal InternalIdMetadataAttribute(string id, string name, string version)
            : base(id, name, version)
        {
        }

    }
}
