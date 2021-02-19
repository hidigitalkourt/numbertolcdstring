using System;
using FluentAssertions;
using LCD;
using Xunit;

namespace LCDTests
{
    public class DisplayerTests
    {
        [Fact]
        public void DisplayerCanDisplayAZeroLCDforNumber()
        {
            var number = 0;
            var expected = new string[]
            {
                "._.",
                "|.|",
                "|_|"
            };
            var actual = Displayer.GetLCD(number);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
