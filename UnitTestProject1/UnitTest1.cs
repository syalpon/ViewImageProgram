using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using ViewImageProgram;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var size = 10;
            Square shape = new Square(size);
            Assert.AreEqual(shape.Height, 10);
            Assert.AreEqual(shape.Width , 10);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var size = 10;
            Circle circle = new Circle(size);
            Assert.AreEqual(circle.Radius, 10);
        }

    }
}
