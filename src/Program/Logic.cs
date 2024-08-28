namespace Ucu.Poo.GameOfLife
{
    class Logic
    {
        public static void NewGeneration(Board board)
        {
            int boardWidth = board.GetLength(0);
            int boardHeight = board.GetLength(1);

            bool[,] cloneboard = new bool[boardWidth, boardHeight];
            for (int x = 0; x < boardWidth; x++)
            {
                for (int y = 0; y < boardHeight; y++)
                {
                    int aliveNeighbors = CountAliveNeighbors(board, x, y, boardWidth, boardHeight);
                    cloneboard[x, y] = DetermineNextState(board.GetCellValue(x, y), aliveNeighbors);
                }
            }

            for (int x = 0; x < boardWidth; x++)
            {
                for (int y = 0; y < boardHeight; y++)
                {
                    board.SetCellValue(x, y, cloneboard[x, y]);
                }
            }
        }

        private static int CountAliveNeighbors(Board board, int x, int y, int width, int height)
        {
            int aliveNeighbors = 0;
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i >= 0 && i < width && j >= 0 && j < height && board.GetCellValue(i, j))
                    {
                        aliveNeighbors++;
                    }
                }
            }

            if (board.GetCellValue(x, y))
            {
                aliveNeighbors--;
            }

            return aliveNeighbors;
        }

        private static bool DetermineNextState(bool currentState, int aliveNeighbors)
        {
            if (currentState && aliveNeighbors < 2)
            {
                return false; // Célula muere por soledad
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
                return currentState; // Célula mantiene su estado actual
            }
        }
    }
}