using System;

namespace GuessNumber
{
    public class RandomNumber : IRandomNumber
    {
        private Random rd = null;
        public RandomNumber()
        {
            rd = new Random(unchecked((int)DateTime.Now.Ticks));
        }
        public string GetNext()
        {
            return rd.Next(100, 9999).ToString();
        }
    }
}