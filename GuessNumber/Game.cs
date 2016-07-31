namespace GuessNumber
{
    public class Game
    {
        public Game()
        {
            NumberGenerator numberGenerator = new NumberGenerator();
            numberGenerator.Generator = new RandomNumber();
        }

        static void Main(string[] args)
        {

        }

    }
}