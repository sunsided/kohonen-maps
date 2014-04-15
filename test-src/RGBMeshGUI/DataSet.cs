using System;
using System.Drawing;
using System.Windows.Forms;

namespace Widemeadows.MachineLearning.Kohonen.Tests.RgbMesh
{
    /// <summary>
    /// Class DataSet.
    /// </summary>
    public partial class DataSet : Form
    {
        /// <summary>
        /// The data set
        /// </summary>
        private IRgbDataSet _dataSet;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSet"/> class.
        /// </summary>
        public DataSet()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the data.
        /// </summary>
        /// <param name="dataSet">The data set.</param>
        public void SetData(IRgbDataSet dataSet)
        {
            _dataSet = dataSet;
            Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            var dataSet = _dataSet.Colors;
            var count = dataSet.Length;

            var ystep = ClientRectangle.Height / ((float)count);

            var gr = e.Graphics;

            var lastPos = (float) 0;
            foreach (var color in dataSet)
            {
                var y = lastPos;
                lastPos = y + ystep;

                gr.FillRectangle(new SolidBrush(color), ClientRectangle.Left, y, ClientRectangle.Width, ystep);
            }

            base.OnPaint(e);
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
