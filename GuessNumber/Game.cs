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

        }

        public void Run()
        {
            string given = numberGenerator.GenerateNumber();
            string guessed = fancyConsole.ReadLine();
            fancyConsole.WriteLine(guessNumber.Compare(given, guessed));
        }
    }
}