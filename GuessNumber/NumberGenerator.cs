using System.Linq;

namespace GuessNumber
{
    public class NumberGenerator
    {
        private IRandomNumber generator;
        public NumberGenerator(IRandomNumber generator)
        {
            this.generator = generator;
        }

        public string GenerateNumber()
        {
            string number = null;
            while (true)
            {
                number = generator.GetNext();
                if (number.Length == 3)
                {
                    number = "0" + number;
                }

                if (number.ToCharArray().Distinct().Count() == 4)
                    break;
            }

            return number;
        }
    }
}
