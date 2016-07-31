using System.Linq;

namespace GuessNumber
{
    public class NumberGenerator
    {
        public IRandomNumber Generator { get; set; }

        public string GenerateNumber()
        {
            string number = null;
            while (true)
            {
                number = Generator.GetNext();
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
