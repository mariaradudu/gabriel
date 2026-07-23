using System;

public class Statistics
{
    public void Print(
        Crystal crystal)
    {
        int filled = 0;

        int total =
            crystal.Grid.Length;

        foreach(bool cell
            in crystal.Grid)
        {
            if(cell)
                filled++;
        }

        Console.WriteLine(
            $"Crystal cells: {filled}");

        Console.WriteLine(
            $"Coverage: {(filled*100)/total}%");
    }
}
