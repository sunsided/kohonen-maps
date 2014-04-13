using System;

namespace widemeadows.ml.kohonen.neighborhoods
{
    /// <summary>
    /// Class ExponentialShrink.
    /// </summary>
    public abstract class ExponentialShrink
    {
        /// <summary>
        /// The _total iterations
        /// </summary>
        private readonly int _totalIterations;

        /// <summary>
        /// The _base radius
        /// </summary>
        private readonly double _baseAmount;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExponentialShrink"/> class.
        /// </summary>
        /// <param name="totalIterations">The total iterations.</param>
        /// <param name="baseAmount">The base amount.</param>
        protected ExponentialShrink(int totalIterations, double baseAmount)
        {
            _totalIterations = totalIterations;
            _baseAmount = baseAmount;
        }

        /// <summary>
        /// Calculates the amount for the specified iteration.
        /// </summary>
        /// <param name="iteration">The iteration.</param>
        /// <returns>System.Double.</returns>
        protected double Calculate(int iteration)
        {
            var radius = _baseAmount;
            return radius * Math.Exp(-(double)iteration / _totalIterations / Math.Log(radius));
        }
    }
}
