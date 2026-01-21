using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AristovaAK.Sprint6.Task2.V18.Lib
{
    public class DataService : ISprint6Task2V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = stopValue - startValue + 1;
            double[] res = new double[count];

            for (int i = 0; i < count; i++)
            {
                double x = startValue + i;
                double result = ((3 * Math.Cos(x)) / (4 * x - 0.5)) + Math.Sin(x) - 5 * x - 2;
                res[i] = Math.Round(result, 2);
            }

            return res;
        } 
    }
}
