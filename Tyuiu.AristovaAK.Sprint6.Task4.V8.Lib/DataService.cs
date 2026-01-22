using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AristovaAK.Sprint6.Task4.V8.Lib
{
    public class DataService : ISprint6Task4V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = stopValue - startValue + 1;
            double[] res = new double[count];

            for (int i = 0; i < count; i++)
            {
                double x = startValue + i;
                if (2 - x != 0)
                {
                    double result = Math.Sin(x) + ((Math.Cos(x) + 1) / (2 - x)) + (2 * x);
                    res[i] = Math.Round(result, 2);
                }
                else
                {
                    res[i] = 0;
                }
            }

            return res;
        }
    }
}
