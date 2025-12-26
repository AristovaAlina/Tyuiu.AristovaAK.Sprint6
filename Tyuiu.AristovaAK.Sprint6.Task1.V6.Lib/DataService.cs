using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AristovaAK.Sprint6.Task1.V6.Lib
{
    public class DataService : ISprint6Task1V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[Math.Abs(startValue) + Math.Abs(stopValue)];
            for (int i = 0; i < Math.Abs(startValue) + Math.Abs(stopValue); i++)
            {
                if ((3 * startValue - 1) == 0)
                {
                    res[i] = 0;
                }
                else
                {
                    double r = Math.Round(((Math.Sin(startValue) - 2 * startValue) / (3 * startValue - 1)) + Math.Sin(startValue) - 3 * startValue + 2, 2);
                    res[i] = r;
                }
                startValue++;
            }
            return res;
        }
    }
}
