namespace Ucu.Poo.GameOfLife
{
    class Logic
    {
        public static bool[,] NewGeneration()
        {
            bool[,] gameBoard = Board.GetCellState();
            int boardWidth = Board.GetLength(0);
            int boardHeight = Board.GetLength(1);

            bool[,] cloneboard = new bool[boardWidth, boardHeight];
            for (int x = 0; x < boardWidth; x++)
            {
                for (int y = 0; y < boardHeight; y++)
                {
                    int aliveNeighbors = CountAliveNeighbors(gameBoard, x, y, boardWidth, boardHeight);
                    cloneboard[x, y] = DetermineNextState(gameBoard[x, y], aliveNeighbors);
                }
            }
            return cloneboard;
        }

        private static int CountAliveNeighbors(bool[,] board, int x, int y, int width, int height)
        {
            int aliveNeighbors = 0;
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i >= 0 && i < width && j >= 0 && j < height && board[i, j])
                    {
                        aliveNeighbors++;
                    }
                }
            }
            if (board[x, y])
            {
                aliveNeighbors--;
            }
            return aliveNeighbors;
        }

        private static bool DetermineNextState(bool currentState, int aliveNeighbors)
        {
            if (currentState && aliveNeighbors < 2)
            {
                return false; // Célula muere por baja población
            }
            else if (currentState && aliveNeighbors > 3)
            {
                return false; // Célula muere por sobrepoblación
            }
            else if (!currentState && aliveNeighbors == 3)
            {
                return true; // Célula nace por reproducción
            }
            else
            {
                return currentState; // Célula mantiene el estado que tenía
            }
        }
    }
}