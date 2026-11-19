using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YalalovNR.Sprint2.Task4.V23.Lib;
namespace Tyuiu.YalalovNR.Sprint2.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1() 
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 9;
            double wait = 1.012;

            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2() 
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 1;
            double wait = 60.8;

            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}