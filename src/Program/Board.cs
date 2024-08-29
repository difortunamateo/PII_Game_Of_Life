namespace Ucu.Poo.GameOfLife;

public class Board
{
    private bool[,] CellState;

    public Board(int width, int height)
    {
        CellState = new bool[width, height];
    }

    public int GetLength(int num)
    {
        return CellState.GetLength(num);
    }

    public bool GetCellValue(int i, int j)
    {
        return CellState[i, j];
    }

    public void SetCellValue(int i, int j, bool value)
    {
        CellState[i, j] = value;
    }
}