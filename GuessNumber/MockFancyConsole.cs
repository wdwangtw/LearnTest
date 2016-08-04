using System;

namespace GuessNumber
{
    class MockFancyConsole : IFancyConsole
    {
        private string numberFromRead = null;
        private string statusFromWrite = null;
        public string ReadLine()
        {
            if (numberFromRead != null)
            {
                return numberFromRead;
            }
            throw new NotImplementedException();
        }

        public void WriteLine(string status)
        {
            statusFromWrite = status;
        }

        public void WhenCallReadLineReturnNumber(string number)
        {
            numberFromRead = number;
        }

        public string WhenCallWriteLineInputStatus()
        {
            if (statusFromWrite != null)
            {
                return statusFromWrite;
            }
            throw new NotSupportedException("Have not call WriteLine");
        }
    }
}