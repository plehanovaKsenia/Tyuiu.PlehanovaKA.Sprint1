using Tyuiu.PlehanovaKA.Sprint1.Task2.V17.Lib;
namespace Tyuiu.PlehanovaKA.Sprint1.Task2.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 130;
            var res = ds.ConvertMinutesToHours(x);
            Assert.AreEqual(2, res);


        }
    }
}
