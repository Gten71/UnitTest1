using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using USQLCSharpProject1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 1;
            double b = 1.00015233;
            Class1 c = new Class1();
            double actual = c.Sec(x);
            Assert.AreEqual(b, actual, "Не правельный результат");

        }
    }
}
