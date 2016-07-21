using System.Text.RegularExpressions;
using Xunit;

namespace GuessNumber.Test
{
    public class compare_given_number_and_guessed_number
    {
        [Fact]
        void should_return_0A4B_when_given_and_guessed_are_total_same()
        {
            GuessNumber guessNumber = new GuessNumber();
            const string givenAndGuessed= "1234";
            string result = guessNumber.Compare(givenAndGuessed, givenAndGuessed);
            Assert.Equal("0A4B", result);
        }

        [Theory]
        [InlineData("1234", "1256")]
        [InlineData("1234", "1324")]
        [InlineData("0534", "7834")]
        void should_return_2AxB_when_have_2_same_number_for_each_position(string given, string guessed)
        {
            GuessNumber guessNumber = new GuessNumber();
            string result = guessNumber.Compare(given, guessed);
            Assert.True(Regex.IsMatch(result, @"2A\dB"));
        }
    }
}
