namespace widemeadows.ml.kohonen.model
{
    /// <summary>
    /// Interface IGrid2D
    /// </summary>
    public interface IGrid2D
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
        /// Gets the <see cref="INeuron"/> with the specified x.
        /// </summary>
        /// <param name="y">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <returns>NeuronNet.INeuron.</returns>
        INeuron this[int x, int y] { get; }
    }
}