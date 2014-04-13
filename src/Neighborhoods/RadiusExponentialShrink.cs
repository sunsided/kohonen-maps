using System.ComponentModel.Composition;
using widemeadows.ml.kohonen.model;

namespace widemeadows.ml.kohonen.neighborhoods
{
    /// <summary>
    /// Class ExponentialShrink.
    /// </summary>
    [Export(typeof(IRadiusFunction))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [IdMetadataAttribute("075CC788-B067-4BEA-88E0-7E89EEC693EE", "Exponential Shrink", "1.0.0.0")]
    public sealed class RadiusExponentialShrink : ExponentialShrink, IRadiusFunction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RadiusExponentialShrink"/> class.
        /// </summary>
        /// <param name="totalIterations">The total number of iterations.</param>
        /// <param name="baseRadius">The base radius.</param>
        [ImportingConstructor]
        public RadiusExponentialShrink([Import("TotalIterations")] int totalIterations, [Import("BaseRadius")] double baseRadius)
            : base(totalIterations, baseRadius)
        {
        }

        /// <summary>
        /// Calculates the radius.
        /// </summary>
        /// <param name="iteration">The iteration.</param>
        /// <returns>System.Double.</returns>
        public double CalculateRadius(int iteration)
        {
            return Calculate(iteration);
        }
    }
}
