using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YalalovNR.Sprint2.Task5.V13.Lib;

namespace Tyuiu.YalalovNR.Sprint2.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay_OrdinaryDay()
        {
            DataService ds = new DataService();
            int g = 2008, m = 6, n = 12;
            string wait = "2008, 6, 13";
            string res = ds.FindDateOfNextDay(g, m, n);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfNextDay_EndOfMonth()
        {
            DataService ds = new DataService();
            int g = 2008, m = 6, n = 30; 
            string wait = "2008, 7, 1";
            string res = ds.FindDateOfNextDay(g, m, n);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfNextDay_LeapFebruary()
        {
            DataService ds = new DataService();
            int g = 2008, m = 2, n = 29; 
            string wait = "2008, 3, 1";
            string res = ds.FindDateOfNextDay(g, m, n);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfNextDay_EndOfYear()
        {
            DataService ds = new DataService();
            int g = 2008, m = 12, n = 31; 
            string wait = "2009, 1, 1";
            string res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(wait, res);
        }
    }
}