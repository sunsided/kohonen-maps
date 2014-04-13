using System;
using System.Diagnostics;
using System.Drawing;
using widemeadows.ml.kohonen.net;

namespace RGBMesh
{
    /// <summary>
    /// Class RGBVector.
    /// </summary>
    [DebuggerDisplay("{this[0]}, {this[1]}, {this[2]}")]
    class RGBVector : DoubleVector
    {
        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <color>The color.</color>
        public Color Color
        {
            get { return GetColor(); }
            set { SetColor(value); }
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="RGBVector"/> class.
        /// </summary>
        public RGBVector() : base(3)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RGBVector"/> class.
        /// </summary>
        public RGBVector(Color color)
            : this(color.R / 255.0, color.G / 255.0, color.B / 255.0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RGBVector"/> class.
        /// </summary>
        /// <param name="red">The red.</param>
        /// <param name="green">The green.</param>
        /// <param name="blue">The blue.</param>
        public RGBVector(double red, double green, double blue)
            : base(new[] {red, green, blue})
        {
            if (red < 0 || red > 1) throw new ArgumentOutOfRangeException("red", red, "Color component must be in range 0..1");
            if (green < 0 || green > 1) throw new ArgumentOutOfRangeException("green", green, "Color component must be in range 0..1");
            if (blue < 0 || blue > 1) throw new ArgumentOutOfRangeException("blue", blue, "Color component must be in range 0..1");
        }

        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name="color">The color.</param>
        private void SetColor(Color color)
        {
            var red = color.R / 255.0;
            var green = color.G / 255.0;
            var blue = color.B / 255.0;

            this[0] = red;
            this[1] = green;
            this[2] = blue;
        }

        /// <summary>
        /// Gets the color.
        /// </summary>
        /// <returns>Color.</returns>
        private Color GetColor()
        {
            var red = (int)this[0] * 255;
            Trace.Assert(red >= 0 && red <= 1, "Color component out of range");

            var green = (int)this[1] * 255;
            Trace.Assert(green >= 0 && green <= 1, "Color component out of range");

            var blue = (int)this[2] * 255;
            Trace.Assert(blue >= 0 && blue <= 1, "Color component out of range");

            return Color.FromArgb(red, green, blue);
        }
    }
}
