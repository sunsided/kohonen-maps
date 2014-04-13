using System.Collections.Generic;

namespace widemeadows.ml.kohonen.model
{
    /// <summary>
    /// Interface IWeights
    /// </summary>
    public interface IWeights
    {
        /// <summary>
        /// Gets the length.
        /// </summary>
        /// <value>The length.</value>
        int Length { get; }

        /// <summary>
        /// Gets the <see cref="System.Double"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>System.Double.</returns>
        double this[int index]
        {
            get; set;
        }

        /// <summary>
        /// Updates the weights.
        /// </summary>
        /// <param name="newWeights">The new weights.</param>
        /// <exception cref="System.ArgumentException">Lengths of weight vectors differ.</exception>
        void Update(IWeights newWeights);

        /// <summary>
        /// Gets as list.
        /// </summary>
        /// <value>As list.</value>
        IReadOnlyList<double> AsReadOnlyList { get; }
    }
}