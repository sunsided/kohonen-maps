using System;
using System.ComponentModel.Composition;

namespace widemeadows.ml.kohonen.model
{
    [MetadataAttribute]
    public sealed class IdMetadataAttribute : Attribute, IMetadata
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the version.
        /// </summary>
        /// <value>The version.</value>
        public string Version { get; private set; }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdMetadataAttribute"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="version">The version.</param>
        public IdMetadataAttribute(string id, string name, string version)
        {
            Id = id;
            Name = name;
            Version = version;
        }
    }
}
