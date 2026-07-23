public class Crystal
{
    public bool[,] Grid { get; }

    public Crystal(
        int width,
        int height)
    {
        Grid = new bool[height, width];
    }
}
