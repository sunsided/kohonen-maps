using widemeadows.ml.kohonen.model;

namespace widemeadows.ml.kohonen.net
{
    /// <summary>
    /// Class WeightVectorExtensions.
    /// </summary>
    public static class WeightVectorExtensions
    {
        /// <summary>
        /// Implements the +.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns>The result of the operator.</returns>
        public static IWeights AddInPlace(this IWeights a, IWeights b)
        {
            for (var i = 0; i < a.Length; ++i)
            {
                a[i] += b[i];
            }
            return a;
        }
        
        /// <summary>
        /// Implements the +.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns>The result of the operator.</returns>
        public static IWeights Add(this IWeights a, IWeights b)
        {
            var weights = new WeightVector(a.Length);
            return AddInPlace(weights, b);
        }


        /// <summary>
        /// Implements the +.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns>The result of the operator.</returns>
        public static IWeights AddScaledInPlace(this IWeights a, IWeights b, double s)
        {
            for (var i = 0; i < a.Length; ++i)
            {
                a[i] += b[i] * s;
            }
            return a;
        }

        /// <summary>
        /// Implements the +.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns>The result of the operator.</returns>
        public static IWeights AddScaled(this IWeights a, IWeights b, double s)
        {
            var weights = new WeightVector(a.Length);
            return AddScaledInPlace(weights, b, s);
        }

        /// <summary>
        /// Implements the -.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns>The result of the operator.</returns>
        public static IWeights SubtractInPlace(this IWeights a, IWeights b)
        {
            for (var i = 0; i < a.Length; ++i)
            {
                a[i] -= b[i];
            }
            return a;
        }


        /// <summary>
        /// Implements the -.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns>The result of the operator.</returns>
        public static IWeights Subtract(this IWeights a, IWeights b)
        {
            var weights = new WeightVector(a.Length);
            return SubtractInPlace(weights, b);
        }

        /// <summary>
        /// Implements the *.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="s">The s.</param>
        /// <returns>The result of the operator.</returns>
        public static IWeights ScaleInPlace(IWeights a, double s)
        {
            for (var i = 0; i < a.Length; ++i)
            {
                a[i] *= s;
            }
            return a;
        }

        /// <summary>
        /// Implements the *.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="s">The s.</param>
        /// <returns>The result of the operator.</returns>
        public static IWeights Scale(IWeights a, double s)
        {
            var weights = new WeightVector(a.Length);
            return ScaleInPlace(weights, s);
        }

    }
}
