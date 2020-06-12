using System;
using Xunit;
using AppCore;
using System.Threading.Tasks;

namespace test
{
    public class AddTwoNumbersUnitTest
    {
        [Fact]
        public void Add1Plus2ShouldBe3()
        {
            //Arrange
            int firstNumber = 1;
            int secondNumer = 2;

            //Act
            int result = firstNumber + secondNumer;
            //Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Add1Plus2ShouldBe3Refactored()
        {
            //Arrange
            AddTwoIntNumbers library = new AddTwoIntNumbers()
            {
                Number1 = 1,
                Number2 = 2,
            };

            //Act
            int result = library.Add();
            //Assert
            Assert.Equal(3, result);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(0, -2, -2)]
        [InlineData(0, 0, 0)]
        [InlineData(10, -22, -12)]
        public void AddTwoNumbers(int number1, int number2, int expectedResult)
        {
            //Arrange
            AddTwoIntNumbers library = new AddTwoIntNumbers()
            {
                Number1 = number1,
                Number2 = number2,
            };

            //Act
            int result = library.Add();
            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(0, -2, -2)]
        [InlineData(0, 0, 0)]
        [InlineData(10, -22, -12)]
        public async Task AddTwoNumbersAsync(int number1, int number2, int expectedResult)
        {
            //Arrange
            AddTwoIntNumbers library = new AddTwoIntNumbers()
            {
                Number1 = number1,
                Number2 = number2,
            };

            //Act
            int result = await library.AddAsync();
            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}