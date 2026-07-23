using System;

public class CrystalGenerator
{
    private readonly Random random = new();

    public void Grow(
        Crystal crystal)
    {
        var next =
            (bool[,])crystal.Grid.Clone();

        int h = crystal.Grid.GetLength(0);

        int w = crystal.Grid.GetLength(1);

        for(int y=1;y<h-1;y++)
        {
            for(int x=1;x<w-1;x++)
            {
                if(crystal.Grid[y,x])
                    continue;

                int neighbors = 0;

                for(int dy=-1;dy<=1;dy++)
                {
                    for(int dx=-1;dx<=1;dx++)
                    {
                        if(crystal.Grid[
                            y+dy,
                            x+dx])
                        {
                            neighbors++;
                        }
                    }
                }

                if(neighbors>=2 &&
                   random.NextDouble()>0.35)
                {
                    next[y,x]=true;
                }
            }
        }

        Array.Copy(
            next,
            crystal.Grid,
            next.Length);
    }
}
