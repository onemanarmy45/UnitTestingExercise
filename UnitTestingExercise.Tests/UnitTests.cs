using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(3, 7, 1, 11)]
        [InlineData(-4, -7, -1, -12)]
        [InlineData(3, 7, 8, 18)]
        [InlineData(13, 17, 7, 37)]
        [InlineData(27, 27, 0, 54)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object

            Calculator tester = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = tester.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 3, 3)]
        [InlineData(3, 2, 1)]
        [InlineData(7, 4, 3)]
        [InlineData(-4, -7, 3)]
        [InlineData(17, 13, 4)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange

            var tester = new Calculator();

            //Act

            var actual = tester.Subtract(minuend, subtrahend);

            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(3, 7, 21)]
        [InlineData(-4, 7, -28)]
        [InlineData(3, 8, 24)]
        [InlineData(4, 9, 36)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var tester = new Calculator();

            //Act
            var actual = tester.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(63, 9, 7)]
        [InlineData(88, 11, 8)]
        [InlineData(36, 6, 6)]
        [InlineData(25, 5, 5)]
        [InlineData(500, 50, 10)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var tester = new Calculator();

            //Act
            var actual = tester.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
