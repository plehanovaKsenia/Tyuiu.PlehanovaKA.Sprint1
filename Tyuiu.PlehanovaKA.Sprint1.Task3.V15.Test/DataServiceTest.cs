using Tyuiu.PlehanovaKA.Sprint1.Task3.V15.Lib;
namespace Tyuiu.PlehanovaKA.Sprint1.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double v1 = 1;
            double v2 = 2;
            double s = 1;
            double t = 3;
            double wait = 10;
            var res = ds.DistanceOverTime(v1, v2, S, T);
            Assert.AreEqual(wait, res);

        }
    }
}
