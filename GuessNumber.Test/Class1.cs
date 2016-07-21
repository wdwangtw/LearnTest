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
    }
}
