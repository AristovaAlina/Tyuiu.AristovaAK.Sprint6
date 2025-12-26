using Tyuiu.AristovaAK.Sprint6.Task2.V18.Lib;
namespace Tyuiu.AristovaAK.Sprint6.Task2.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            double[] wait = { 7.27, 14.08, 10.27, 6.65, 3.87, 2.0, -0.74, -3.71, -7.59, -11.55, -14.74 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
