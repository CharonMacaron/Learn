using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LearnClassLibrary.Tests1
{
    [TestClass]
    public class LearnClassTest1
    {
        readonly LearnClass c = new LearnClass();
        [TestMethod]
        public void Test_TimeInSeconds()
        {
            int a = 2;
            int b = 3;
            int expected = 7380;

            
            int actual = c.TimeInSeconds(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_SecondsInTime()
        {
            int a = 3660;
            (int, int) expected = (1, 1);
            (int, int) actual = c.SecondsToTime(a);

            Assert.AreEqual(expected, actual);
        }
    }
}
