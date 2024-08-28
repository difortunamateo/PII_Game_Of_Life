using System;
using System.Text;
using System.Threading;

public class PrintBoard
{
    private Board _board;
    private int _delay;

    public PrintBoard(Board board, int delay = 350)
    {
        _board = board;   // _board sera lo que reciba de board.
        _delay = delay;   // _delay esta definido en la funcion PrintBoard, tiene un valor entero.
    }

    public void Start()
    {
        while (true)
        {
            Console.Clear();
            Print();

            _board.NewGeneration();

            Thread.Sleep(_delay);
        }
    }

    private void Print()
    {
        int width = _board.Width;
        int height = _board.Height;
        StringBuilder s = new StringBuilder();

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (_board.GetCell(x, y))
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