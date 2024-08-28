using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Ucu.Poo.GameOfLife;

public class FileReader
{
    
    public static Board ReturnBoard()
    {
        string content = File.ReadAllText("board.txt");
        string[] contentLines = content.Split('\n');
        Board board = new Board(contentLines.Length, contentLines[0].Length);
        
        for (int y=0; y < contentLines.Length; y++)
        {
            for (int x=0; x<contentLines[y].Length; x++)
            {
                if(contentLines[y][x]=='1')
                {
                    board.SetCellValue(x, y, true);
                }
                else
                {
                    board.SetCellValue(x, y, false);
                }
            }
        }
        return board;
    }
}