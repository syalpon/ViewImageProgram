using System;
using System.IO;
using ViewImageProgram;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        private InputViewModel inputViewModel;
        [SetUp]
        public void Setup()
        {
            var size = 10;
            string id = "Circle";
            inputViewModel = new InputViewModel();
            inputViewModel.Circle_Create(size);
        }

        [Test]
        public void TestMethod_ViewModel_Circle()
        {
            Circle circle = new Circle(10);
            var test = inputViewModel.get_Cricle();
#pragma warning disable CS0184 // 'is' ���̎w�肳�ꂽ���͎w�肳�ꂽ�^�ł͂���܂���
            Assert.IsTrue(condition: test.GetType() is Circle);
#pragma warning restore CS0184 // 'is' ���̎w�肳�ꂽ���͎w�肳�ꂽ�^�ł͂���܂���
            Assert.AreNotEqual(inputViewModel.get_Cricle(), circle);
        }
    }
}