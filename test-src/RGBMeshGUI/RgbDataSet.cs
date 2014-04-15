using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Widemeadows.MachineLearning.Kohonen.Model;
using Widemeadows.MachineLearning.Kohonen.Model.Data;
using Widemeadows.MachineLearning.Kohonen.Model.Random;

namespace Widemeadows.MachineLearning.Kohonen.Tests.RgbMesh
{
    /// <summary>
    /// Class RgbDataSet.
    /// </summary>
    class RgbDataSet : IRgbDataSet
    {
        /// <summary>
        /// The colors
        /// </summary>
        private readonly Color[] _colors;

        /// <summary>
        /// Gets the colors.
        /// </summary>
        /// <value>The colors.</value>
        public Color[] Colors { get { return _colors; } }

        /// <summary>
        /// Initializes a new instance of the <see cref="RgbDataSet" /> class.
        /// </summary>
        /// <param name="colors">The colors.</param>
        public RgbDataSet(IEnumerable<Color> colors)
        {
            _colors = colors.ToArray();
        }

        /// <summary>
        /// Picks a random datum from the data.
        /// </summary>
        /// <param name="generator">The generator.</param>
        /// <returns>IDatum.</returns>
        public IDatum PickRandom(IRandomNumber generator)
        {
            var size = _colors.Length;
            var index = (int)generator.GetDouble(0, size - 1);
            var color = _colors[index];
            return new ColorDatum(color);
        }

        /// <summary>
        /// Gets a value indicating whether this data set supports editing.
        /// </summary>
        /// <value><c>true</c> if this data set supports editing; otherwise, <c>false</c>.</value>
        public bool SupportsEdit { get { return false; } }

        /// <summary>
        /// Gets a value indicating whether this data set supports creation of new data.
        /// </summary>
        /// <value><c>true</c> if this data set supports creation; otherwise, <c>false</c>.</value>
        public bool SupportsCreate { get { return false; } }

        /// <summary>
        /// Gets a value indicating whether this data set supports removal.
        /// </summary>
        /// <value><c>true</c> if this data set supports removal; otherwise, <c>false</c>.</value>
        public bool SupportsRemove { get { return false; } }

        /// <summary>
        /// Edits the specified datum.
        /// </summary>
        /// <param name="datum">The datum.</param>
        /// <returns><c>true</c> if the instance was edited successfully, <c>false</c> otherwise.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool EditDatum(IDatum datum)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Removes the specified datum.
        /// </summary>
        /// <param name="datum">The datum.</param>
        /// <returns><c>true</c> if the instance was removed successfully, <c>false</c> otherwise.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool RemoveDatum(IDatum datum)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Creates a new datum.
        /// </summary>
        /// <returns><c>true</c> if the datum was created successfully, <c>false</c> otherwise.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool CreateDatum()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.</returns>
        public IEnumerator<IDatum> GetEnumerator()
        {
            return _colors.Select(color => new ColorDatum(color)).Cast<IDatum>().GetEnumerator();
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
