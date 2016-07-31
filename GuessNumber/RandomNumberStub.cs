namespace GuessNumber
{
    public class RandomNumberStub : IRandomNumber
    {
        private string[] numbers = null;
        private int curIndex = 0;
        public string GetNext()
        {
            return numbers[curIndex ++];
        }

        public void SetNumbers(string[] numbers)
        {
            this.numbers = numbers;
        }
    }
}