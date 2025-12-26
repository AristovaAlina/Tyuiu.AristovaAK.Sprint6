using Tyuiu.AristovaAK.Sprint6.Task0.V21.Lib;
namespace Tyuiu.AristovaAK.Sprint6.Task0.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 50;
            Assert.AreEqual(wait, res);
        }
    }
}
