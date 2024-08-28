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


}