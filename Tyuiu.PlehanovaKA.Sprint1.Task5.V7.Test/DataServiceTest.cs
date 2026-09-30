using Tyuiu.PlehanovaKA.Sprint1.Task5.V7.Lib;
namespace Tyuiu.PlehanovaKA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double f = 180;
            int wait = 6;
            var res = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(wait, res);
        }
    }
}
