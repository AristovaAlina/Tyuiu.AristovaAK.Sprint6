using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AristovaAK.Sprint6.Task1.V6.Lib
{
    public class DataService : ISprint6Task1V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = stopValue - startValue + 1;
            double[] res = new double[count];

            for (int i = 0; i < count; i++)
            {
                double x = startValue + i;
                double result = ((Math.Sin(x) - 2 * x) / (3 * x - 1)) + Math.Sin(x) - 3 * x + 2;
                res[i] = Math.Round(result, 2);
            }

            return res;
        }
    }
}
