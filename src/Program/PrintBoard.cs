using System;
using System.Text;
using Ucu.Poo.GameOfLife;

public class PrintBoard
{
    public static void Print(Board board)
    {
        int width = board.GetLength(0);
        int height = board.GetLength(1);
        StringBuilder s = new StringBuilder();

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (board.GetCellValue(x, y))
                {
                    s.Append("|X|");
                }
                else
                {
                    s.Append("___");
                }
            }

            s.Append("\n");
        }

        Console.WriteLine(s.ToString());
    }
}