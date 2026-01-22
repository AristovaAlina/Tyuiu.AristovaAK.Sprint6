using Tyuiu.AristovaAK.Sprint6.Task4.V8.Lib;
namespace Tyuiu.AristovaAK.Sprint6.Task4.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            double[] wait = { -8.86, -7.19, -6.14, -4.76, -2.33, 1, 4.38, 0, 6.13, 7.07, 8.61};

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
