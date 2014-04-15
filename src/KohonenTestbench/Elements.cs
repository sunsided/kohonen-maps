using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using Widemeadows.MachineLearning.Kohonen.Model;
using Widemeadows.MachineLearning.Kohonen.Model.Learning;
using Widemeadows.MachineLearning.Kohonen.Model.Metrics;
using Widemeadows.MachineLearning.Kohonen.Model.Random;

namespace Widemeadows.MachineLearning.Kohonen.Testbench
{
    /// <summary>
    /// Class Elements. This class cannot be inherited.
    /// </summary>
    internal sealed class Elements
    {
        /// <summary>
        /// The random number generators
        /// </summary>
        [ImportMany(typeof(IRandomNumber))]
        public IEnumerable<Lazy<IRandomNumber, IMetadata>> RandomNumberGenerators = null;

        /// <summary>
        /// The metrics
        /// </summary>
        [ImportMany(typeof(IMetric))]
        public IEnumerable<Lazy<IMetric, IMetadata>> Metrics = null;

        /// <summary>
        /// The neighborhood functions
        /// </summary>
        [ImportMany(typeof(INeighborhoodFunction))]
        public IEnumerable<Lazy<INeighborhoodFunction, IMetadata>> NeighborhoodFunctions = null;

        /// <summary>
        /// The radius functions
        /// </summary>
        [ImportMany(typeof(IRadiusFunction))]
        public IEnumerable<Lazy<IRadiusFunction, IMetadata>> RadiusFunctions = null;

        /// <summary>
        /// The learning rate functions
        /// </summary>
        [ImportMany(typeof(ILearningRate))]
        public IEnumerable<Lazy<ILearningRate, IMetadata>> LearningRateFunctions = null;
    }
}
