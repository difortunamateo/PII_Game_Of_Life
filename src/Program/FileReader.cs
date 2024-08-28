using System;
using System.IO;

namespace Ucu.Poo.GameOfLife;

public class FileReader
{
    private string url = "/home/jwillmore/Nextcloud/univ/2semestre/prog2/proyectos/PII_Game_Of_Life/assets/board.txt";

    public Board ReturnBoard()
    {
        string content = File.ReadAllText(this.url);
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