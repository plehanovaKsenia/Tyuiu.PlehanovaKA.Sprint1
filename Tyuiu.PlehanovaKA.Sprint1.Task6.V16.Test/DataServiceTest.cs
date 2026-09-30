using Tyuiu.PlehanovaKA.Sprint1.Task6.V16.Lib;
namespace Tyuiu.PlehanovaKA.Sprint1.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string a = "abc!!?";
            Boolean wait = true;
            var res =  ds.CheckSpecSymbols(a);
            Assert.AreEqual(wait, res);
        }
    }
}
