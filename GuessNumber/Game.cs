using System;

namespace GuessNumber
{
    public class Game
    {
        private IFancyConsole fancyConsole;
        private NumberGenerator numberGenerator;
        private GuessNumber guessNumber;


        public Game(IRandomNumber randomNumber, MockFancyConsole fancyConsole)
        {
            this.fancyConsole = fancyConsole;
            numberGenerator = new NumberGenerator(randomNumber);
            guessNumber = new GuessNumber();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(string.Format(".You have {0} time(s) left.", 5));
        }

        public void Run()
        {
            string given = numberGenerator.GenerateNumber();
            int times = 2;

            while (times > 0)
            {
                string guessed = fancyConsole.ReadLine();
                string result = guessNumber.Compare(given, guessed);
                if (result != "4A0B")
                {
                    fancyConsole.WriteLine(result + string.Format(".You have {0} time(s) left.", --times + 4));
                }
                else
                {
                    break;
                }
            }

            if (times != 0)
            {
                fancyConsole.WriteLine("4A0B.Bingo!");
            }
        }
    }
}