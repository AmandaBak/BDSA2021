using Xunit;
using System;


namespace Assignment1.Test {

    public class isLeapYearTest {

        [Theory]
        [InlineData(1700, false)]
        [InlineData(1800, false)]
        [InlineData(1900, false)]
        [InlineData(1600, true)]
        [InlineData(2000, true)]
        public void test(int input, bool expected) {
            var actual = Program.IsLeapYear(input);
            Assert.Equal(expected, actual);            
        }
    }

}