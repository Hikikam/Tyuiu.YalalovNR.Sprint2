using Tyuiu.YalalovNR.Sprint2.Task3.V5.Lib;
namespace Tyuiu.YalalovNR.Sprint2.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2; 
            double res = ds.Calculate(x);
            double wait = -7;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0; 
            double res = ds.Calculate(x);
            double wait = -0.083;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -2; 
            double res = ds.Calculate(x);
            double wait = 0.02;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -10; 
            double res = ds.Calculate(x);
            double wait = -1100.01;
            Assert.AreEqual(wait, res);
        }
    }
}