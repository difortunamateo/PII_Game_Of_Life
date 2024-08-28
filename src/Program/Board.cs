namespace Ucu.Poo.GameOfLife;

public class Board
{
    //constructor
    Board(int LengthBoard, int WidthBoard)
    {
        this.cellState = new bool[WidthBoard, LengthBoard];
    }
    
    // Lista de booleanos con el estado del tablero
    private bool[,] cellState;
    
    public int GetLength(int num)
    {
        return cellState.GetLength(num);
    }

    public bool GetCellValue(int i, int j)
    {
        return cellState[i, j];
    }

    public void SetCellValue(int i, int j, bool value)
    {
        this.cellState[i, j] = value;
    }
}