using System.IO;

namespace Ucu.Poo.GameOfLife;

public class FileReader
{
    private const string FilePath = "board.txt";

    public static Board ReturnBoard()
    {
        string content = File.ReadAllText(FilePath);
        string[] contentLines = content.Split('\n');
        Board board = new Board(contentLines.Length, contentLines[0].Length);
            
        for (int y=0; y<contentLines.Length; y++)
        {
            for (int x=0; x<contentLines[y].Length; x++)
            {
                if(contentLines[y][x]=='1')
                {
                    board.SetCellValue(x,y, true);
                }
            }
        }

        return board;
    }
}