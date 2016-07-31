using Xunit;

namespace GuessNumber.Test
{
    public class when_generate_random_number
    {
        [Fact]
        void should_get_4bit_and_none_repeat_number()
        {
            NumberGenerator numberGenerator = new NumberGenerator();

            RandomNumberStub generator = new RandomNumberStub();
            generator.SetNumbers(new string[] { "120", "1595", "1234", "4321" });
            numberGenerator.Generator = generator;

            Assert.Equal("1234", numberGenerator.GenerateNumber());
        }
    }
}