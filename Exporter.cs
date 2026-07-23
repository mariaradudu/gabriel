using System.IO;

public class Exporter
{
    public void Save(
        Crystal crystal)
    {
        using var writer =
            new StreamWriter(
                "crystal.txt");

        int h =
            crystal.Grid.GetLength(0);

        int w =
            crystal.Grid.GetLength(1);

        for(int y=0;y<h;y++)
        {
            for(int x=0;x<w;x++)
            {
                writer.Write(
                    crystal.Grid[y,x]
                    ? "*"
                    : ".");
            }

            writer.WriteLine();
        }
    }
}
