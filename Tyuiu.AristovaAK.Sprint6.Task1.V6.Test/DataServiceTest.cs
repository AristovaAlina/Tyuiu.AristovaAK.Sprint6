using Tyuiu.AristovaAK.Sprint6.Task1.V6.Lib;
namespace Tyuiu.AristovaAK.Sprint6.Task1.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            double[] wait = { 17.27, 14.08, 10.27, 6.65, 3.87, 2, -0.74, -3.7, -7.59, -11.55, -14.74 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
