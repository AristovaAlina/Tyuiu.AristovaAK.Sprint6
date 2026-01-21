using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AristovaAK.Sprint6.Task3.V13.Lib
{
    public class DataService : ISprint6Task3V13
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = matrix;


            int[] secondCol = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                secondCol[i] = matrix[i, 1];
            }

            Array.Sort(secondCol);


            for (int j = 0; j < rows; j++)
            {
                result[j, 1] = secondCol[j];
            }


            return result;
        }
    }
}
