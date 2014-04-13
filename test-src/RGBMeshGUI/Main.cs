using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using widemeadows.ml.kohonen.model;

namespace RGBMeshGUI
{
    public partial class Main : Form
    {
        /// <summary>
        /// The grid
        /// </summary>
        private IGrid2D _grid;

        public Main()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        /// <summary>
        /// Sets the grid.
        /// </summary>
        /// <param name="grid">The grid.</param>
        public void SetGrid(IGrid2D grid)
        {
            _grid = grid;
            Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            var grid = _grid;

            int width = grid.Width;
            int height = grid.Height;

            var xstep = ClientRectangle.Width/((float) width + 1);
            var ystep = ClientRectangle.Height / ((float)width + 1);

            var gr = e.Graphics;
            float w = Math.Min(xstep, ystep) * 0.5F;

            foreach (var gn in grid)
            {
                var pos = gn.GridCoordinates;
                var x = xstep + (float) pos[0]*xstep - w/2;
                var y = ystep + (float) pos[1]*ystep - w/2;

                var valid = !(gn.Neuron.Weights[0] < 0 || gn.Neuron.Weights[0] > 1 || gn.Neuron.Weights[1] < 0 ||
                             gn.Neuron.Weights[1] > 1 || gn.Neuron.Weights[2] < 0 || gn.Neuron.Weights[2] > 1);

                var r = (int)Clamp(gn.Neuron.Weights[0] * 255.0, 0.0, 255.0);
                var g = (int)Clamp(gn.Neuron.Weights[1] * 255.0, 0.0, 255.0);
                var b = (int)Clamp(gn.Neuron.Weights[2] * 255.0, 0.0, 255.0);
                var color = Color.FromArgb(r, g, b);

                if (valid)
                {
                    gr.FillEllipse(new SolidBrush(color), x, y, w, w);
                }
                else
                {
                    gr.DrawEllipse(new Pen(new SolidBrush(color)), x, y, w, w);
                }
            }

            base.OnPaint(e);
        }

        private double Clamp(double value, double min = 0, double max = 1)
        {
            return value < min ? min : (value > max ? max : value);
        }

        /// <summary>
        /// Raises the <see cref="E:Resize" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnResize(EventArgs e)
        {
            Invalidate();
        }
    }
}
