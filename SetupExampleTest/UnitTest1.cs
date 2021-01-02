using SetupExample;
using System;
using Xunit;

namespace SetupExampleTest
{
    public class UnitTest1
    {
        [Fact]
        public void ShowAddOnePluThreeTest1()
        {
            //Arrange

            var num1 = 1;
            var num2 = 3;

            var calculator = new Calculator();
            var expectedResult = 4;

            //Act

            var result = calculator.Addition(num1, num2);




            //Assert

            Assert.Equal(expectedResult,result);
        }
    }
}
