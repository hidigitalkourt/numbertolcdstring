using System;
using System.Collections.Generic;
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
            var displayer = new Displayer();
            var actual = displayer.GetLCD(number);
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void DisplayerCanDisplayAOneLCDforNumber()
        {
            var number = 1;
            var expected = new string[]
            {
                "...",
                "..|",
                "..|"
            };
            var displayer = new Displayer();
            var actual = displayer.GetLCD(number);
            actual.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData(0, new string[]{"._.","|.|","|_|"} )]
        [InlineData(1, new string[]{"...","..|","..|"} )]
        [InlineData(2, new string[]{"._.","._|","|_."} )]
        [InlineData(3, new string[]{"._.","._|","._|"} )]
        [InlineData(4, new string[]{"...","|_|","..|"} )]
        [InlineData(5, new string[]{"._.","|_.","._|"} )]
        [InlineData(6, new string[]{"._.","|_.","|_|"} )]
        [InlineData(7, new string[]{"._.","..|","..|"} )]
        [InlineData(8, new string[]{"._.","|_|","|_|"} )]
        [InlineData(9, new string[]{"._.","|_|","..|"} )]
        public void DisplayerCanDisplaySingleDigitNumber(int integer, string[] lcdNumber)
        {
            var displayer = new Displayer();
            var actual = displayer.GetLCD(integer);
            actual.Should().BeEquivalentTo(lcdNumber);
        }
    }
}
