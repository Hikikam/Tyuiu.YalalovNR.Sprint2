using Tyuiu.YalalovNR.Sprint2.Task6.V5.Lib;
namespace Tyuiu.YalalovNR.Sprint2.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheackCard1()
        {
            DataService ds = new DataService();
            int value = 6;
            string wait = "Шестёрка";
            string res = ds.FindCardValue(value);
            Assert.AreEqual(wait, res);
        }
    }
}
