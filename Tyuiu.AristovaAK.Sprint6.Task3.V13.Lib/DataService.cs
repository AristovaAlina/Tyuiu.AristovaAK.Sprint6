using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AristovaAK.Sprint6.Task3.V13.Lib
{
    public class DataService : ISprint6Task3V13
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] result = (int[,])matrix.Clone();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                {
                    if (result[j, 1] > result[j + 1, 1])
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            int temp = result[j, k];
                            result[j, k] = result[j + 1, k];
                            result[j + 1, k] = temp;
                        }
                    }
                }
            }

            return result;
        }
    }
}
