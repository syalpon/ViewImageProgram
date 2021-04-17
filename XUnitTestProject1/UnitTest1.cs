using System;
using System.IO;
using ViewImageProgram;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod_ViewModel_Circle()
        {
            var size = 10;
            string id = "Circle";
            InputViewModel inputViewModel = new InputViewModel();
            inputViewModel.Circle_Create(size);
            Circle circle = new Circle(10);
            Assert.Equal(inputViewModel.get_Cricle(), circle);
        }
        [Fact]
        public void TestMethod_ViewModel_Square()
        {
            var size = 10;
            //string id = "Square";
            InputViewModel inputViewModel = new InputViewModel();
            inputViewModel.Square_Create(size);
            Square square = new Square(size);
            Assert.Equal(inputViewModel.square , square);
        }
    }
}
