using System;
using System.Text;
using System.Threading;
using Ucu.Poo.GameOfLife;

public class PrintBoard
{
    private Board board;
    private int delay;

    public Board Board
    {
        get => board;
        set => board = value;
    }

    public int Delay
    {
        get => delay;
        set => delay = value;
    }

    public PrintBoard(Board board, int delay = 350)
    {
        this.board = board;   // _board sera lo que reciba de board.
        this.delay = delay;   // _delay esta definido en la funcion PrintBoard, tiene un valor entero.
    }

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