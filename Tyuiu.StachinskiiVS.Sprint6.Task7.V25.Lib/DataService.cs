using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.StachinskiiVS.Sprint6.Task7.V25.Lib
{
    public class DataService : ISprint6Task7V25
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int rowCount = lines.Length;
            int colCount = lines[0].Split(';').Length;

            int[,] matrix = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < colCount; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int xCol = 6;

            for (int r = 0; r < rows; r++)
            {
                if (xCol < columns)
                {
                    if (matrix[r, xCol] % 5 == 0)
                    {
                        matrix[r, xCol] = 2;
                    }
                }
            }
            return matrix;
        }
    }
}