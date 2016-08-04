using System.Text;
using Xunit;

namespace GuessNumber.Test
{
    public class when_run_the_game
    {
        [Fact]
        void should_return_OK()
        {
            MockFancyConsole mockFancyConsole = new MockFancyConsole();
            mockFancyConsole.WhenCallReadLineWillReturnNumber("1234");

            RandomNumberStub randomNumberStub = new RandomNumberStub();
            randomNumberStub.SetNumbers(new [] {"1234"});

            Game game = new Game(randomNumberStub, mockFancyConsole);
            game.Run();

            Assert.Equal("4A0B", mockFancyConsole.WhenCalledWriteLineInputStatus());
        }
    }
}