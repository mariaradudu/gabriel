using System;

public class Renderer
{
    public void Draw(
        Crystal crystal)
    {
        int h = crystal.Grid.GetLength(0);

        int w = crystal.Grid.GetLength(1);

        Console.WriteLine();

        for(int y=0;y<h;y++)
        {
            for(int x=0;x<w;x++)
            {
                Console.Write(
                    crystal.Grid[y,x]
                    ? "*"
                    : ".");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}
