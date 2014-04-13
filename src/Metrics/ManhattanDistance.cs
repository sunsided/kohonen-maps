﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using widemeadows.ml.kohonen.model;

namespace widemeadows.ml.kohonen.metrics
{
    /// <summary>
    /// Class ManhattanDistance.
    /// </summary>
    [Export(typeof(IMetric))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    [IdMetadataAttribute("642CC4FF-755B-4C90-B92C-7A40C16CE110", "Manhattan CalculateDistance", "1.0.0.0")]
    public sealed class ManhattanDistance : IMetric
    {
        /// <summary>
        /// Calculates the distance between two weight vectors.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns>System.Double.</returns>
        /// <exception cref="System.ArgumentException">Lengths of weight vectors differ.</exception>
        public double CalculateDistance(IWeights a, IWeights b)
        {
            return CalculateDistance(a.AsReadOnlyList, b.AsReadOnlyList);
        }

        /// <summary>
        /// Calculates the distance between two value vectors.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns>System.Double.</returns>
        /// <exception cref="System.ArgumentException">Lengths of weight vectors differ.</exception>
        public double CalculateDistance(IReadOnlyList<double> a, IReadOnlyList<double> b)
        {
            var length = a.Count;
            if (length != b.Count) throw new ArgumentException("Lengths of vectors differ.");

            // calculate sum of differences
            double distance = 0;
            for (int i = 0; i < length; ++i)
            {
                var difference = a[i] - b[i];
                distance += Math.Abs(difference);
            }
            return distance;
        }
    }
}
