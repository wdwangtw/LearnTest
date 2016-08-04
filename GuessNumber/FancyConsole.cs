using System;

namespace GuessNumber
{
    class FancyConsole : IFancyConsole
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string status)
        {
            Console.WriteLine(status);
        }
    }
}