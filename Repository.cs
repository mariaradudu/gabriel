public class Repository
{
    public Crystal Create()
    {
        var crystal = new Crystal(
            Config.Width,
            Config.Height);

        foreach(var point in SampleSeeds.Points)
        {
            crystal.Grid[
                point.Y,
                point.X] = true;
        }

        return crystal;
    }
}
