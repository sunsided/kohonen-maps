namespace widemeadows.ml.kohonen.model
{
    /// <summary>
    /// Interface IGrid2D
    /// </summary>
    public interface IGrid2D : IGrid
    {
        /// <summary>
        /// Gets the grid width.
        /// </summary>
        /// <value>The width.</value>
        int Width { get; }

        /// <summary>
        /// Gets the grid height.
        /// </summary>
        /// <value>The height.</value>
        int Height { get; }

        /// <summary>
        /// Gets the <see cref="INeuron" /> with the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>NeuronNet.INeuron.</returns>
        INeuron this[int x, int y] { get; }
    }
}