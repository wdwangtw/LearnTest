using System.Linq;

namespace GuessNumber
{
    public class GuessNumber
    {
        public string Compare(string given, string guessed)
        {
            if (given == guessed)
            {
                return "4A0B";
            }

            int countOfSameCharForEachPositon = GetCountOfSameCharForEachPositon(given, guessed);
            int countOfCharsBothContains = GetCountOfCharsBothContains(given, guessed);

            return countOfSameCharForEachPositon.ToString() + "A" + 
                (countOfCharsBothContains - countOfSameCharForEachPositon) + "B";
        }

        private static int GetCountOfSameCharForEachPositon(string given, string guessed)
        {
            int countOfSameNumberAtSamePosition = 0;
            for (int i = 0; i < 4; i++)
            {
                if (given[i] == guessed[i])
                {
                    countOfSameNumberAtSamePosition++;
                }
            }

            return countOfSameNumberAtSamePosition;
        }

        public int GetCountOfCharsBothContains(string given, string guessed)
        {
            return given.ToList().Intersect(guessed.ToList()).Count();
        }
    }
}
