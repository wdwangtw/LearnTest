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
            Assert.Equal("4A0B", result);
        }

        [Theory]
        [InlineData("1234", "1256", 2)]
        [InlineData("1234", "1236", 3)]
        [InlineData("1234", "4321", 0)]
        [InlineData("1234", "7894", 1)]
        [InlineData("1234", "1234", 4)]
        void should_return_nAxB_when_have_N_same_number_for_each_position(string given, string guessed, int countOfN)
        {
            GuessNumber guessNumber = new GuessNumber();
            string result = guessNumber.Compare(given, guessed);
            string patten = countOfN.ToString() + @"A\dB";
            Assert.True(Regex.IsMatch(result, patten));
        }
    }
}
