public class GrowthEngine
{
    public void Simulate(
        Crystal crystal)
    {
        var generator =
            new CrystalGenerator();

        for(int i=0;
            i<Config.Iterations;
            i++)
        {
            generator.Grow(
                crystal);
        }
    }
}
