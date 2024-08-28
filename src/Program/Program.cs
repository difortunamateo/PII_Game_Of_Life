using System;
using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = FileReader.ReturnBoard();
            while (true)
            {
                Console.Clear();
                PrintBoard.Print(board);
                
                Thread.Sleep(350);
                Logic.NewGeneration(board);
            }
        }
    }
}