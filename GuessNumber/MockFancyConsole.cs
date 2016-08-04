using System;
using System.Collections.Generic;

namespace GuessNumber
{
    public class MockFancyConsole : IFancyConsole
    {
        private string[] inputNumbers = null;
        private int indexOfRead = 0;
        private string outputStatus = string.Empty;


        public string ReadLine()
        {
            if (inputNumbers != null)
            {
                return inputNumbers[indexOfRead++];
            }
            throw new NotImplementedException();
        }

        public void WriteLine(string status)
        {
            outputStatus += status;
            outputStatus += "\n";
        }

        public void WhenCallReadLineWillReturnNumbers(string[] numbers)
        {
            inputNumbers = numbers;
        }

        public string WhenCalledWriteLineInputStatus()
        {
            if (outputStatus != null)
            {
                return outputStatus;
            }
            throw new NotSupportedException("Have not call WriteLine");
        }
    }
}