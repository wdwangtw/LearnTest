using System;

namespace GuessNumber
{
    public class Game
    {
        private IFancyConsole fancyConsole;
        private IRandomNumber randomNumber;


        public Game(IRandomNumber randomNumber, MockFancyConsole fancyConsole)
        {
            this.randomNumber = randomNumber;
            this.fancyConsole = fancyConsole;
        }

        static void Main(string[] args)
        {

        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}