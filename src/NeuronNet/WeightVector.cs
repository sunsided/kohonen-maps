using System;
using System.Collections;
using System.Collections.Generic;
using widemeadows.ml.kohonen.model;

namespace widemeadows.ml.kohonen.net
{
    /// <summary>
    /// Class DoubleVector. This class cannot be inherited.
    /// </summary>
    public class WeightVector : IEnumerable<double>, IWeights
    {
        /// <summary>
        /// The weights
        /// </summary>
        private readonly double[] _weights;

        /// <summary>
        /// Gets the length.
        /// </summary>
        /// <value>The length.</value>
        public int Length { get { return _weights.Length; }}

        /// <summary>
        /// Gets the <see cref="System.Double"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>System.Double.</returns>
        public double this[int index]
        {
            get { return _weights[index]; }
            set { _weights[index] = value; }
        }

        /// <summary>
        /// Updates the weights.
        /// </summary>
        /// <param name="newWeights">The new weights.</param>
        /// <exception cref="System.ArgumentException">Lengths of weight vectors differ.</exception>
        public void Update(IWeights newWeights)
        {
            if (newWeights.Length != _weights.Length) throw new ArgumentException("Lengths of weight vectors differ.");
            for (var i = 0; i < newWeights.Length; ++i)
            {
                this[i] = newWeights[i];
            }
        }

        /// <summary>
        /// Gets as list.
        /// </summary>
        /// <value>As list.</value>
        public IReadOnlyList<double> AsReadOnlyList { get { return _weights; } }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeightVector"/> class.
        /// </summary>
        /// <param name="dimensions">The dimensions.</param>
        public WeightVector(int dimensions)
        {
            _weights = new double[dimensions];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeightVector"/> class.
        /// </summary>
        /// <param name="weights">The weights.</param>
        public WeightVector(double[] weights)
        {
            _weights = weights;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeightVector"/> class.
        /// </summary>
        /// <param name="weights">The weights.</param>
        public WeightVector(IWeights weights)
            : this(weights.Length)
        {
            for (var i = 0; i < weights.Length; ++i)
            {
                this[i] = weights[i];
            }
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.</returns>
        public IEnumerator<double> GetEnumerator()
        {
            return ((IEnumerable<double>) _weights).GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
