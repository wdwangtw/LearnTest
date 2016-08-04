using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuessNumber.Test
{
    public class when_run_the_game
    {
        [Fact]
        void should_return_4A0B()
        {
            RandomNumberStub randomNumberStub = new RandomNumberStub();
            randomNumberStub.SetNumbers(new[] { "1234" });

            MockFancyConsole mockFancyConsole = new MockFancyConsole();
            mockFancyConsole.WhenCallReadLineWillReturnNumbers(new[] { "1234"});
            Game game = new Game(randomNumberStub, mockFancyConsole);
            game.Run();

            Assert.Equal("4A0B.Bingo!\n", mockFancyConsole.WhenCalledWriteLineInputStatus());
        }

        [Fact]
        void should_return_1A2B_and_5_times_left()
        {
            RandomNumberStub randomNumberStub = new RandomNumberStub();
            randomNumberStub.SetNumbers(new[] { "1329" });

            MockFancyConsole mockFancyConsole = new MockFancyConsole();
            mockFancyConsole.WhenCallReadLineWillReturnNumbers(new[] { "1234" } );
            Game game = new Game(randomNumberStub, mockFancyConsole);
            game.Run();

            Assert.Equal("1A2B.You have 5 time(s) left.\n", mockFancyConsole.WhenCalledWriteLineInputStatus());
        }


        [Fact]
        void should_return_1A2B_2A2B_and_5_4__times_left()
        {
            RandomNumberStub randomNumberStub = new RandomNumberStub();
            randomNumberStub.SetNumbers(new[] { "1329" });

            MockFancyConsole mockFancyConsole = new MockFancyConsole();
            Game game = new Game(randomNumberStub, mockFancyConsole);

            mockFancyConsole.WhenCallReadLineWillReturnNumbers(new [] { "1234" , "1392" } );
            game.Run();
            Assert.Equal("1A2B.You have 5 time(s) left.\n2A2B.You have 4 time(s) left.\n", mockFancyConsole.WhenCalledWriteLineInputStatus());
        }
    }
}