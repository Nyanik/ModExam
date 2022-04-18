using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSDiscount;

namespace UnitTestPrBooks
{
    [TestClass]
    public class UnitTestDis
    {
        [TestMethod]
        public void Check_Discoiunt005()
        {
            int rezult = 1900;

            Libr SD = new Libr();
            int actual = SD.SumDis(2000, 0.05);

            Assert.AreEqual(rezult, actual);
        }
        [TestMethod]
        public void Check_Discoiunt01()
        {
            int rezult = 1800;

            Libr SD = new Libr();
            int actual = SD.SumDis(2000, 0.1);

            Assert.AreEqual(rezult, actual);
        }
        [TestMethod]
        public void Check_Discoiunt015()
        {
            int rezult = 1700;

            Libr SD = new Libr();
            int actual = SD.SumDis(2000, 0.15);

            Assert.AreEqual(rezult, actual);
        }
    }
}
