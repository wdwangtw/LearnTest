using System.Linq;
using Xunit;

namespace GuessNumber.Test
{
    public class when_generate_random_number
    {
        [Fact]
        void should_get_4bit_and_none_repeat_number_use_RandomNumberStub()
        {
            NumberGenerator numberGenerator = new NumberGenerator();

            RandomNumberStub generator = new RandomNumberStub();
            generator.SetNumbers(new string[] { "120", "1595", "1234", "4321" });
            numberGenerator.Generator = generator;

            Assert.Equal("1234", numberGenerator.GenerateNumber());
        }

        [Fact]
        void should_get_4bit_and_none_repeat_number_use_RandomNumber()
        {
            NumberGenerator numberGenerator = new NumberGenerator();
            RandomNumber generator = new RandomNumber();
            numberGenerator.Generator = generator;

            string generateNumber = numberGenerator.GenerateNumber();
            Assert.Equal(4, generateNumber.Length);
            Assert.Equal(4, generateNumber.ToCharArray().Distinct().Count());
        }
    }
}