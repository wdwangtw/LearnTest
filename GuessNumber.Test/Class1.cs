using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GuessNumber.Test
{
    public class Class1
    {
        [Fact]
        void test_xunit()
        {
            Assert.True(true);
        }

        [Fact]
        void test_reference_GuessNumber_project()
        {
            GuessNumber guessNumber = new GuessNumber();
            Assert.True(guessNumber.TestForXunit());
        }
    }
}
