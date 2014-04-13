using System;
using System.ComponentModel.Composition;
using System.Threading;
using widemeadows.ml.kohonen.model;

namespace RandomNumberGenerator
{
    /// <summary>
    /// Class XorShiftRng. This class cannot be inherited.
    /// </summary>
    [Export(typeof(IRandomNumber))]
    public sealed class XorShiftRng : IRandomNumber
    {
        /// <summary>
        /// The current seed value
        /// </summary>
        private long _value;

        /// <summary>
        /// The lock
        /// </summary>
        private SpinLock _lock = new SpinLock(enableThreadOwnerTracking:false);

        /// <summary>
        /// Initializes a new instance of the <see cref="XorShiftRng"/> class.
        /// </summary>
        public XorShiftRng()
        {
            var timeSpan = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            _value = (long) timeSpan.TotalMilliseconds;
        }

        /// <summary>
        /// Sets the seed for the generator.
        /// </summary>
        /// <param name="seed">The seed.</param>
        public void SetSeed(long seed)
        {
            Interlocked.Exchange(ref _value, seed);
        }

        /// <summary>
        /// Gets a <see cref="System.Double" /> value in the range of <paramref name="min" /> to <paramref name="max" />.
        /// </summary>
        /// <param name="min">The minimum value (inclusive).</param>
        /// <param name="max">The maximum value (inclusive).</param>
        /// <returns>System.Double.</returns>
        public double GetDouble(double min = 0, double max = 1)
        {
            var randomLong = GetLong();
            var scaledToStandard = ((double) randomLong - (double)Int64.MinValue)/((double)Int64.MaxValue - (double)Int64.MinValue);
            return scaledToStandard*(max - min) + min;
        }

        /// <summary>
        /// Gets the long.
        /// </summary>
        /// <returns>System.Int64.</returns>
        public long GetLong()
        {
            // lock against concurrent calls of GetLong()
            bool lockTaken = false;
            _lock.Enter(ref lockTaken);
            try
            {
                // store random number for atomic check
                var knownValue = _value;

                // generate new random number
                var x = knownValue;
                x ^= (x << 12);
                x ^= (x >> 25);
                x ^= (x << 27);

                // swap seed only if it was not replaced by a call to SetSeed()
                Interlocked.CompareExchange(ref _value, x, knownValue);

                // return the new random number
                return x;
            }
            finally
            {
                if (lockTaken) _lock.Exit(useMemoryBarrier: false);
            }
        }
    }
}
