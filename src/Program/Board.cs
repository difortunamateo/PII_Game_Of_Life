namespace Ucu.Poo.GameOfLife;

public class Board
{
    // Lista de booleanos con el estado del tablero
    private bool[,] CellState;

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