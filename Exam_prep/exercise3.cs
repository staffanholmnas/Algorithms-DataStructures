namespace Exam_prep
{
    public class Rooms
    {
        public int Calculate(int[,] input)
        {
            int x = input.GetLength(0); // Rows
            int y = input.GetLength(1); // Columns
            int sumOfRooms = 0;
            bool[,] visited = new bool[x, y];

            // Go through the matrix column by column, left to right, top to bottom.
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    // When a non-visited floor tile is found, then recursively search neighboring tiles.
                    // Mark floor as visited and add the room to sum.
                    if (input[i, j] == 0 && !visited[i, j])
                    {
                        SearchFloorDFS(input, visited, i, j, x, y);
                        sumOfRooms++;
                    }
                }
            }

            return sumOfRooms;
        }

        static void SearchFloorDFS(int[,] input, bool[,] visited, int row, int col, int x, int y)
        {
            visited[row, col] = true;

            // Adjacent floor tile positions
            int[] rowPosition = new int[] { 0, -1, 0, 1 };
            int[] columnPosition = new int[] { -1, 0, 1, 0 };

            for (int i = 0; i < 4; i++)
            {
                // Check that we're not out of bounds and that we stand on a tile that we've not yet visited.
                if (CheckTiles(input, visited, row + rowPosition[i], col + columnPosition[i], x, y))
                {
                    // Recursively check the surrounding tiles.
                    SearchFloorDFS(input, visited, row + rowPosition[i], col + columnPosition[i], x, y);
                }
            }
        }

        static bool CheckTiles(int[, ] input, bool[, ] visited, int row, int col, int x, int y)
        { 
            // Check that we're not out of bounds and that we stand on a tile that we've not yet visited.
            if ((row >= 0) && (row < x) && (col >= 0) && (col < y) 
            && (input[row, col] == 0 && !visited[row, col])) return true;
            
            else return false;
        }
    }
}
