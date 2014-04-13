using System.Collections;
using System.Collections.Generic;
using widemeadows.ml.kohonen.model;

namespace widemeadows.ml.kohonen.net
{
    /// <summary>
    /// Class DoubleVector. This class cannot be inherited.
    /// </summary>
    public class DoubleVector : IEnumerable<double>, IVector
    {
        /// <summary>
        /// The values
        /// </summary>
        private readonly double[] _values;

        /// <summary>
        /// Gets the length.
        /// </summary>
        /// <value>The length.</value>
        public int Length { get { return _values.Length; }}

        /// <summary>
        /// Gets the <see cref="System.Double"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>System.Double.</returns>
        public double this[int index]
        {
            get { return _values[index]; }
            set { _values[index] = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleVector"/> class.
        /// </summary>
        /// <param name="dimensions">The dimensions.</param>
        public DoubleVector(int dimensions)
        {
            _values = new double[dimensions];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleVector"/> class.
        /// </summary>
        /// <param name="values">The values.</param>
        public DoubleVector(double[] values)
        {
            _values = values;
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.</returns>
        public IEnumerator<double> GetEnumerator()
        {
            return ((IEnumerable<double>) _values).GetEnumerator();
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
