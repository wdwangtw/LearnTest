using System;

namespace GuessNumber
{
    public class Game
    {
        private IFancyConsole fancyConsole;
        private NumberGenerator numberGenerator;
        private GuessNumber guessNumber;

        public Game(IRandomNumber randomNumber, IFancyConsole fancyConsole)
        {
            this.fancyConsole = fancyConsole;
            numberGenerator = new NumberGenerator(randomNumber);
            guessNumber = new GuessNumber();
        }

        static void Main(string[] args)
        {
            Game game = new Game(new RandomNumber(), new FancyConsole());
            game.Run();
        }

        public void Run()
        {
            string given = numberGenerator.GenerateNumber();
            int times = 6;
            string lastResult = null;
            while (times > 0 && lastResult != "4A0B")
            {
                string guessed = fancyConsole.ReadLine();
                string result = guessNumber.Compare(given, guessed);
                if (result != "4A0B")
                {
                    fancyConsole.WriteLine(result + string.Format(".You have {0} time(s) left.", --times));
                }
                else
                {
                    fancyConsole.WriteLine("4A0B.Bingo!");
                }
                lastResult = result;
            }
        }
    }
}