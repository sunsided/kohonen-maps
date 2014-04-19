using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using Widemeadows.MachineLearning.Kohonen.Data.Colors;
using Widemeadows.MachineLearning.Kohonen.Grid;
using Timer = System.Windows.Forms.Timer;

namespace Widemeadows.MachineLearning.Kohonen.Tests.RgbMesh
{
    public partial class Main : Form
    {
        /// <summary>
        /// The grid
        /// </summary>
        private IGrid2D _grid;

        /// <summary>
        /// The data set window
        /// </summary>
        private DataSet _dataSetWindow;

        /// <summary>
        /// The display mode
        /// </summary>
        private int _mode;

        public Main()
        {
            InitializeComponent();
            DoubleBuffered = true;

            var timer = new Timer {Interval = 2000};
            timer.Tick += TimerOnTick;
            timer.Start();
        }

        /// <summary>
        /// Timers the on tick. :)
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="eventArgs">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            Interlocked.Increment(ref _mode);
            Interlocked.CompareExchange(ref _mode, 0, 4);
            Invalidate();
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
            gr.SmoothingMode = SmoothingMode.HighQuality;
            gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gr.PixelOffsetMode = PixelOffsetMode.HighQuality;

            float w = Math.Min(xstep, ystep) * 0.85F;

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
                switch (_mode)
                {
                    default:
                        break;
                    case 1:
                        color = Color.FromArgb(r, r, r);
                        break;
                    case 2:
                        color = Color.FromArgb(g, g, g);
                        break;
                    case 3:
                        color = Color.FromArgb(b, b, b);
                        break;
                }

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

        /// <summary>
        /// Sets the data.
        /// </summary>
        /// <param name="dataSet">The data set.</param>
        public void SetData(IRgbDataSet dataSet)
        {
            if (_dataSetWindow == null)
            {
                _dataSetWindow = new DataSet();
                _dataSetWindow.Show(this);
            }

            _dataSetWindow.SetData(dataSet);
        }
    }
}
