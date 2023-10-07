using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        [InlineData(9, "Fizz")]
        [InlineData(12, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        [InlineData(20, "Buzz")]
        [InlineData(7, "Whizz")]
        [InlineData(14, "Whizz")]
        [InlineData(28, "Whizz")]
        public void Should_return_Buzz_given_number_is_multiple_of_single_of_special_number(int inputNumber, string expectedCallOut)
        {
            // given
            int number = inputNumber;

            // when
            string callOut = FizzBuzz.FizzBuzz.CountOff(number);

            //then
            Assert.Equal(expectedCallOut, callOut);
        }
    }
}
