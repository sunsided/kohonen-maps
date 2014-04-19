using System;
using System.ComponentModel.Composition;
using JetBrains.Annotations;

namespace Widemeadows.MachineLearning.Kohonen
{
    /// <summary>
    /// Class IdMetadataAttribute. This class cannot be inherited.
    /// </summary>
    [MetadataAttribute]
    public class IdMetadataAttribute : Attribute, IMetadata
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        [NotNull]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the version.
        /// </summary>
        /// <value>The version.</value>
        [NotNull]
        public string Version { get; private set; }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [NotNull]
        public string Id { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdMetadataAttribute"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="version">The version.</param>
        /// <exception cref="System.ArgumentException">The given ID string was not a valid GUID format.;id</exception>
        /// <exception cref="System.ArgumentException">The given version string was not a valid Version format.;version</exception>
        public IdMetadataAttribute([NotNull] string id, [NotNull] string name, [NotNull] string version)
        {
            ValidateGuid(id);
            ValidateVersion(version);

            Id = id;
            Name = name;
            Version = version;
        }

        /// <summary>
        /// Validates the version.
        /// </summary>
        /// <param name="version">The version.</param>
        /// <exception cref="System.ArgumentException">The given version string was not a valid Version format.;version</exception>
        private static void ValidateVersion([NotNull] string version)
        {
            Version ignored;
            if (!System.Version.TryParse(version, out ignored))
                throw new ArgumentException("The given version string was not a valid Version format.", "version");
        }

        /// <summary>
        /// Validates the unique identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <exception cref="System.ArgumentException">The given ID string was not a valid GUID format.;id</exception>
        private static void ValidateGuid([NotNull] string id)
        {
            Guid ignored;
            if (!Guid.TryParse(id, out ignored))
                throw new ArgumentException("The given ID string was not a valid GUID format.", "id");
        }
    }
}
