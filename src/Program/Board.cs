namespace Ucu.Poo.GameOfLife;

public class Board
{
    
    
    // Lista de booleanos con el estado del tablero
    private bool[,] cellState;

    public bool[,] CellState
    {
        get { return cellState; }

        set { this.cellState= value; }
    }

    public int GetLenght(int num)
    {
        return CellState.GetLength(num);
    }

    public bool GetCellValue(int i, int j)
    {
        return CellState[i, j];
    }

    public void SetCellValue(int i, int j, bool value)
    {
        this.cellState[i, j] = value;
    }
}